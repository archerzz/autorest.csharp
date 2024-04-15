// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;
using Azure.Core;

namespace CognitiveSearch.Models
{
    public partial class ShingleTokenFilter : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(MaxShingleSize))
            {
                writer.WritePropertyName("maxShingleSize"u8);
                writer.WriteNumberValue(MaxShingleSize.Value);
            }
            if (Optional.IsDefined(MinShingleSize))
            {
                writer.WritePropertyName("minShingleSize"u8);
                writer.WriteNumberValue(MinShingleSize.Value);
            }
            if (Optional.IsDefined(OutputUnigrams))
            {
                writer.WritePropertyName("outputUnigrams"u8);
                writer.WriteBooleanValue(OutputUnigrams.Value);
            }
            if (Optional.IsDefined(OutputUnigramsIfNoShingles))
            {
                writer.WritePropertyName("outputUnigramsIfNoShingles"u8);
                writer.WriteBooleanValue(OutputUnigramsIfNoShingles.Value);
            }
            if (Optional.IsDefined(TokenSeparator))
            {
                writer.WritePropertyName("tokenSeparator"u8);
                writer.WriteStringValue(TokenSeparator);
            }
            if (Optional.IsDefined(FilterToken))
            {
                writer.WritePropertyName("filterToken"u8);
                writer.WriteStringValue(FilterToken);
            }
            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(OdataType);
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WriteEndObject();
        }

        internal static ShingleTokenFilter DeserializeShingleTokenFilter(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? maxShingleSize = default;
            int? minShingleSize = default;
            bool? outputUnigrams = default;
            bool? outputUnigramsIfNoShingles = default;
            string tokenSeparator = default;
            string filterToken = default;
            string odataType = default;
            string name = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("maxShingleSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxShingleSize = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("minShingleSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minShingleSize = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("outputUnigrams"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    outputUnigrams = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("outputUnigramsIfNoShingles"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    outputUnigramsIfNoShingles = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("tokenSeparator"u8))
                {
                    tokenSeparator = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("filterToken"u8))
                {
                    filterToken = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("@odata.type"u8))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
            }
            return new ShingleTokenFilter(
                odataType,
                name,
                maxShingleSize,
                minShingleSize,
                outputUnigrams,
                outputUnigramsIfNoShingles,
                tokenSeparator,
                filterToken);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new ShingleTokenFilter FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeShingleTokenFilter(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
