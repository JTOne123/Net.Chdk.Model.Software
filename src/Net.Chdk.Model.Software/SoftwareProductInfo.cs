using System;
using System.Globalization;

namespace Net.Chdk.Model.Software
{
    public sealed class SoftwareProductInfo
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public Version Version { get; set; }
        public DateTime? Created { get; set; }
        public CultureInfo Language { get; set; }
    }
}