
namespace Fic.XTB.AdvancedAppManager
{
    partial class AdvancedAppManager
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdvancedAppManager));
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.tssSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbUpdate = new System.Windows.Forms.ToolStripButton();
            this.lblApp = new System.Windows.Forms.Label();
            this.cbApp = new System.Windows.Forms.ComboBox();
            this.tabAppSettings = new System.Windows.Forms.TabPage();
            this.dgvAppSettings = new System.Windows.Forms.DataGridView();
            this.DisplayName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AppSettingsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SettingDefinitionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SettingUniqueName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DefaultValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxFilterNumberSettings = new System.Windows.Forms.CheckBox();
            this.cbxFilterStringSettings = new System.Windows.Forms.CheckBox();
            this.cbxFilterBooleanSettings = new System.Windows.Forms.CheckBox();
            this.btnClearSettings = new System.Windows.Forms.Button();
            this.btnEditSettings = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvEvents = new System.Windows.Forms.DataGridView();
            this.EventName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FunctionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LibraryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Parameters = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Enabled = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnDeleteEvent = new System.Windows.Forms.Button();
            this.btnAddEvent = new System.Windows.Forms.Button();
            this.btnEditEvent = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvSecurityRoles = new System.Windows.Forms.DataGridView();
            this.RoleEnabled = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.RoleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnabledInitial = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnChangeIcon = new System.Windows.Forms.Button();
            this.wvIcon = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.cbIcon = new System.Windows.Forms.ComboBox();
            this.lblIcon = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.cbNavigationType = new System.Windows.Forms.ComboBox();
            this.lblNavigation = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.toolStripMenu.SuspendLayout();
            this.tabAppSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppSettings)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSecurityRoles)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wvIcon)).BeginInit();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbClose,
            this.tssSeparator1,
            this.tsbUpdate});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(1203, 34);
            this.toolStripMenu.TabIndex = 4;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // tsbClose
            // 
            this.tsbClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbClose.Image = ((System.Drawing.Image)(resources.GetObject("tsbClose.Image")));
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(34, 29);
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // tssSeparator1
            // 
            this.tssSeparator1.Name = "tssSeparator1";
            this.tssSeparator1.Size = new System.Drawing.Size(6, 34);
            // 
            // tsbUpdate
            // 
            this.tsbUpdate.Enabled = false;
            this.tsbUpdate.Image = ((System.Drawing.Image)(resources.GetObject("tsbUpdate.Image")));
            this.tsbUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUpdate.Name = "tsbUpdate";
            this.tsbUpdate.Size = new System.Drawing.Size(179, 29);
            this.tsbUpdate.Text = "Update && Publish";
            this.tsbUpdate.Click += new System.EventHandler(this.tsbUpdate_Click);
            // 
            // lblApp
            // 
            this.lblApp.AutoSize = true;
            this.lblApp.Location = new System.Drawing.Point(3, 51);
            this.lblApp.Name = "lblApp";
            this.lblApp.Size = new System.Drawing.Size(38, 20);
            this.lblApp.TabIndex = 5;
            this.lblApp.Text = "App";
            // 
            // cbApp
            // 
            this.cbApp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbApp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbApp.Enabled = false;
            this.cbApp.FormattingEnabled = true;
            this.cbApp.Location = new System.Drawing.Point(47, 48);
            this.cbApp.Name = "cbApp";
            this.cbApp.Size = new System.Drawing.Size(1153, 28);
            this.cbApp.TabIndex = 7;
            this.cbApp.SelectedIndexChanged += new System.EventHandler(this.cbApp_SelectedIndexChanged);
            // 
            // tabAppSettings
            // 
            this.tabAppSettings.Controls.Add(this.dgvAppSettings);
            this.tabAppSettings.Controls.Add(this.cbxFilterNumberSettings);
            this.tabAppSettings.Controls.Add(this.cbxFilterStringSettings);
            this.tabAppSettings.Controls.Add(this.cbxFilterBooleanSettings);
            this.tabAppSettings.Controls.Add(this.btnClearSettings);
            this.tabAppSettings.Controls.Add(this.btnEditSettings);
            this.tabAppSettings.Location = new System.Drawing.Point(4, 29);
            this.tabAppSettings.Name = "tabAppSettings";
            this.tabAppSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabAppSettings.Size = new System.Drawing.Size(1189, 622);
            this.tabAppSettings.TabIndex = 2;
            this.tabAppSettings.Text = "App Settings";
            this.tabAppSettings.UseVisualStyleBackColor = true;
            // 
            // dgvAppSettings
            // 
            this.dgvAppSettings.AllowUserToAddRows = false;
            this.dgvAppSettings.AllowUserToDeleteRows = false;
            this.dgvAppSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAppSettings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAppSettings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppSettings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DisplayName,
            this.DataType,
            this.Value,
            this.AppSettingsId,
            this.SettingDefinitionId,
            this.SettingUniqueName,
            this.DefaultValue});
            this.dgvAppSettings.Location = new System.Drawing.Point(6, 54);
            this.dgvAppSettings.Name = "dgvAppSettings";
            this.dgvAppSettings.RowHeadersWidth = 62;
            this.dgvAppSettings.RowTemplate.Height = 28;
            this.dgvAppSettings.Size = new System.Drawing.Size(1177, 562);
            this.dgvAppSettings.TabIndex = 7;
            this.dgvAppSettings.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAppSettings_CellDoubleClick);
            // 
            // DisplayName
            // 
            this.DisplayName.DataPropertyName = "DisplayName";
            this.DisplayName.HeaderText = "Display Name";
            this.DisplayName.MinimumWidth = 8;
            this.DisplayName.Name = "DisplayName";
            this.DisplayName.ReadOnly = true;
            // 
            // DataType
            // 
            this.DataType.DataPropertyName = "DataType";
            this.DataType.HeaderText = "Data Type";
            this.DataType.MinimumWidth = 8;
            this.DataType.Name = "DataType";
            this.DataType.ReadOnly = true;
            // 
            // Value
            // 
            this.Value.DataPropertyName = "Value";
            this.Value.HeaderText = "Value";
            this.Value.MinimumWidth = 8;
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            // 
            // AppSettingsId
            // 
            this.AppSettingsId.DataPropertyName = "AppSettingsId";
            this.AppSettingsId.HeaderText = "AppSettingsId";
            this.AppSettingsId.MinimumWidth = 8;
            this.AppSettingsId.Name = "AppSettingsId";
            this.AppSettingsId.ReadOnly = true;
            this.AppSettingsId.Visible = false;
            // 
            // SettingDefinitionId
            // 
            this.SettingDefinitionId.DataPropertyName = "SettingDefinitionId";
            this.SettingDefinitionId.HeaderText = "SettingDefinitionId";
            this.SettingDefinitionId.MinimumWidth = 8;
            this.SettingDefinitionId.Name = "SettingDefinitionId";
            this.SettingDefinitionId.ReadOnly = true;
            this.SettingDefinitionId.Visible = false;
            // 
            // SettingUniqueName
            // 
            this.SettingUniqueName.DataPropertyName = "SettingUniqueName";
            this.SettingUniqueName.HeaderText = "SettingUniqueName";
            this.SettingUniqueName.MinimumWidth = 8;
            this.SettingUniqueName.Name = "SettingUniqueName";
            this.SettingUniqueName.ReadOnly = true;
            this.SettingUniqueName.Visible = false;
            // 
            // DefaultValue
            // 
            this.DefaultValue.DataPropertyName = "DefaultValue";
            this.DefaultValue.HeaderText = "Default Value";
            this.DefaultValue.MinimumWidth = 8;
            this.DefaultValue.Name = "DefaultValue";
            this.DefaultValue.ReadOnly = true;
            // 
            // cbxFilterNumberSettings
            // 
            this.cbxFilterNumberSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxFilterNumberSettings.AutoSize = true;
            this.cbxFilterNumberSettings.Checked = true;
            this.cbxFilterNumberSettings.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxFilterNumberSettings.Location = new System.Drawing.Point(909, 16);
            this.cbxFilterNumberSettings.Name = "cbxFilterNumberSettings";
            this.cbxFilterNumberSettings.Size = new System.Drawing.Size(91, 24);
            this.cbxFilterNumberSettings.TabIndex = 6;
            this.cbxFilterNumberSettings.Text = "Number";
            this.cbxFilterNumberSettings.UseVisualStyleBackColor = true;
            this.cbxFilterNumberSettings.CheckedChanged += new System.EventHandler(this.cbxFilterNumberSettings_CheckedChanged);
            // 
            // cbxFilterStringSettings
            // 
            this.cbxFilterStringSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxFilterStringSettings.AutoSize = true;
            this.cbxFilterStringSettings.Checked = true;
            this.cbxFilterStringSettings.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxFilterStringSettings.Location = new System.Drawing.Point(1006, 16);
            this.cbxFilterStringSettings.Name = "cbxFilterStringSettings";
            this.cbxFilterStringSettings.Size = new System.Drawing.Size(77, 24);
            this.cbxFilterStringSettings.TabIndex = 5;
            this.cbxFilterStringSettings.Text = "String";
            this.cbxFilterStringSettings.UseVisualStyleBackColor = true;
            this.cbxFilterStringSettings.CheckedChanged += new System.EventHandler(this.cbxFilterStringSettings_CheckedChanged);
            // 
            // cbxFilterBooleanSettings
            // 
            this.cbxFilterBooleanSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxFilterBooleanSettings.AutoSize = true;
            this.cbxFilterBooleanSettings.Checked = true;
            this.cbxFilterBooleanSettings.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxFilterBooleanSettings.Location = new System.Drawing.Point(1089, 16);
            this.cbxFilterBooleanSettings.Name = "cbxFilterBooleanSettings";
            this.cbxFilterBooleanSettings.Size = new System.Drawing.Size(94, 24);
            this.cbxFilterBooleanSettings.TabIndex = 4;
            this.cbxFilterBooleanSettings.Text = "Boolean";
            this.cbxFilterBooleanSettings.UseVisualStyleBackColor = true;
            this.cbxFilterBooleanSettings.CheckedChanged += new System.EventHandler(this.cbxFilterBooleanSettings_CheckedChanged);
            // 
            // btnClearSettings
            // 
            this.btnClearSettings.Location = new System.Drawing.Point(115, 6);
            this.btnClearSettings.Name = "btnClearSettings";
            this.btnClearSettings.Size = new System.Drawing.Size(103, 42);
            this.btnClearSettings.TabIndex = 3;
            this.btnClearSettings.Text = "Clear";
            this.btnClearSettings.UseVisualStyleBackColor = true;
            this.btnClearSettings.Click += new System.EventHandler(this.btnClearSettings_Click);
            // 
            // btnEditSettings
            // 
            this.btnEditSettings.Location = new System.Drawing.Point(6, 6);
            this.btnEditSettings.Name = "btnEditSettings";
            this.btnEditSettings.Size = new System.Drawing.Size(103, 42);
            this.btnEditSettings.TabIndex = 2;
            this.btnEditSettings.Text = "Edit";
            this.btnEditSettings.UseVisualStyleBackColor = true;
            this.btnEditSettings.Click += new System.EventHandler(this.btnEditSettings_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvEvents);
            this.tabPage2.Controls.Add(this.btnDeleteEvent);
            this.tabPage2.Controls.Add(this.btnAddEvent);
            this.tabPage2.Controls.Add(this.btnEditEvent);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1189, 622);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Events";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvEvents
            // 
            this.dgvEvents.AllowUserToAddRows = false;
            this.dgvEvents.AllowUserToDeleteRows = false;
            this.dgvEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEvents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EventName,
            this.FunctionName,
            this.LibraryName,
            this.Parameters,
            this.Enabled});
            this.dgvEvents.Location = new System.Drawing.Point(6, 54);
            this.dgvEvents.Name = "dgvEvents";
            this.dgvEvents.RowHeadersWidth = 62;
            this.dgvEvents.RowTemplate.Height = 28;
            this.dgvEvents.Size = new System.Drawing.Size(1177, 562);
            this.dgvEvents.TabIndex = 4;
            this.dgvEvents.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEvents_CellDoubleClick);
            // 
            // EventName
            // 
            this.EventName.DataPropertyName = "EventName";
            this.EventName.HeaderText = "Event Name";
            this.EventName.MinimumWidth = 8;
            this.EventName.Name = "EventName";
            this.EventName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // FunctionName
            // 
            this.FunctionName.DataPropertyName = "FunctionName";
            this.FunctionName.HeaderText = "Function Name";
            this.FunctionName.MinimumWidth = 8;
            this.FunctionName.Name = "FunctionName";
            // 
            // LibraryName
            // 
            this.LibraryName.DataPropertyName = "LibraryName";
            this.LibraryName.HeaderText = "Library Name";
            this.LibraryName.MinimumWidth = 8;
            this.LibraryName.Name = "LibraryName";
            this.LibraryName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Parameters
            // 
            this.Parameters.DataPropertyName = "Parameters";
            this.Parameters.HeaderText = "Parameters";
            this.Parameters.MinimumWidth = 8;
            this.Parameters.Name = "Parameters";
            // 
            // Enabled
            // 
            this.Enabled.DataPropertyName = "Enabled";
            this.Enabled.HeaderText = "Enabled";
            this.Enabled.MinimumWidth = 8;
            this.Enabled.Name = "Enabled";
            // 
            // btnDeleteEvent
            // 
            this.btnDeleteEvent.Location = new System.Drawing.Point(224, 6);
            this.btnDeleteEvent.Name = "btnDeleteEvent";
            this.btnDeleteEvent.Size = new System.Drawing.Size(103, 42);
            this.btnDeleteEvent.TabIndex = 3;
            this.btnDeleteEvent.Text = "Delete";
            this.btnDeleteEvent.UseVisualStyleBackColor = true;
            this.btnDeleteEvent.Click += new System.EventHandler(this.btnDeleteEvent_Click);
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.Location = new System.Drawing.Point(6, 6);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(103, 42);
            this.btnAddEvent.TabIndex = 2;
            this.btnAddEvent.Text = "Add";
            this.btnAddEvent.UseVisualStyleBackColor = true;
            this.btnAddEvent.Click += new System.EventHandler(this.btnAddEvent_Click);
            // 
            // btnEditEvent
            // 
            this.btnEditEvent.Location = new System.Drawing.Point(115, 6);
            this.btnEditEvent.Name = "btnEditEvent";
            this.btnEditEvent.Size = new System.Drawing.Size(103, 42);
            this.btnEditEvent.TabIndex = 1;
            this.btnEditEvent.Text = "Edit";
            this.btnEditEvent.UseVisualStyleBackColor = true;
            this.btnEditEvent.Click += new System.EventHandler(this.btnEditEvent_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1189, 622);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvSecurityRoles);
            this.groupBox2.Location = new System.Drawing.Point(564, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(619, 610);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Roles";
            // 
            // dgvSecurityRoles
            // 
            this.dgvSecurityRoles.AllowUserToAddRows = false;
            this.dgvSecurityRoles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSecurityRoles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSecurityRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSecurityRoles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoleEnabled,
            this.RoleId,
            this.RoleName,
            this.EnabledInitial});
            this.dgvSecurityRoles.Location = new System.Drawing.Point(6, 25);
            this.dgvSecurityRoles.Name = "dgvSecurityRoles";
            this.dgvSecurityRoles.RowHeadersWidth = 62;
            this.dgvSecurityRoles.RowTemplate.Height = 28;
            this.dgvSecurityRoles.Size = new System.Drawing.Size(607, 579);
            this.dgvSecurityRoles.TabIndex = 1;
            // 
            // RoleEnabled
            // 
            this.RoleEnabled.DataPropertyName = "Enabled";
            this.RoleEnabled.HeaderText = "Enabled";
            this.RoleEnabled.MinimumWidth = 8;
            this.RoleEnabled.Name = "RoleEnabled";
            // 
            // RoleId
            // 
            this.RoleId.DataPropertyName = "Id";
            this.RoleId.HeaderText = "Id";
            this.RoleId.MinimumWidth = 8;
            this.RoleId.Name = "RoleId";
            this.RoleId.Visible = false;
            // 
            // RoleName
            // 
            this.RoleName.DataPropertyName = "Name";
            this.RoleName.HeaderText = "Name";
            this.RoleName.MinimumWidth = 8;
            this.RoleName.Name = "RoleName";
            this.RoleName.ReadOnly = true;
            // 
            // EnabledInitial
            // 
            this.EnabledInitial.DataPropertyName = "EnabledInitial";
            this.EnabledInitial.HeaderText = "EnabledInitial";
            this.EnabledInitial.MinimumWidth = 8;
            this.EnabledInitial.Name = "EnabledInitial";
            this.EnabledInitial.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.btnChangeIcon);
            this.groupBox1.Controls.Add(this.wvIcon);
            this.groupBox1.Controls.Add(this.cbIcon);
            this.groupBox1.Controls.Add(this.lblIcon);
            this.groupBox1.Controls.Add(this.tbDescription);
            this.groupBox1.Controls.Add(this.lblDescription);
            this.groupBox1.Controls.Add(this.cbNavigationType);
            this.groupBox1.Controls.Add(this.lblNavigation);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 610);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Basic Info";
            // 
            // btnChangeIcon
            // 
            this.btnChangeIcon.Location = new System.Drawing.Point(432, 263);
            this.btnChangeIcon.Name = "btnChangeIcon";
            this.btnChangeIcon.Size = new System.Drawing.Size(103, 35);
            this.btnChangeIcon.TabIndex = 21;
            this.btnChangeIcon.Text = "...";
            this.btnChangeIcon.UseVisualStyleBackColor = true;
            this.btnChangeIcon.Click += new System.EventHandler(this.btnChangeIcon_Click);
            // 
            // wvIcon
            // 
            this.wvIcon.CreationProperties = null;
            this.wvIcon.DefaultBackgroundColor = System.Drawing.Color.White;
            this.wvIcon.Location = new System.Drawing.Point(10, 324);
            this.wvIcon.Name = "wvIcon";
            this.wvIcon.Size = new System.Drawing.Size(525, 239);
            this.wvIcon.TabIndex = 20;
            this.wvIcon.ZoomFactor = 1D;
            // 
            // cbIcon
            // 
            this.cbIcon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIcon.FormattingEnabled = true;
            this.cbIcon.Location = new System.Drawing.Point(133, 264);
            this.cbIcon.Name = "cbIcon";
            this.cbIcon.Size = new System.Drawing.Size(293, 28);
            this.cbIcon.TabIndex = 19;
            this.cbIcon.SelectedIndexChanged += new System.EventHandler(this.cbIcon_SelectedIndexChanged);
            // 
            // lblIcon
            // 
            this.lblIcon.AutoSize = true;
            this.lblIcon.Location = new System.Drawing.Point(6, 267);
            this.lblIcon.Name = "lblIcon";
            this.lblIcon.Size = new System.Drawing.Size(40, 20);
            this.lblIcon.TabIndex = 18;
            this.lblIcon.Text = "Icon";
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(133, 90);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(402, 89);
            this.tbDescription.TabIndex = 17;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(6, 90);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(89, 20);
            this.lblDescription.TabIndex = 16;
            this.lblDescription.Text = "Description";
            // 
            // cbNavigationType
            // 
            this.cbNavigationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNavigationType.FormattingEnabled = true;
            this.cbNavigationType.Items.AddRange(new object[] {
            "Single Session",
            "Multiple Session"});
            this.cbNavigationType.Location = new System.Drawing.Point(133, 201);
            this.cbNavigationType.Name = "cbNavigationType";
            this.cbNavigationType.Size = new System.Drawing.Size(402, 28);
            this.cbNavigationType.TabIndex = 15;
            // 
            // lblNavigation
            // 
            this.lblNavigation.AutoSize = true;
            this.lblNavigation.Location = new System.Drawing.Point(6, 204);
            this.lblNavigation.Name = "lblNavigation";
            this.lblNavigation.Size = new System.Drawing.Size(121, 20);
            this.lblNavigation.TabIndex = 14;
            this.lblNavigation.Text = "Navigation Type";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(133, 35);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(402, 26);
            this.tbName.TabIndex = 13;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 41);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Name";
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabAppSettings);
            this.tabControl.Enabled = false;
            this.tabControl.Location = new System.Drawing.Point(3, 97);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1197, 655);
            this.tabControl.TabIndex = 6;
            // 
            // AdvancedAppManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbApp);
            this.Controls.Add(this.lblApp);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.toolStripMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AdvancedAppManager";
            this.Size = new System.Drawing.Size(1203, 755);
            this.OnCloseTool += new System.EventHandler(this.AdvancedAppManager_OnCloseTool);
            this.Load += new System.EventHandler(this.AdvancedAppManager_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.tabAppSettings.ResumeLayout(false);
            this.tabAppSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppSettings)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSecurityRoles)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wvIcon)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.ToolStripSeparator tssSeparator1;
        private System.Windows.Forms.Label lblApp;
        private System.Windows.Forms.ComboBox cbApp;
        private System.Windows.Forms.ToolStripButton tsbUpdate;
        private System.Windows.Forms.TabPage tabAppSettings;
        private System.Windows.Forms.CheckBox cbxFilterNumberSettings;
        private System.Windows.Forms.CheckBox cbxFilterStringSettings;
        private System.Windows.Forms.CheckBox cbxFilterBooleanSettings;
        private System.Windows.Forms.Button btnClearSettings;
        private System.Windows.Forms.Button btnEditSettings;
        private System.Windows.Forms.DataGridViewTextBoxColumn SettingUniqueName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SettingDefinitionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppSettingsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn DefaultValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataType;
        private System.Windows.Forms.DataGridViewTextBoxColumn DisplayName;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnDeleteEvent;
        private System.Windows.Forms.Button btnAddEvent;
        private System.Windows.Forms.Button btnEditEvent;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvSecurityRoles;
        private System.Windows.Forms.DataGridViewCheckBoxColumn RoleEnabled;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleId;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn EnabledInitial;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnChangeIcon;
        private Microsoft.Web.WebView2.WinForms.WebView2 wvIcon;
        private System.Windows.Forms.ComboBox cbIcon;
        private System.Windows.Forms.Label lblIcon;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.ComboBox cbNavigationType;
        private System.Windows.Forms.Label lblNavigation;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.DataGridView dgvEvents;
        private System.Windows.Forms.DataGridView dgvAppSettings;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FunctionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LibraryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parameters;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Enabled;
    }
}
