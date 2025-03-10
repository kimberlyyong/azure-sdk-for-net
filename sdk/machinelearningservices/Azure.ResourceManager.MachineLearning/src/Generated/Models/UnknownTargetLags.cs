// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The UnknownTargetLags. </summary>
    internal partial class UnknownTargetLags : TargetLags
    {
        /// <summary> Initializes a new instance of UnknownTargetLags. </summary>
        /// <param name="mode"> [Required] Set target lags mode - Auto/Custom. </param>
        internal UnknownTargetLags(TargetLagsMode mode) : base(mode)
        {
            Mode = mode;
        }
    }
}
