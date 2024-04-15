// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace ModelsTypeSpec.Models
{
    public partial class NumericValuesFacet : IUtf8JsonSerializable, IJsonModel<NumericValuesFacet>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NumericValuesFacet>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NumericValuesFacet>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NumericValuesFacet>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NumericValuesFacet)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("values"u8);
            writer.WriteStartArray();
            foreach (var item in Values)
            {
                writer.WriteNumberValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("value"u8);
            writer.WriteNumberValue(Value);
            writer.WritePropertyName("field"u8);
            writer.WriteStringValue(Field);
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        NumericValuesFacet IJsonModel<NumericValuesFacet>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NumericValuesFacet>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NumericValuesFacet)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNumericValuesFacet(document.RootElement, options);
        }

        internal static NumericValuesFacet DeserializeNumericValuesFacet(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<int> values = default;
            int value = default;
            string field = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("values"u8))
                {
                    List<int> array = new List<int>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetInt32());
                    }
                    values = array;
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    value = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("field"u8))
                {
                    field = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new NumericValuesFacet(field, serializedAdditionalRawData, values, value);
        }

        BinaryData IPersistableModel<NumericValuesFacet>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NumericValuesFacet>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NumericValuesFacet)} does not support writing '{options.Format}' format.");
            }
        }

        NumericValuesFacet IPersistableModel<NumericValuesFacet>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NumericValuesFacet>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNumericValuesFacet(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NumericValuesFacet)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<NumericValuesFacet>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new NumericValuesFacet FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeNumericValuesFacet(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, new ModelReaderWriterOptions("W"));
            return content;
        }
    }
}
