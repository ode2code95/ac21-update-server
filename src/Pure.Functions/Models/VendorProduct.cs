using System;

namespace Pure.Functions.Models
{
    public class VendorProduct
    {
        public Guid Id { get; set; }

        public string Description { get; set; }

        public Version Version { get; set; }

        public Version MinHardwareVersion { get; set; }

        public Version MaxHardwareVersion { get; set; }

        public VendorProduct(Guid id, string description, Version version, Version minHwVersion, Version maxHwVersion)
        {
            Id = id;
            Description = description;
            Version = version;
            MinHardwareVersion = minHwVersion;
            MaxHardwareVersion = maxHwVersion;
        }
    }
}
