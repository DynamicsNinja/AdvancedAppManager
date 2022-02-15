using System.ComponentModel;

namespace Fic.XTB.AdvancedAppManager.Model
{
    public class AppEventHandler
    {
        public string EventName { get; set; }
        public string FunctionName { get; set; }
        public string LibraryName { get; set; }
        public string Parameters { get; set; }
        public bool Enabled { get; set; }
    }
}
