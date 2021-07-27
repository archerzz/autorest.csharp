// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace OperationGroupMappings.Models
{
    public partial class Usage
    {
        internal static Usage DeserializeUsage(JsonElement element)
        {
            string unit = default;
            int currentValue = default;
            long limit = default;
            UsageName name = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("unit"))
                {
                    unit = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("currentValue"))
                {
                    currentValue = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("limit"))
                {
                    limit = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = UsageName.DeserializeUsageName(property.Value);
                    continue;
                }
            }
            return new Usage(unit, currentValue, limit, name);
        }
    }
}
