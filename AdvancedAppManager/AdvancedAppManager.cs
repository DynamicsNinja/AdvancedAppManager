using McTools.Xrm.Connection;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Fic.XTB.AdvancedAppManager.Forms;
using Fic.XTB.AdvancedAppManager.Model;
using Fic.XTB.AdvancedAppManager.Proxy;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Messages;
using Newtonsoft.Json;
using XrmToolBox.Extensibility;
using XrmToolBox.Extensibility.Interfaces;
using OrganizationRequest = Microsoft.Xrm.Sdk.OrganizationRequest;

namespace Fic.XTB.AdvancedAppManager
{
    public partial class AdvancedAppManager : PluginControlBase, IGitHubPlugin, IPayPalPlugin
    {
        public string RepositoryName => "AdvancedAppManager";
        public string UserName => "DynamicsNinja";
        public string DonationDescription => "Thanks for supporting Advanced App Manager";
        public string EmailAccount => "ivan.ficko@outlook.com";

        private Settings mySettings;

        public List<string> ScriptLibraries;
        public List<AppSettings> AppSettings;
        public List<SecurityRole> SecurityRoles;
        public List<Entity> Images;

        public string AppId;
        public string AppUniqueName;

        public DataGridView DgvEvents;
        public DataGridView DgvAppSettings;

        private IconGalleryForm _imageGalleryForm;

        public AdvancedAppManager()
        {
            InitializeComponent();

            wvIcon.EnsureCoreWebView2Async();

            dgvAppSettings.AutoGenerateColumns = false;

            DgvEvents = dgvEvents;
            DgvAppSettings = dgvAppSettings;
        }

        #region Events

        private void AdvancedAppManager_Load(object sender, EventArgs e)
        {
            if (!SettingsManager.Instance.TryLoad(GetType(), out mySettings))
            {
                mySettings = new Settings();

                LogWarning("Settings not found => a new settings file has been created!");
            }
            else
            {
                LogInfo("Settings found and loaded");
            }
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            CloseTool();
        }

        private void AdvancedAppManager_OnCloseTool(object sender, EventArgs e)
        {
            SettingsManager.Instance.Save(GetType(), mySettings);
        }

        public override void UpdateConnection(IOrganizationService newService, ConnectionDetail detail, string actionName, object parameter)
        {
            base.UpdateConnection(newService, detail, actionName, parameter);

            ExecuteMethod(GetScripts);
            ExecuteMethod(GetImages);
            ExecuteMethod(GetApps);
        }
        
        private void cbApp_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedAppProxy = (AppProxy)cbApp.SelectedItem;
            var app = selectedAppProxy.Entity;
            var appId = app.Id.ToString("D");
            var webresourceId = (Guid)app["webresourceid"];

            foreach (WebresourceProxy wrp in cbIcon.Items)
            {
                if (wrp.Entity.Id != webresourceId) { continue; }

                cbIcon.SelectedItem = wrp;
            }


            AppId = appId;
            AppUniqueName = (string)app["uniquename"];

            GetAppSettings(appId);
            GetSecurityRoles();

            tbName.Text = (string)app["name"];
            tbDescription.Text = app.Contains("description") ? (string)app["description"] : "";

            var navigationType = (OptionSetValue)app["navigationtype"];

            cbNavigationType.SelectedIndex = navigationType.Value;

            if (selectedAppProxy.EventHandlers == null)
            {
                dgvEvents.DataSource = null;
            }
            else
            {
                var bindingList = new BindingList<AppEventHandler>(selectedAppProxy.EventHandlers);
                var source = new BindingSource(bindingList, null);
                dgvEvents.DataSource = source;
                //dgvEvents.DataSource = selectedAppProxy.EventHandlers;
            }

        }

