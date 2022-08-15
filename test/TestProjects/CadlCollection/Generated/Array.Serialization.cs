// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;
using Azure.Core;

namespace CadlCollection
{
    public partial class Array : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WriteEndObject();
        }

        internal static Array DeserializeArray(JsonElement element)
        {
            foreach (var property in element.EnumerateObject())
            {
            }
            return new Array();
        }

        internal RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }

        internal static Array FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeArray(document.RootElement);
        }
    }
}
