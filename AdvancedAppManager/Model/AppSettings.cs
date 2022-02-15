using System;
using Microsoft.Xrm.Sdk;

namespace Fic.XTB.AdvancedAppManager.Model
{
    public class AppSettings
    {
        public string DisplayName { get; set; }
        public string DataType { get; set; }
        public string Value { get; set; }
        public string AppSettingsId { get; set; }
        public string SettingDefinitionId { get; set; }
        public string SettingUniqueName { get; set; }
        public string DefaultValue { get; set; }

        public AppSettings(Entity entity)
        {
            DisplayName = (string)entity["displayname"];
            DefaultValue = (string)entity["defaultvalue"];
            DataType = entity.FormattedValues["datatype"];
            Value = entity.Contains("as.value") 
                ? ((AliasedValue)entity["as.value"]).Value.ToString() 
                : string.Empty;
            AppSettingsId = entity.Contains("as.appsettingid")
                ? ((Guid)((AliasedValue)entity["as.appsettingid"]).Value).ToString("D")
                : string.Empty;
            SettingDefinitionId = entity.Id.ToString("D");
            SettingUniqueName = (string)entity["uniquename"];
        }
    }
}
