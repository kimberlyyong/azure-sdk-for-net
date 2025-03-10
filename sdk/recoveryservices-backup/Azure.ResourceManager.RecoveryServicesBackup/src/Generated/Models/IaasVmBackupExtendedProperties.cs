// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Extended Properties for Azure IaasVM Backup. </summary>
    public partial class IaasVmBackupExtendedProperties
    {
        /// <summary> Initializes a new instance of IaasVmBackupExtendedProperties. </summary>
        public IaasVmBackupExtendedProperties()
        {
        }

        /// <summary> Initializes a new instance of IaasVmBackupExtendedProperties. </summary>
        /// <param name="diskExclusionProperties"> Extended Properties for Disk Exclusion. </param>
        /// <param name="linuxVmApplicationName"> Linux VM name. </param>
        internal IaasVmBackupExtendedProperties(DiskExclusionProperties diskExclusionProperties, string linuxVmApplicationName)
        {
            DiskExclusionProperties = diskExclusionProperties;
            LinuxVmApplicationName = linuxVmApplicationName;
        }

        /// <summary> Extended Properties for Disk Exclusion. </summary>
        public DiskExclusionProperties DiskExclusionProperties { get; set; }
        /// <summary> Linux VM name. </summary>
        public string LinuxVmApplicationName { get; set; }
    }
}
