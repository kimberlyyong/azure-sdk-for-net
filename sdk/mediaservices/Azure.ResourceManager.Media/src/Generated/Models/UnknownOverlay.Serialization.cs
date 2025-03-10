// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    internal partial class UnknownOverlay : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(OdataType);
            writer.WritePropertyName("inputLabel"u8);
            writer.WriteStringValue(InputLabel);
            if (Optional.IsDefined(Start))
            {
                writer.WritePropertyName("start"u8);
                writer.WriteStringValue(Start.Value, "P");
            }
            if (Optional.IsDefined(End))
            {
                writer.WritePropertyName("end"u8);
                writer.WriteStringValue(End.Value, "P");
            }
            if (Optional.IsDefined(FadeInDuration))
            {
                writer.WritePropertyName("fadeInDuration"u8);
                writer.WriteStringValue(FadeInDuration.Value, "P");
            }
            if (Optional.IsDefined(FadeOutDuration))
            {
                writer.WritePropertyName("fadeOutDuration"u8);
                writer.WriteStringValue(FadeOutDuration.Value, "P");
            }
            if (Optional.IsDefined(AudioGainLevel))
            {
                writer.WritePropertyName("audioGainLevel"u8);
                writer.WriteNumberValue(AudioGainLevel.Value);
            }
            writer.WriteEndObject();
        }

        internal static UnknownOverlay DeserializeUnknownOverlay(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string odataType = "Unknown";
            string inputLabel = default;
            Optional<TimeSpan> start = default;
            Optional<TimeSpan> end = default;
            Optional<TimeSpan> fadeInDuration = default;
            Optional<TimeSpan> fadeOutDuration = default;
            Optional<double> audioGainLevel = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("@odata.type"u8))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("inputLabel"u8))
                {
                    inputLabel = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("start"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    start = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("end"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    end = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("fadeInDuration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fadeInDuration = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("fadeOutDuration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fadeOutDuration = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("audioGainLevel"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    audioGainLevel = property.Value.GetDouble();
                    continue;
                }
            }
            return new UnknownOverlay(odataType, inputLabel, Optional.ToNullable(start), Optional.ToNullable(end), Optional.ToNullable(fadeInDuration), Optional.ToNullable(fadeOutDuration), Optional.ToNullable(audioGainLevel));
        }
    }
}
