using System.Collections.Generic;

namespace Net.Chdk.Model.Software
{
    public sealed class SoftwareHashInfo
    {
        public string Name { get; set; }

        public IDictionary<string, string> Values { get; set; }
    }
}
