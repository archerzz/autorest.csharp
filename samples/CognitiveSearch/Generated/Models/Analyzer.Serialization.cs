// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;
using Azure.Core;

namespace CognitiveSearch.Models
{
    public partial class Analyzer : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(OdataType);
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WriteEndObject();
        }

        internal static Analyzer DeserializeAnalyzer(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("@odata.type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "#Microsoft.Azure.Search.CustomAnalyzer": return CustomAnalyzer.DeserializeCustomAnalyzer(element);
                    case "#Microsoft.Azure.Search.PatternAnalyzer": return PatternAnalyzer.DeserializePatternAnalyzer(element);
                    case "#Microsoft.Azure.Search.StandardAnalyzer": return StandardAnalyzer.DeserializeStandardAnalyzer(element);
                    case "#Microsoft.Azure.Search.StopAnalyzer": return StopAnalyzer.DeserializeStopAnalyzer(element);
                }
            }
            return UnknownAnalyzer.DeserializeUnknownAnalyzer(element);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static Analyzer FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeAnalyzer(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
