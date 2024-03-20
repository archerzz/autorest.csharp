// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using AzureSample.ResourceManager.Storage;

namespace AzureSample.ResourceManager.Storage.Models
{
    public partial class GeoReplicationStats
    {
        internal static GeoReplicationStats DeserializeGeoReplicationStats(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            GeoReplicationStatus? status = default;
            DateTimeOffset? lastSyncTime = default;
            bool? canFailover = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new GeoReplicationStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("lastSyncTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastSyncTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("canFailover"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    canFailover = property.Value.GetBoolean();
                    continue;
                }
            }
            return new GeoReplicationStats(status, lastSyncTime, canFailover);
        }
    }
}