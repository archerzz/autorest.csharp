// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace xms_error_responses.Models
{
    internal partial class LinkNotFound : IUtf8JsonSerializable, IJsonModel<LinkNotFound>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LinkNotFound>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<LinkNotFound>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LinkNotFound>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LinkNotFound)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(WhatSubAddress))
            {
                writer.WritePropertyName("whatSubAddress"u8);
                writer.WriteStringValue(WhatSubAddress);
            }
            if (Optional.IsDefined(Reason))
            {
                writer.WritePropertyName("reason"u8);
                writer.WriteStringValue(Reason);
            }
            writer.WritePropertyName("whatNotFound"u8);
            writer.WriteStringValue(WhatNotFound);
            if (Optional.IsDefined(SomeBaseProp))
            {
                writer.WritePropertyName("someBaseProp"u8);
                writer.WriteStringValue(SomeBaseProp);
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

        LinkNotFound IJsonModel<LinkNotFound>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LinkNotFound>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LinkNotFound)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLinkNotFound(document.RootElement, options);
        }

        internal static LinkNotFound DeserializeLinkNotFound(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string whatSubAddress = default;
            string reason = default;
            string whatNotFound = default;
            string someBaseProp = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("whatSubAddress"u8))
                {
                    whatSubAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("reason"u8))
                {
                    reason = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("whatNotFound"u8))
                {
                    whatNotFound = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("someBaseProp"u8))
                {
                    someBaseProp = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new LinkNotFound(someBaseProp, serializedAdditionalRawData, reason, whatNotFound, whatSubAddress);
        }

        BinaryData IPersistableModel<LinkNotFound>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LinkNotFound>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LinkNotFound)} does not support '{options.Format}' format.");
            }
        }

        LinkNotFound IPersistableModel<LinkNotFound>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LinkNotFound>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLinkNotFound(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LinkNotFound)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<LinkNotFound>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
