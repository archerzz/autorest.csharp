// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;

namespace MgmtSupersetFlattenInheritance.Models
{
    internal partial class SubResourceModel1ListResult
    {
        internal static SubResourceModel1ListResult DeserializeSubResourceModel1ListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<SubResourceModel1> value = default;
            string nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SubResourceModel1> array = new List<SubResourceModel1>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SubResourceModel1.DeserializeSubResourceModel1(item));
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
            return new SubResourceModel1ListResult(value ?? new ChangeTrackingList<SubResourceModel1>(), nextLink);
        }
    }
}
