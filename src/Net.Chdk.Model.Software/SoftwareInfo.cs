﻿using System;

namespace Net.Chdk.Model.Software
{
    public sealed class SoftwareInfo
    {
        public Version Version { get; set; }
        public SoftwareCategoryInfo Category { get; set; }
        public SoftwareProductInfo Product { get; set; }
        public SoftwareCameraInfo Camera { get; set; }
        public SoftwareBuildInfo Build { get; set; }
        public SoftwareCompilerInfo Compiler { get; set; }
        public SoftwareSourceInfo Source { get; set; }
        public SoftwareEncodingInfo Encoding { get; set; }
        public SoftwareHashInfo Hash { get; set; }
    }
}