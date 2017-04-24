namespace Net.Chdk.Model.Software
{
    public sealed class SoftwareProductInfo
    {
        public string Name { get; set; }
        public string Version { get; set; }
        public System.DateTime? Created { get; set; }
        public System.Globalization.CultureInfo Language { get; set; }
    }
}