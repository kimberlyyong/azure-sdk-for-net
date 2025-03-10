// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.AgFoodPlatform
{
    internal class FarmBeatOperationSource : IOperationSource<FarmBeatResource>
    {
        private readonly ArmClient _client;

        internal FarmBeatOperationSource(ArmClient client)
        {
            _client = client;
        }

        FarmBeatResource IOperationSource<FarmBeatResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = FarmBeatData.DeserializeFarmBeatData(document.RootElement);
            return new FarmBeatResource(_client, data);
        }

        async ValueTask<FarmBeatResource> IOperationSource<FarmBeatResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = FarmBeatData.DeserializeFarmBeatData(document.RootElement);
            return new FarmBeatResource(_client, data);
        }
    }
}
