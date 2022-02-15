using System.Collections.Generic;
using System.Windows.Forms;
using Fic.XTB.AdvancedAppManager.Model;

namespace Fic.XTB.AdvancedAppManager.Forms
{
    public partial class AppSettingsForm : Form
    {
        private readonly AdvancedAppManager _aam;
        private readonly AppSettings _appSettings;

        public AppSettingsForm(AdvancedAppManager aam, AppSettings appSettings)
        {
            _aam = aam;
            _appSettings = appSettings;

            InitializeComponent();

            cbBooleanValue.Visible = appSettings.DataType == "Boolean";

            tbName.Text = appSettings.DisplayName;
            tbDataType.Text = appSettings.DataType;
            tbDefaultValue.Text = appSettings.DefaultValue;
            tbValue.Text = appSettings.Value;

            if (appSettings.DataType == "Boolean") { cbBooleanValue.SelectedItem = appSettings.Value; }
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            var list = (List<AppSettings>)_aam.DgvAppSettings.DataSource;

            _appSettings.Value = tbValue.Text;

            _aam.DgvAppSettings.DataSource = null;
            _aam.DgvAppSettings.DataSource = list;

            this.Close();
        }

        private void cbBooleanValue_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var booleanValue = cbBooleanValue.SelectedItem.ToString();
            tbValue.Text = booleanValue;
        }
    }
}
