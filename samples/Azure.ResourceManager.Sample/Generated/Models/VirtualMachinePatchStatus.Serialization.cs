// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sample.Models
{
    public partial class VirtualMachinePatchStatus
    {
        internal static VirtualMachinePatchStatus DeserializeVirtualMachinePatchStatus(JsonElement element)
        {
            Optional<AvailablePatchSummary> availablePatchSummary = default;
            Optional<LastPatchInstallationSummary> lastPatchInstallationSummary = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("availablePatchSummary"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    availablePatchSummary = AvailablePatchSummary.DeserializeAvailablePatchSummary(property.Value);
                    continue;
                }
                if (property.NameEquals("lastPatchInstallationSummary"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    lastPatchInstallationSummary = LastPatchInstallationSummary.DeserializeLastPatchInstallationSummary(property.Value);
                    continue;
                }
            }
            return new VirtualMachinePatchStatus(availablePatchSummary.Value, lastPatchInstallationSummary.Value);
        }
    }
}
