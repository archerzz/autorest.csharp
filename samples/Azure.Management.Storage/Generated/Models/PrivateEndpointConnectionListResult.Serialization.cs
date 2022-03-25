// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.Management.Storage;

namespace Azure.Management.Storage.Models
{
    internal partial class PrivateEndpointConnectionListResult
    {
        internal static PrivateEndpointConnectionListResult DeserializePrivateEndpointConnectionListResult(JsonElement element)
        {
            Optional<IReadOnlyList<StoragePrivateEndpointConnectionData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<StoragePrivateEndpointConnectionData> array = new List<StoragePrivateEndpointConnectionData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(StoragePrivateEndpointConnectionData.DeserializeStoragePrivateEndpointConnectionData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new PrivateEndpointConnectionListResult(Optional.ToList(value));
        }
    }
}
