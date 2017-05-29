using System;
using System.Collections.Generic;

namespace Net.Chdk.Model.Software
{
    public sealed class ModulesInfo
    {
        public Version Version { get; set; }
        public string ProductName { get; set; }
        public IDictionary<string, ModuleInfo> Modules { get; set; }
    }
}
