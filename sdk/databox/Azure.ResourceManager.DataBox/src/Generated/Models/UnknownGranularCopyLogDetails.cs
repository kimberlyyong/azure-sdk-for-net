// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> The UnknownGranularCopyLogDetails. </summary>
    internal partial class UnknownGranularCopyLogDetails : GranularCopyLogDetails
    {
        /// <summary> Initializes a new instance of UnknownGranularCopyLogDetails. </summary>
        /// <param name="copyLogDetailsType"> Indicates the type of job details. </param>
        internal UnknownGranularCopyLogDetails(DataBoxOrderType copyLogDetailsType) : base(copyLogDetailsType)
        {
            CopyLogDetailsType = copyLogDetailsType;
        }
    }
}
