// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace MgmtMockAndSample.Models
{
    public partial class FirewallPolicyRule : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            writer.WritePropertyName("ruleType");
            writer.WriteStringValue(RuleType.ToString());
            writer.WriteEndObject();
        }

        internal static FirewallPolicyRule DeserializeFirewallPolicyRule(JsonElement element)
        {
            if (element.TryGetProperty("ruleType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "ApplicationRule": return ApplicationRule.DeserializeApplicationRule(element);
                    case "NatRule": return NatRule.DeserializeNatRule(element);
                    case "NetworkRule": return NetworkRule.DeserializeNetworkRule(element);
                }
            }
            return UnknownFirewallPolicyRule.DeserializeUnknownFirewallPolicyRule(element);
        }
    }
}