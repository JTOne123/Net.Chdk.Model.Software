using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Globalization;

namespace Net.Chdk.Model.Software
{
    public sealed class SoftwareProductInfo
    {
        public string Name { get; set; }

        [JsonConverter(typeof(VersionConverter))]
        public Version Version { get; set; }

        public DateTime? Created { get; set; }

        public CultureInfo Language { get; set; }
    }
}