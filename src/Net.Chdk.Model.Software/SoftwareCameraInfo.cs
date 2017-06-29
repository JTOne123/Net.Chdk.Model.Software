namespace Net.Chdk.Model.Software
{
    public sealed class SoftwareCameraInfo
    {
        public string Platform { get; set; }
        public string Revision { get; set; }

        public override bool Equals(object obj)
        {
            var camera2 = obj as SoftwareCameraInfo;
            return Platform.Equals(camera2?.Platform) && Revision.Equals(camera2?.Revision);
        }

        public override int GetHashCode()
        {
            return Platform.GetHashCode() ^ Revision.GetHashCode();
        }
    }
}