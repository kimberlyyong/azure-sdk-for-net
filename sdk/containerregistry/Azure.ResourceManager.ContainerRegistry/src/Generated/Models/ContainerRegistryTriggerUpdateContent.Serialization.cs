// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    public partial class ContainerRegistryTriggerUpdateContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(TimerTriggers))
            {
                writer.WritePropertyName("timerTriggers"u8);
                writer.WriteStartArray();
                foreach (var item in TimerTriggers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(SourceTriggers))
            {
                writer.WritePropertyName("sourceTriggers"u8);
                writer.WriteStartArray();
                foreach (var item in SourceTriggers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(BaseImageTrigger))
            {
                writer.WritePropertyName("baseImageTrigger"u8);
                writer.WriteObjectValue(BaseImageTrigger);
            }
            writer.WriteEndObject();
        }
    }
}