        private void tsbUpdate_Click(object sender, EventArgs e)
        {
            var app = ((AppProxy)cbApp.SelectedItem).Entity;
            var eventHandlers = (BindingList<AppEventHandler>)((BindingSource)dgvEvents.DataSource).DataSource;
            var eventsJson = JsonConvert.SerializeObject(eventHandlers);

            var updatedApp = new Entity(app.LogicalName, app.Id);
            updatedApp["name"] = tbName.Text.Trim();
            updatedApp["description"] = tbDescription.Text.Trim();
            updatedApp["navigationtype"] = new OptionSetValue(cbNavigationType.SelectedIndex);
            updatedApp["webresourceid"] = ((WebresourceProxy)cbIcon.SelectedItem).Entity.Id;
            updatedApp["eventhandlers"] = eventsJson;

            var updateAppRequest = new UpdateRequest { Target = updatedApp };
            var appSettingsRequests = GenerateAppSettingsRequests();
            var appRolesRequests = GenerateAppRolesRequests();
            var publishRequest = new PublishAllXmlRequest();

            var organizationRequestCollection = new OrganizationRequestCollection { updateAppRequest };
            organizationRequestCollection.AddRange(appSettingsRequests);
            organizationRequestCollection.AddRange(appRolesRequests);
            organizationRequestCollection.Add(publishRequest);

            var dialogResult = MessageBox.Show("Are you sure you want to publish your app changes?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.No) { return; }

            WorkAsync(new WorkAsyncInfo
            {
                Message = "Updating app",
                Work = (worker, args) =>
                {
                    var executeMultipleRequest = new ExecuteMultipleRequest
                    {
                        Settings = new ExecuteMultipleSettings
                        {
                            ContinueOnError = false,
                            ReturnResponses = true
                        },
                        Requests = organizationRequestCollection
                    };

                    Service.Execute(executeMultipleRequest);
                },
                PostWorkCallBack = (args) =>
                {
                    if (args.Error != null)
                    {
                        MessageBox.Show(args.Error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        GetApps();
                    }
                }
            });
        }

        private void btnEditEvent_Click(object sender, EventArgs e)
        {
            var eventHandler = (AppEventHandler)dgvEvents.CurrentRow?.DataBoundItem;

            if (eventHandler == null) { return; }

            var eventForm = new EventForm(this, eventHandler);
            eventForm.ShowDialog();
        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            var eventForm = new EventForm(this, null);
            eventForm.ShowDialog();
        }

        private void btnDeleteEvent_Click(object sender, EventArgs e)
        {
            var eventHandler = (AppEventHandler)dgvEvents.CurrentRow?.DataBoundItem;

            if (eventHandler == null) { return; }

            var list = (BindingList<AppEventHandler>)((BindingSource)dgvEvents.DataSource)?.DataSource;
            list?.Remove(eventHandler);
            dgvEvents.DataSource = null;

            var source = new BindingSource(list, null);
            dgvEvents.DataSource = source;
        }

        private void cbxFilterNumberSettings_CheckedChanged(object sender, EventArgs e)
        {
            FilterSettings();
        }

        private void cbxFilterStringSettings_CheckedChanged(object sender, EventArgs e)
        {
            FilterSettings();
        }

        private void cbxFilterBooleanSettings_CheckedChanged(object sender, EventArgs e)
        {
            FilterSettings();
        }

        private void btnEditSettings_Click(object sender, EventArgs e)
        {
            var appSettings = (AppSettings)dgvAppSettings.CurrentRow?.DataBoundItem;

            if (appSettings == null) { return; }

            var appSettingsForm = new AppSettingsForm(this, appSettings);
            appSettingsForm.ShowDialog();
        }

        private void dgvAppSettings_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var appSettings = (AppSettings)dgvAppSettings.CurrentRow?.DataBoundItem;

            if (appSettings == null) { return; }

            var appSettingsForm = new AppSettingsForm(this, appSettings);
            appSettingsForm.ShowDialog();
        }

        private void dgvEvents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var eventHandler = (AppEventHandler)dgvEvents.CurrentRow?.DataBoundItem;

            if (eventHandler == null) { return; }

            var eventForm = new EventForm(this, eventHandler);
            eventForm.ShowDialog();
        }

        private void btnClearSettings_Click(object sender, EventArgs e)
        {
            var appSettings = (AppSettings)dgvAppSettings.CurrentRow?.DataBoundItem;

            if (appSettings == null) { return; }

            appSettings.Value = null;
            dgvAppSettings.Refresh();
        }

        private void cbIcon_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedIcon = (WebresourceProxy)cbIcon.SelectedItem;

