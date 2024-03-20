// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace body_complex.Models
{
    public partial class BooleanWrapper : IUtf8JsonSerializable, IJsonModel<BooleanWrapper>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BooleanWrapper>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BooleanWrapper>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BooleanWrapper>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BooleanWrapper)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(FieldTrue))
            {
                writer.WritePropertyName("field_true"u8);
                writer.WriteBooleanValue(FieldTrue.Value);
            }
            if (Optional.IsDefined(FieldFalse))
            {
                writer.WritePropertyName("field_false"u8);
                writer.WriteBooleanValue(FieldFalse.Value);
            }
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

        BooleanWrapper IJsonModel<BooleanWrapper>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BooleanWrapper>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BooleanWrapper)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBooleanWrapper(document.RootElement, options);
        }

        internal static BooleanWrapper DeserializeBooleanWrapper(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? fieldTrue = default;
            bool? fieldFalse = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("field_true"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fieldTrue = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("field_false"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fieldFalse = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BooleanWrapper(fieldTrue, fieldFalse, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BooleanWrapper>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BooleanWrapper>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BooleanWrapper)} does not support '{options.Format}' format.");
            }
        }

        BooleanWrapper IPersistableModel<BooleanWrapper>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BooleanWrapper>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBooleanWrapper(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BooleanWrapper)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BooleanWrapper>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
