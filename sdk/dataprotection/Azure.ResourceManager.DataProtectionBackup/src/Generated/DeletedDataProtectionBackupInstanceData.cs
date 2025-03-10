// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.DataProtectionBackup.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataProtectionBackup
{
    /// <summary>
    /// A class representing the DeletedDataProtectionBackupInstance data model.
    /// Deleted Backup Instance
    /// </summary>
    public partial class DeletedDataProtectionBackupInstanceData : ResourceData
    {
        /// <summary> Initializes a new instance of DeletedDataProtectionBackupInstanceData. </summary>
        public DeletedDataProtectionBackupInstanceData()
        {
        }

        /// <summary> Initializes a new instance of DeletedDataProtectionBackupInstanceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> DeletedBackupInstanceResource properties. </param>
        internal DeletedDataProtectionBackupInstanceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DeletedDataProtectionBackupInstanceProperties properties) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
        }

        /// <summary> DeletedBackupInstanceResource properties. </summary>
        public DeletedDataProtectionBackupInstanceProperties Properties { get; set; }
    }
}
