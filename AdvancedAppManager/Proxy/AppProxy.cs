using System.Collections.Generic;
using Fic.XTB.AdvancedAppManager.Model;
using Microsoft.Xrm.Sdk;
using Newtonsoft.Json;

namespace Fic.XTB.AdvancedAppManager.Proxy
{
    public class AppProxy
    {
        public Entity Entity;
        public List<AppEventHandler> EventHandlers;
        public AppProxy(Entity entity)
        {
            Entity = entity;

            var eventHandlersJson = entity.Contains("eventhandlers") ? (string)entity["eventhandlers"] : "";
            EventHandlers = JsonConvert.DeserializeObject<List<AppEventHandler>>(eventHandlersJson);
        }

        public override string ToString()
        {
            if (Entity != null)
            {
                return (string)Entity["name"];
            }

            return base.ToString();
        }
    }
}
