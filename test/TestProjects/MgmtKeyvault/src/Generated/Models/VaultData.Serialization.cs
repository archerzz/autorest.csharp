// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager;
using MgmtKeyvault.Models;

namespace MgmtKeyvault
{
    public partial class VaultData
    {
        internal static VaultData DeserializeVaultData(JsonElement element)
        {
            Optional<string> location = default;
            Optional<IReadOnlyDictionary<string, string>> tags = default;
            Optional<SystemData> systemData = default;
            VaultProperties properties = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = SystemData.DeserializeSystemData(property.Value);
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    properties = VaultProperties.DeserializeVaultProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
            }
            return new VaultData(id, name, type, location.Value, Optional.ToDictionary(tags), systemData.Value, properties);
        }
    }
}
