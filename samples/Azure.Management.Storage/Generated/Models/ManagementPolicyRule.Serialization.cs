// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Storage.Models
{
    public partial class ManagementPolicyRule : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Enabled))
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(Enabled.Value);
            }
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(RuleType.ToString());
            writer.WritePropertyName("definition"u8);
            writer.WriteObjectValue(Definition);
            writer.WriteEndObject();
        }

        internal static ManagementPolicyRule DeserializeManagementPolicyRule(JsonElement element)
        {
            Optional<bool> enabled = default;
            string name = default;
            RuleType type = default;
            ManagementPolicyDefinition definition = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new RuleType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("definition"u8))
                {
                    definition = ManagementPolicyDefinition.DeserializeManagementPolicyDefinition(property.Value);
                    continue;
                }
            }
            return new ManagementPolicyRule(Optional.ToNullable(enabled), name, type, definition);
        }
    }
}
