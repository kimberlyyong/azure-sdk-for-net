// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    /// <summary> The SIMs to delete. </summary>
    public partial class SimDeleteList
    {
        /// <summary> Initializes a new instance of SimDeleteList. </summary>
        /// <param name="sims"> A list of SIM resource names to delete. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sims"/> is null. </exception>
        public SimDeleteList(IEnumerable<string> sims)
        {
            Argument.AssertNotNull(sims, nameof(sims));

            Sims = sims.ToList();
        }

        /// <summary> A list of SIM resource names to delete. </summary>
        public IList<string> Sims { get; }
    }
}
