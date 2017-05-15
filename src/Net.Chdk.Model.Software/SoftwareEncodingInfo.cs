using Net.Chdk.Json;
using Newtonsoft.Json;

namespace Net.Chdk.Model.Software
{
    public sealed class SoftwareEncodingInfo
    {
        public string Name { get; set; }

        [JsonConverter(typeof(HexStringJsonConverter))]
        public ulong? Data { get; set; }
    }
}
