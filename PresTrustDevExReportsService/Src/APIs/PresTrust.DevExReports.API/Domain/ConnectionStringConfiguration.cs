using System;

namespace PresTrust.DevExReports.API.Domain
{
    public class ConnectionStringConfiguration
    {
        public ConnectionStringConfiguration(string value) => Value = value;

        public String Value { get; set; }
    }
}
