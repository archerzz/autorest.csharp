// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using ADP.DataManagement.Ingestion.Uploads;
using Azure;

namespace Azure.Core
{
    public partial class PagedUploadSpecialFile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("value");
            writer.WriteStartArray();
            foreach (var item in Value)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(NextLink))
            {
                writer.WritePropertyName("nextLink");
                writer.WriteStringValue(NextLink);
            }
            writer.WriteEndObject();
        }

        internal static PagedUploadSpecialFile DeserializePagedUploadSpecialFile(JsonElement element)
        {
            IList<UploadSpecialFile> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<UploadSpecialFile> array = new List<UploadSpecialFile>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(UploadSpecialFile.DeserializeUploadSpecialFile(item));
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
            return new PagedUploadSpecialFile(value, nextLink);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static PagedUploadSpecialFile FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializePagedUploadSpecialFile(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
