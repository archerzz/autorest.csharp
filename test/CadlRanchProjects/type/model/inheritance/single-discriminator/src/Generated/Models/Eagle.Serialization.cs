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

namespace _Type.Model.Inheritance.SingleDiscriminator.Models
{
    public partial class Eagle : IUtf8JsonSerializable, IJsonModel<Eagle>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<Eagle>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<Eagle>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Eagle>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(Eagle)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Friends))
            {
                writer.WritePropertyName("friends"u8);
                writer.WriteStartArray();
                foreach (var item in Friends)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Hate))
            {
                writer.WritePropertyName("hate"u8);
                writer.WriteStartObject();
                foreach (var item in Hate)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value, options);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(Partner))
            {
                writer.WritePropertyName("partner"u8);
                writer.WriteObjectValue(Partner, options);
            }
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind);
            writer.WritePropertyName("wingspan"u8);
            writer.WriteNumberValue(Wingspan);
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

        Eagle IJsonModel<Eagle>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Eagle>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(Eagle)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEagle(document.RootElement, options);
        }

        internal static Eagle DeserializeEagle(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<Bird> friends = default;
            IDictionary<string, Bird> hate = default;
            Bird partner = default;
            string kind = default;
            int wingspan = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("friends"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<Bird> array = new List<Bird>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeserializeBird(item, options));
                    }
                    friends = array;
                    continue;
                }
                if (property.NameEquals("hate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, Bird> dictionary = new Dictionary<string, Bird>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, DeserializeBird(property0.Value, options));
                    }
                    hate = dictionary;
                    continue;
                }
                if (property.NameEquals("partner"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    partner = DeserializeBird(property.Value, options);
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("wingspan"u8))
                {
                    wingspan = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new Eagle(
                kind,
                wingspan,
                serializedAdditionalRawData,
                friends ?? new ChangeTrackingList<Bird>(),
                hate ?? new ChangeTrackingDictionary<string, Bird>(),
                partner);
        }

        BinaryData IPersistableModel<Eagle>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Eagle>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(Eagle)} does not support writing '{options.Format}' format.");
            }
        }

        Eagle IPersistableModel<Eagle>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Eagle>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeEagle(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(Eagle)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<Eagle>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new Eagle FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeEagle(document.RootElement);
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
