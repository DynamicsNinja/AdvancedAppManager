using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Fic.XTB.AdvancedAppManager.Model;

namespace Fic.XTB.AdvancedAppManager.Forms
{
    public partial class EventForm : Form
    {
        private readonly AdvancedAppManager _aam;
        private AppEventHandler _eventHandler;

        public EventForm(AdvancedAppManager aam, AppEventHandler eventHandler)
        {
            _aam = aam;
            _eventHandler = eventHandler;

            InitializeComponent();

            cbEventName.SelectedItem = eventHandler?.EventName ?? cbEventName.Items[0];

            if (eventHandler == null) { return; }

            tbFunctionName.Text = eventHandler.FunctionName;
            cbLibrary.Text = eventHandler.LibraryName;
            cbxEnabled.Checked = eventHandler.Enabled;
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void cbLibrary_TextUpdate(object sender, System.EventArgs e)
        {
            var text = cbLibrary.Text;
            var filteredScripts = _aam.ScriptLibraries.Where(s => s.ToLower().Contains(text.ToLower())).ToArray();

            if (text.Length < 3) { return; }

            cbLibrary.Items.Clear();
            cbLibrary.Items.AddRange(filteredScripts);
            Cursor = Cursors.Default;
            cbLibrary.DroppedDown = true;
            Cursor.Current = Cursors.Default;
            cbLibrary.IntegralHeight = true;
            cbLibrary.SelectedIndex = -1;
            cbLibrary.Text = text;
            cbLibrary.SelectionStart = text.Length;
            cbLibrary.SelectionLength = 0;
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            var eventHandler = new AppEventHandler
            {
                EventName = cbEventName.Text,
                FunctionName = tbFunctionName.Text,
                LibraryName = cbLibrary.Text,
                Parameters = tbParameters.Text,
                Enabled = cbxEnabled.Checked
            };

            var list = (List<AppEventHandler>)_aam.DgvEvents.DataSource ?? new List<AppEventHandler>();

            if (_eventHandler == null)
            {
                list.Add(eventHandler);
            }
            else
            {
                list[_aam.DgvEvents.CurrentRow.Index] = eventHandler;
            }

            _aam.DgvEvents.DataSource = null;
            _aam.DgvEvents.DataSource = list;

            this.Close();
        }
    }
}
