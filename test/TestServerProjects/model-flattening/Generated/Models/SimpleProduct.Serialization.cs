// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace model_flattening.Models
{
    public partial class SimpleProduct : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("base_product_id"u8);
            writer.WriteStringValue(ProductId);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("base_product_description"u8);
                writer.WriteStringValue(Description);
            }
            writer.WritePropertyName("details"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(MaxProductDisplayName))
            {
                writer.WritePropertyName("max_product_display_name"u8);
                writer.WriteStringValue(MaxProductDisplayName);
            }
            if (Optional.IsDefined(Capacity))
            {
                writer.WritePropertyName("max_product_capacity"u8);
                writer.WriteStringValue(Capacity.Value.ToString());
            }
            writer.WritePropertyName("max_product_image"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(GenericValue))
            {
                writer.WritePropertyName("generic_value"u8);
                writer.WriteStringValue(GenericValue);
            }
            if (Optional.IsDefined(OdataValue))
            {
                writer.WritePropertyName("@odata.value"u8);
                writer.WriteStringValue(OdataValue);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static SimpleProduct DeserializeSimpleProduct(JsonElement element)
        {
            string baseProductId = default;
            Optional<string> baseProductDescription = default;
            Optional<string> maxProductDisplayName = default;
            Optional<SimpleProductPropertiesMaxProductCapacity> maxProductCapacity = default;
            Optional<string> genericValue = default;
            Optional<string> odataValue = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("base_product_id"u8))
                {
                    baseProductId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("base_product_description"u8))
                {
                    baseProductDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("details"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("max_product_display_name"u8))
                        {
                            maxProductDisplayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("max_product_capacity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maxProductCapacity = new SimpleProductPropertiesMaxProductCapacity(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("max_product_image"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.NameEquals("generic_value"u8))
                                {
                                    genericValue = property1.Value.GetString();
                                    continue;
                                }
                                if (property1.NameEquals("@odata.value"u8))
                                {
                                    odataValue = property1.Value.GetString();
                                    continue;
                                }
                            }
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new SimpleProduct(baseProductId, baseProductDescription.Value, maxProductDisplayName.Value, Optional.ToNullable(maxProductCapacity), genericValue.Value, odataValue.Value);
        }
    }
}
