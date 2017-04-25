using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace Net.Chdk.Model.Software
{
    public sealed class SoftwareCompilerInfo
    {
        public string Name { get; set; }

        [JsonConverter(typeof(VersionConverter))]
        public Version Version { get; set; }
    }
}