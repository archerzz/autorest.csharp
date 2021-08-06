// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using MgmtListMethods;

namespace MgmtListMethods.Models
{
    internal partial class FakeParentWithAncestorListResult
    {
        internal static FakeParentWithAncestorListResult DeserializeFakeParentWithAncestorListResult(JsonElement element)
        {
            IReadOnlyList<FakeParentWithAncestorData> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<FakeParentWithAncestorData> array = new List<FakeParentWithAncestorData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FakeParentWithAncestorData.DeserializeFakeParentWithAncestorData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new FakeParentWithAncestorListResult(value, nextLink.Value);
        }
    }
}
