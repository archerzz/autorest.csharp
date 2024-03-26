// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace CognitiveSearch.Models
{
    public partial class SynonymMap : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("format"u8);
            writer.WriteStringValue(Format.ToString());
            writer.WritePropertyName("synonyms"u8);
            writer.WriteStringValue(Synonyms);
            if (Optional.IsDefined(EncryptionKey))
            {
                writer.WritePropertyName("encryptionKey"u8);
                writer.WriteObjectValue<EncryptionKey>(EncryptionKey);
            }
            if (Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("@odata.etag"u8);
                writer.WriteStringValue(ETag);
            }
            writer.WriteEndObject();
        }

        internal static SynonymMap DeserializeSynonymMap(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            SynonymMapFormat format = default;
            string synonyms = default;
            EncryptionKey encryptionKey = default;
            string odataEtag = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("format"u8))
                {
                    format = new SynonymMapFormat(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("synonyms"u8))
                {
                    synonyms = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("encryptionKey"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    encryptionKey = EncryptionKey.DeserializeEncryptionKey(property.Value);
                    continue;
                }
                if (property.NameEquals("@odata.etag"u8))
                {
                    odataEtag = property.Value.GetString();
                    continue;
                }
            }
            return new SynonymMap(name, format, synonyms, encryptionKey, odataEtag);
        }
    }
}
