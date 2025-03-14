// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> HyperVReplicaAzureFailback specific planned failover input. </summary>
    public partial class HyperVReplicaAzureFailbackProviderContent : PlannedFailoverProviderSpecificFailoverContent
    {
        /// <summary> Initializes a new instance of HyperVReplicaAzureFailbackProviderContent. </summary>
        public HyperVReplicaAzureFailbackProviderContent()
        {
            InstanceType = "HyperVReplicaAzureFailback";
        }

        /// <summary> Data sync option. </summary>
        public string DataSyncOption { get; set; }
        /// <summary> ALR options to create alternate recovery. </summary>
        public string RecoveryVmCreationOption { get; set; }
        /// <summary> Provider Id for alternate location. </summary>
        public string ProviderIdForAlternateRecovery { get; set; }
    }
}
