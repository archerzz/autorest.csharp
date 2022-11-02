// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;
using Azure.Core;

namespace ADP.DataManagement.Ingestion.Uploads
{
    public partial class UploadDataFile
    {
        internal static UploadDataFile DeserializeUploadDataFile(JsonElement element)
        {
            string clientFileName = default;
            string fileUploadUri = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("clientFileName"))
                {
                    clientFileName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fileUploadUri"))
                {
                    fileUploadUri = property.Value.GetString();
                    continue;
                }
            }
            return new UploadDataFile(clientFileName, fileUploadUri);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static UploadDataFile FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeUploadDataFile(document.RootElement);
        }
    }
}
