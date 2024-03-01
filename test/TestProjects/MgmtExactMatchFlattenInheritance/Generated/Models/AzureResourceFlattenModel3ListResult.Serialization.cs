// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace MgmtExactMatchFlattenInheritance.Models
{
    internal partial class AzureResourceFlattenModel3ListResult
    {
        internal static AzureResourceFlattenModel3ListResult DeserializeAzureResourceFlattenModel3ListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<AzureResourceFlattenModel3> value = default;
            string nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AzureResourceFlattenModel3> array = new List<AzureResourceFlattenModel3>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AzureResourceFlattenModel3.DeserializeAzureResourceFlattenModel3(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new AzureResourceFlattenModel3ListResult(value ?? new ChangeTrackingList<AzureResourceFlattenModel3>(), nextLink);
        }
    }
}
