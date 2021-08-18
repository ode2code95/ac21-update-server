using System;

namespace Pure.Functions.Models
{
    public class ClientProduct
    {
        public Guid Id { get; set; }

        public Version SoftwareVersion { get; set; }

        public Version FirmwareVersion { get; set; }

        public ClientProduct(Guid id, Version swVersion, Version fwVersion)
        {
            Id = id;
            SoftwareVersion = swVersion;
            FirmwareVersion = fwVersion;
        }
    }
}
