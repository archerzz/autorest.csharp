// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Storage.Models
{
    public partial class BlobInventoryPolicySchema : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("enabled");
            writer.WriteBooleanValue(Enabled);
            writer.WritePropertyName("type");
            writer.WriteStringValue(RuleType.ToString());
            writer.WritePropertyName("rules");
            writer.WriteStartArray();
            foreach (var item in Rules)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static BlobInventoryPolicySchema DeserializeBlobInventoryPolicySchema(JsonElement element)
        {
            bool enabled = default;
            InventoryRuleType type = default;
            IList<BlobInventoryPolicyRule> rules = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"))
                {
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new InventoryRuleType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("rules"))
                {
                    List<BlobInventoryPolicyRule> array = new List<BlobInventoryPolicyRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BlobInventoryPolicyRule.DeserializeBlobInventoryPolicyRule(item));
                    }
                    rules = array;
                    continue;
                }
            }
            return new BlobInventoryPolicySchema(enabled, type, rules);
        }
    }
}
