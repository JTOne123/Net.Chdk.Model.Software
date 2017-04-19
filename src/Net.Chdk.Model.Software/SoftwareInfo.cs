namespace Net.Chdk.Model.Software
{
    public sealed class SoftwareInfo
    {
        public string Version { get; set; }
        public ProductInfo Product { get; set; }
        public CameraInfo Camera { get; set; }
        public BuildInfo Build { get; set; }
        public CompilerInfo Compiler { get; set; }
        public SourceInfo Source { get; set; }
    }
}
