// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;
using MgmtReferenceTypes;

namespace Azure.ResourceManager.Fake.Models
{
    [JsonConverter(typeof(MgmtReferenceTypesPrivateLinkServiceConnectionStateConverter))]
    public partial class MgmtReferenceTypesPrivateLinkServiceConnectionState : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(ActionsRequired))
            {
                writer.WritePropertyName("actionsRequired"u8);
                writer.WriteStringValue(ActionsRequired);
            }
            writer.WriteEndObject();
        }

        internal static MgmtReferenceTypesPrivateLinkServiceConnectionState DeserializeMgmtReferenceTypesPrivateLinkServiceConnectionState(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MgmtReferenceTypesPrivateEndpointServiceConnectionStatus? status = default;
            string description = default;
            string actionsRequired = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new MgmtReferenceTypesPrivateEndpointServiceConnectionStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("actionsRequired"u8))
                {
                    actionsRequired = property.Value.GetString();
                    continue;
                }
            }
            return new MgmtReferenceTypesPrivateLinkServiceConnectionState(status, description, actionsRequired);
        }

        internal partial class MgmtReferenceTypesPrivateLinkServiceConnectionStateConverter : JsonConverter<MgmtReferenceTypesPrivateLinkServiceConnectionState>
        {
            public override void Write(Utf8JsonWriter writer, MgmtReferenceTypesPrivateLinkServiceConnectionState model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override MgmtReferenceTypesPrivateLinkServiceConnectionState Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeMgmtReferenceTypesPrivateLinkServiceConnectionState(document.RootElement);
            }
        }
    }
}