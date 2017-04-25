using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace Net.Chdk.Model.Software
{
    public sealed class SoftwareInfo
    {
        [JsonConverter(typeof(VersionConverter))]
        public Version Version { get; set; }

        public SoftwareProductInfo Product { get; set; }
        public SoftwareCameraInfo Camera { get; set; }
        public SoftwareBuildInfo Build { get; set; }
        public SoftwareCompilerInfo Compiler { get; set; }
        public SoftwareSourceInfo Source { get; set; }
        public SoftwareHashInfo Hash { get; set; }
    }
}
