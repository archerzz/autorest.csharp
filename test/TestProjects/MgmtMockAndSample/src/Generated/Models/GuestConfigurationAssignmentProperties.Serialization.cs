// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace MgmtMockAndSample.Models
{
    public partial class GuestConfigurationAssignmentProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Context))
            {
                writer.WritePropertyName("context"u8);
                writer.WriteStringValue(Context);
            }
            writer.WriteEndObject();
        }

        internal static GuestConfigurationAssignmentProperties DeserializeGuestConfigurationAssignmentProperties(JsonElement element)
        {
            Optional<string> targetResourceId = default;
            Optional<ComplianceStatus> complianceStatus = default;
            Optional<DateTimeOffset?> lastComplianceStatusChecked = default;
            Optional<string> latestReportId = default;
            Optional<string> parameterHash = default;
            Optional<string> context = default;
            Optional<string> assignmentHash = default;
            Optional<ProvisioningState?> provisioningState = default;
            Optional<ResourceType?> resourceType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("targetResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        targetResourceId = null;
                        continue;
                    }
                    targetResourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("complianceStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    complianceStatus = new ComplianceStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("lastComplianceStatusChecked"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        lastComplianceStatusChecked = null;
                        continue;
                    }
                    lastComplianceStatusChecked = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("latestReportId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        latestReportId = null;
                        continue;
                    }
                    latestReportId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parameterHash"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        parameterHash = null;
                        continue;
                    }
                    parameterHash = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("context"u8))
                {
                    context = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("assignmentHash"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        assignmentHash = null;
                        continue;
                    }
                    assignmentHash = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        provisioningState = null;
                        continue;
                    }
                    provisioningState = new ProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resourceType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        resourceType = null;
                        continue;
                    }
                    resourceType = new ResourceType(property.Value.GetString());
                    continue;
                }
            }
            return new GuestConfigurationAssignmentProperties(targetResourceId.Value, Optional.ToNullable(complianceStatus), Optional.ToNullable(lastComplianceStatusChecked), latestReportId.Value, parameterHash.Value, context.Value, assignmentHash.Value, Optional.ToNullable(provisioningState), Optional.ToNullable(resourceType));
        }
    }
}
