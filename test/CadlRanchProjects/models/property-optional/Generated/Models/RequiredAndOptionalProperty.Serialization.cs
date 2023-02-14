// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;
using Azure.Core;

namespace Models.Property.Optional.Models
{
    public partial class RequiredAndOptionalProperty : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Azure.Core.Optional.IsDefined(OptionalProperty))
            {
                writer.WritePropertyName("optionalProperty"u8);
                writer.WriteStringValue(OptionalProperty);
            }
            writer.WritePropertyName("requiredProperty"u8);
            writer.WriteNumberValue(RequiredProperty);
            writer.WriteEndObject();
        }

        internal static RequiredAndOptionalProperty DeserializeRequiredAndOptionalProperty(JsonElement element)
        {
            Optional<string> optionalProperty = default;
            int requiredProperty = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("optionalProperty"u8))
                {
                    optionalProperty = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("requiredProperty"u8))
                {
                    requiredProperty = property.Value.GetInt32();
                    continue;
                }
            }
            return new RequiredAndOptionalProperty(optionalProperty, requiredProperty);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static RequiredAndOptionalProperty FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeRequiredAndOptionalProperty(document.RootElement);
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