            var base64 = (string)selectedIcon.Entity["content"];
            var webResourceType = (OptionSetValue)selectedIcon.Entity["webresourcetype"];

            var mimeType = "";
            switch (webResourceType.Value)
            {
                case 11:
                    mimeType = "image/svg+xml"; // svg
                    break;
                case 5:
                    mimeType = "image/png"; // png
                    break;

            }

            var html = $@"
            <html>
                <head>
                    <style>
                    .container{{
                        height: 97px;
                        width: 100%;
                        background-color: #002050;
                        display: -ms-flexbox;
                        display: flex;
                        -ms-flex-direction: row;
                        flex-direction: row;
                        -ms-flex-align: center;
                        align-items: center;
                        -ms-flex-pack: center;
                        justify-content: center;
                    }}
                    
                    img{{
                        max-height: 100%;
                        max-width: 100%;
                        height: 70px;
                        width: 70px;
                        -ms-flex: 0 0 auto;
                        flex: 0 0 auto;
                        object-fit: scale-down;
                    }}
                    </style>
                    <title>Basic Web Page</title>
                </head>
                <div class='container'>
                    <img src='data:{mimeType};base64,{base64}' />
                </div>
            </html>";

            wvIcon.NavigateToString(html);
        }

        private void btnChangeIcon_Click(object sender, EventArgs e)
        {
            _imageGalleryForm = _imageGalleryForm ?? new IconGalleryForm(this, Images);
            _imageGalleryForm.ShowDialog();
        }

        #endregion

        #region Methods

        private void GetImages()
        {
            WorkAsync(
                new WorkAsyncInfo("Loading images...",
                    (eventargs) =>
                    {

                        var query = new QueryExpression("webresource");
                        query.ColumnSet.AddColumns("name", "displayname", "content", "webresourcetype");
                        var fe = new FilterExpression();
                        query.Criteria.AddFilter(fe);
                        fe.FilterOperator = LogicalOperator.Or;
                        fe.AddCondition("webresourcetype", ConditionOperator.Equal, 5);
                        fe.AddCondition("webresourcetype", ConditionOperator.Equal, 11);

                        var imagesList = RetrieveAllRecords(Service, query);

                        this.Images = imagesList;
                        eventargs.Result = imagesList;
                    })
                {
                    PostWorkCallBack = (completedargs) =>
                    {
                        if (completedargs.Error != null)
                        {
                            MessageBox.Show(completedargs.Error.Message);
                        }
                        else
                        {
                            if (!(completedargs.Result is List<Entity> result)) { return; }

                            var images = result.Select(f => new WebresourceProxy(f)).OrderBy(f => f.ToString()).ToArray();

                            cbIcon.Items.Clear();
                            cbIcon.Items.AddRange(images);
                        }
                    }
                });
        }

        private void GetSecurityRoles()
        {
            WorkAsync(new WorkAsyncInfo
            {
                Message = "Getting security roles",
                Work = (worker, args) =>
                {
                    var qe = new QueryExpression("role");
                    qe.ColumnSet.AddColumns("roleid", "name");
                    qe.AddOrder("name", OrderType.Ascending);
                    qe.Criteria.AddCondition("parentroleid", ConditionOperator.Null);
                    var bu = qe.AddLink("businessunit", "businessunitid", "businessunitid");
                    bu.EntityAlias = "bu";
                    bu.Columns.AddColumns("name");
                    var amr = qe.AddLink("appmoduleroles", "roleid", "roleid", JoinOperator.LeftOuter);
                    amr.EntityAlias = "amr";
                    amr.Columns.AddColumns("appmoduleid");
                    amr.LinkCriteria.AddCondition("appmoduleid", ConditionOperator.Equal, AppId);

                    args.Result = RetrieveAllRecords(Service, qe);
                },
                PostWorkCallBack = (args) =>
                {
                    if (args.Error != null)
                    {
                        MessageBox.Show(args.Error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (!(args.Result is List<Entity> result)) { return; }

                        SecurityRoles = result.Select(s => new SecurityRole
                        {
                            Name = (string)s["name"],
                            Id = s.Id.ToString("D"),
                            Enabled = s.Contains("amr.appmoduleid"),
                            EnabledInitial = s.Contains("amr.appmoduleid")
                        }).ToList();

                        dgvSecurityRoles.DataSource = SecurityRoles;
                    }
                }
            });
        }

        private void GetScripts()
        {
            WorkAsync(new WorkAsyncInfo
            {
                Message = "Getting scripts",
                Work = (worker, args) =>
                {
                    var qe = new QueryExpression("webresource");
                    qe.ColumnSet.AddColumns("name");
                    qe.AddOrder("name", OrderType.Ascending);
                    qe.Criteria.AddCondition("webresourcetype", ConditionOperator.Equal, 3);

                    args.Result = RetrieveAllRecords(Service, qe);
                },
                PostWorkCallBack = (args) =>
                {
                    if (args.Error != null)
                    {
                        MessageBox.Show(args.Error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (!(args.Result is List<Entity> result)) { return; }

                        ScriptLibraries = result.Select(s => (string)s["name"]).ToList();
                    }
                }
            });
        }

        private void GetApps()
        {
            WorkAsync(new WorkAsyncInfo
            {
                Message = "Getting apps",
                Work = (worker, args) =>
                {
                    var qe = new QueryExpression("appmodule")
                    {
                        ColumnSet = new ColumnSet(true),
                        Orders = { new OrderExpression("name", OrderType.Ascending) }
                    };

                    args.Result = Service.RetrieveMultiple(qe);
                },
                PostWorkCallBack = (args) =>
                {
                    if (args.Error != null)
                    {
                        MessageBox.Show(args.Error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (!(args.Result is EntityCollection result)) { return; }

                        var apps = result.Entities.Select(a => new AppProxy(a)).OrderBy(a => a.ToString()).ToList();

                        cbApp.Items.Clear();
                        cbApp.Items.AddRange(apps.ToArray());

                        cbApp.SelectedIndex = string.IsNullOrWhiteSpace(AppId)
                            ? 0
                            : apps.FindIndex(a => a.Entity.Id.ToString("D") == AppId);
                    }
                }
            });
        }

        private void GetAppSettings(string appId)
        {
            var fetch = $@"
            <fetch>
              <entity name='settingdefinition'>
                <attribute name='displayname' />
                <attribute name='datatype' />
                <attribute name='defaultvalue' />
                <attribute name='settingdefinitionid' />
                <attribute name='uniquename' />
                <link-entity name='appsetting' from='settingdefinitionid' to='settingdefinitionid' link-type='outer' alias='as'>
                  <attribute name='value' />
                  <attribute name='appsettingid' />
                  <filter>
                    <condition attribute='parentappmoduleid' operator='eq' value='{appId}' />
                  </filter>
                </link-entity>
              </entity>
            </fetch>";

            WorkAsync(new WorkAsyncInfo
            {
                Message = "Getting app settings",
                Work = (worker, args) =>
                {
                    args.Result = Service.RetrieveMultiple(new FetchExpression(fetch));
                },
                PostWorkCallBack = (args) =>
                {
                    if (args.Error != null)
                    {
                        MessageBox.Show(args.Error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (!(args.Result is EntityCollection result)) { return; }

                        AppSettings = result.Entities.Select(s => new AppSettings(s)).OrderBy(s => s.DisplayName).ToList();

                        //var bindingList = new BindingList<AppSettings>(settings);
                        //var source = new BindingSource(bindingList, null);

                        FilterSettings();
                    }
                }
            });
        }

        public List<OrganizationRequest> GenerateAppRolesRequests()
        {
            var requests = new List<OrganizationRequest>();

            var listForAssociate = new List<string>();
            var listForDisAssociate = new List<string>();

            foreach (var securityRole in SecurityRoles)
            {
                if (securityRole.Enabled == securityRole.EnabledInitial) { continue; }

                if (securityRole.Enabled)
                {
                    listForAssociate.Add(securityRole.Id);
                }
                else
                {
                    listForDisAssociate.Add(securityRole.Id);
                }
            }

            if (listForAssociate.Count != 0)
            {
                var associateRequest = new AssociateRequest
                {
                    Target = new EntityReference("appmodule", new Guid(AppId)),
                    Relationship = new Relationship("appmoduleroles_association"),
                    RelatedEntities = new EntityReferenceCollection(
                        listForAssociate.Select(r => new EntityReference("role", new Guid(r))).ToList()
                    )
                };

                requests.Add(associateRequest);
            }


            if (listForDisAssociate.Count != 0)
            {
                var disassociateReqest = new DisassociateRequest
                {
                    Target = new EntityReference("appmodule", new Guid(AppId)),
                    Relationship = new Relationship("appmoduleroles_association"),
                    RelatedEntities = new EntityReferenceCollection(
                        listForDisAssociate.Select(r => new EntityReference("role", new Guid(r))).ToList()
                    )
                };

                requests.Add(disassociateReqest);
            }

            return requests;
        }

        public List<OrganizationRequest> GenerateAppSettingsRequests()
        {
            var settingsList = (List<AppSettings>)dgvAppSettings.DataSource;

            var requestList = new List<OrganizationRequest>();

            var listForCreate = settingsList
                .Where(s => !string.IsNullOrWhiteSpace(s.Value) && string.IsNullOrWhiteSpace(s.AppSettingsId));
            var listForUpdate = settingsList
                .Where(s => !string.IsNullOrWhiteSpace(s.Value) && !string.IsNullOrWhiteSpace(s.AppSettingsId));
            var listForDelete = settingsList
                .Where(s => string.IsNullOrWhiteSpace(s.Value) && !string.IsNullOrWhiteSpace(s.AppSettingsId));

            foreach (var cas in listForCreate)
            {
                var createdSettings = new Entity("appsetting");
                createdSettings["parentappmoduleid"] = new EntityReference("appmodule", new Guid(AppId));
                createdSettings["settingdefinitionid"] = new EntityReference("settingdefinition", new Guid(cas.SettingDefinitionId));
                createdSettings["uniquename"] = $@"new_{AppUniqueName}_{cas.SettingUniqueName}";
                createdSettings["value"] = cas.Value;

                var createRequest = new CreateRequest { Target = createdSettings };
                requestList.Add(createRequest);
            }

            foreach (var uas in listForUpdate)
            {
                var updatedSettings = new Entity("appsetting", new Guid(uas.AppSettingsId));
                updatedSettings["value"] = uas.Value;

                var updateRequest = new UpdateRequest { Target = updatedSettings };
                requestList.Add(updateRequest);
            }

            foreach (var das in listForDelete)
            {
                var deletedSettings = new EntityReference("appsetting", new Guid(das.AppSettingsId));

                var deleteRequest = new DeleteRequest { Target = deletedSettings };
                requestList.Add(deleteRequest);
            }

            return requestList;
        }

        public static List<Entity> RetrieveAllRecords(IOrganizationService service, QueryExpression query)
        {
            var pageNumber = 1;
            var pagingCookie = string.Empty;
            var result = new List<Entity>();
            EntityCollection resp;
            do
            {
                if (pageNumber != 1)
                {
                    query.PageInfo.PageNumber = pageNumber;
                    query.PageInfo.PagingCookie = pagingCookie;
                }
                resp = service.RetrieveMultiple(query);
                if (resp.MoreRecords)
                {
                    pageNumber++;
                    pagingCookie = resp.PagingCookie;
                }

                result.AddRange(resp.Entities);
            }
            while (resp.MoreRecords);

            return result;
        }

        private void FilterSettings()
        {
            var includeBool = cbxFilterBooleanSettings.Checked;
            var includeNumber = cbxFilterNumberSettings.Checked;
            var includeString = cbxFilterStringSettings.Checked;

            var filters = new List<string>();

            if (includeBool) { filters.Add("Boolean"); }
            if (includeNumber) { filters.Add("Number"); }
            if (includeString) { filters.Add("String"); }

            var filteredList = AppSettings
                .Where(s => filters.Contains(s.DataType))
                .ToList();

            dgvAppSettings.DataSource = filteredList;
        }

        public void SetIconById(string id)
        {
            foreach (WebresourceProxy icon in cbIcon.Items)
            {
                if (icon.Entity.Id.ToString("D") != id) { continue; }

                cbIcon.SelectedItem = icon;
            }
        }

        #endregion
    }
}