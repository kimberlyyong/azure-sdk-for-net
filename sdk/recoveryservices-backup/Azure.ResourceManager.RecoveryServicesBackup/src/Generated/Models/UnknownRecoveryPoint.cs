// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> The UnknownRecoveryPoint. </summary>
    internal partial class UnknownRecoveryPoint : BackupGenericRecoveryPoint
    {
        /// <summary> Initializes a new instance of UnknownRecoveryPoint. </summary>
        /// <param name="objectType"> This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types. </param>
        internal UnknownRecoveryPoint(string objectType) : base(objectType)
        {
            ObjectType = objectType ?? "Unknown";
        }
    }
}
