using System;
using System.Collections.Generic;
using System.Globalization;
using System.Web.Script.Serialization;

namespace Cryptush.lib
{
    public class Agent
    {
        public Agent()
        {
            guid = new Guid();
            Files = new List<string>();
            Username = Environment.UserName;
            Domain = Environment.UserDomainName;
            MachineName = Environment.MachineName;
            StartDate = DateTime.Now.ToString();
            AgentTimeZone = GetTimeZone();
            DateTimeCulture = CultureInfo.CurrentCulture.Name;
        }
        public Guid guid { get; set; }
        public List<string> Files { get; set; }
        public string Username { get; set; }
        public string Domain { get; set; }
        public string MachineName { get; set; }
        public string Key { get; set; }
        public string StartDate { get; set; }
        public string AgentTimeZone { get; set; }
        public string DateTimeCulture { get; set; }

        public string ToJSON()
        {
            JavaScriptSerializer js = new JavaScriptSerializer();
            return js.Serialize(this);
        }

        public string GetTimeZone()
        {
            TimeZone localZone = TimeZone.CurrentTimeZone;
            DateTime currentDate = DateTime.Now;
            TimeSpan currentOffset = localZone.GetUtcOffset(currentDate);
            return currentOffset.ToString();
        }
    }

}
