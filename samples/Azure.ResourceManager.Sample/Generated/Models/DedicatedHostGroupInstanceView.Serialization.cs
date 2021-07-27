// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sample.Models
{
    public partial class DedicatedHostGroupInstanceView
    {
        internal static DedicatedHostGroupInstanceView DeserializeDedicatedHostGroupInstanceView(JsonElement element)
        {
            Optional<IReadOnlyList<DedicatedHostInstanceViewWithName>> hosts = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("hosts"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<DedicatedHostInstanceViewWithName> array = new List<DedicatedHostInstanceViewWithName>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DedicatedHostInstanceViewWithName.DeserializeDedicatedHostInstanceViewWithName(item));
                    }
                    hosts = array;
                    continue;
                }
            }
            return new DedicatedHostGroupInstanceView(Optional.ToList(hosts));
        }
    }
}
