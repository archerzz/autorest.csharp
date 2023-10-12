// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;
using Azure.Core;

namespace _Azure.Lro.Standard.Models
{
    internal partial class ResourceOperationStatusUserExportedUserError
    {
        internal static ResourceOperationStatusUserExportedUserError DeserializeResourceOperationStatusUserExportedUserError(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            OperationState status = default;
            Optional<ResponseError> error = default;
            Optional<ExportedUser> result = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = new OperationState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = JsonSerializer.Deserialize<ResponseError>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("result"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result = ExportedUser.DeserializeExportedUser(property.Value);
                    continue;
                }
            }
            return new ResourceOperationStatusUserExportedUserError(id, status, error.Value, result.Value);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ResourceOperationStatusUserExportedUserError FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeResourceOperationStatusUserExportedUserError(document.RootElement);
        }
    }
}
