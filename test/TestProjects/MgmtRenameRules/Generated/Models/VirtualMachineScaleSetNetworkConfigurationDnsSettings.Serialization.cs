// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace MgmtRenameRules.Models
{
    internal partial class VirtualMachineScaleSetNetworkConfigurationDnsSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(DnsServers))
            {
                writer.WritePropertyName("dnsServers");
                writer.WriteStartArray();
                foreach (var item in DnsServers)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static VirtualMachineScaleSetNetworkConfigurationDnsSettings DeserializeVirtualMachineScaleSetNetworkConfigurationDnsSettings(JsonElement element)
        {
            Optional<IList<string>> dnsServers = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dnsServers"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    dnsServers = array;
                    continue;
                }
            }
            return new VirtualMachineScaleSetNetworkConfigurationDnsSettings(Optional.ToList(dnsServers));
        }
    }
}