// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sample.Models
{
    public partial class OSDisk : IUtf8JsonSerializable, IJsonModel<OSDisk>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<OSDisk>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<OSDisk>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OSDisk>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OSDisk)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (OSType.HasValue)
            {
                writer.WritePropertyName("osType"u8);
                writer.WriteStringValue(OSType.Value.ToSerialString());
            }
            if (EncryptionSettings != null)
            {
                writer.WritePropertyName("encryptionSettings"u8);
                writer.WriteObjectValue(EncryptionSettings);
            }
            if (Name != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Vhd != null)
            {
                writer.WritePropertyName("vhd"u8);
                writer.WriteObjectValue(Vhd);
            }
            if (Image != null)
            {
                writer.WritePropertyName("image"u8);
                writer.WriteObjectValue(Image);
            }
            if (Caching.HasValue)
            {
                writer.WritePropertyName("caching"u8);
                writer.WriteStringValue(Caching.Value.ToSerialString());
            }
            if (WriteAcceleratorEnabled.HasValue)
            {
                writer.WritePropertyName("writeAcceleratorEnabled"u8);
                writer.WriteBooleanValue(WriteAcceleratorEnabled.Value);
            }
            if (DiffDiskSettings != null)
            {
                writer.WritePropertyName("diffDiskSettings"u8);
                writer.WriteObjectValue(DiffDiskSettings);
            }
            writer.WritePropertyName("createOption"u8);
            writer.WriteStringValue(CreateOption.ToString());
            if (DiskSizeGB.HasValue)
            {
                writer.WritePropertyName("diskSizeGB"u8);
                writer.WriteNumberValue(DiskSizeGB.Value);
            }
            if (ManagedDisk != null)
            {
                writer.WritePropertyName("managedDisk"u8);
                writer.WriteObjectValue(ManagedDisk);
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

        OSDisk IJsonModel<OSDisk>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OSDisk>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OSDisk)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOSDisk(document.RootElement, options);
        }

        internal static OSDisk DeserializeOSDisk(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            OperatingSystemType? osType = default;
            DiskEncryptionSettings encryptionSettings = default;
            string name = default;
            VirtualHardDisk vhd = default;
            VirtualHardDisk image = default;
            CachingType? caching = default;
            bool? writeAcceleratorEnabled = default;
            DiffDiskSettings diffDiskSettings = default;
            DiskCreateOptionType createOption = default;
            int? diskSizeGB = default;
            ManagedDiskParameters managedDisk = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("osType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    osType = property.Value.GetString().ToOperatingSystemType();
                    continue;
                }
                if (property.NameEquals("encryptionSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    encryptionSettings = DiskEncryptionSettings.DeserializeDiskEncryptionSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vhd"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vhd = VirtualHardDisk.DeserializeVirtualHardDisk(property.Value, options);
                    continue;
                }
                if (property.NameEquals("image"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    image = VirtualHardDisk.DeserializeVirtualHardDisk(property.Value, options);
                    continue;
                }
                if (property.NameEquals("caching"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    caching = property.Value.GetString().ToCachingType();
                    continue;
                }
                if (property.NameEquals("writeAcceleratorEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    writeAcceleratorEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("diffDiskSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diffDiskSettings = DiffDiskSettings.DeserializeDiffDiskSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("createOption"u8))
                {
                    createOption = new DiskCreateOptionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("diskSizeGB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskSizeGB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("managedDisk"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    managedDisk = ManagedDiskParameters.DeserializeManagedDiskParameters(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new OSDisk(
                osType,
                encryptionSettings,
                name,
                vhd,
                image,
                caching,
                writeAcceleratorEnabled,
                diffDiskSettings,
                createOption,
                diskSizeGB,
                managedDisk,
                serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Name != null)
            {
                builder.Append("  name:");
                if (Name.Contains(Environment.NewLine))
                {
                    builder.AppendLine(" '''");
                    builder.AppendLine($"{Name}'''");
                }
                else
                {
                    builder.AppendLine($" '{Name}'");
                }
            }

            if (OSType.HasValue)
            {
                builder.Append("  osType:");
                builder.AppendLine($" '{OSType.Value.ToSerialString()}'");
            }

            if (EncryptionSettings != null)
            {
                builder.Append("  encryptionSettings:");
                AppendChildObject(builder, EncryptionSettings, options, 2, false);
            }

            if (Vhd != null)
            {
                builder.Append("  vhd:");
                AppendChildObject(builder, Vhd, options, 2, false);
            }

            if (Image != null)
            {
                builder.Append("  image:");
                AppendChildObject(builder, Image, options, 2, false);
            }

            if (Caching.HasValue)
            {
                builder.Append("  caching:");
                builder.AppendLine($" '{Caching.Value.ToSerialString()}'");
            }

            if (WriteAcceleratorEnabled.HasValue)
            {
                builder.Append("  writeAcceleratorEnabled:");
                var boolValue = WriteAcceleratorEnabled.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (DiffDiskSettings != null)
            {
                builder.Append("  diffDiskSettings:");
                AppendChildObject(builder, DiffDiskSettings, options, 2, false);
            }

            builder.Append("  createOption:");
            builder.AppendLine($" '{CreateOption.ToString()}'");

            if (DiskSizeGB.HasValue)
            {
                builder.Append("  diskSizeGB:");
                builder.AppendLine($" {DiskSizeGB.Value}");
            }

            if (ManagedDisk != null)
            {
                builder.Append("  managedDisk:");
                AppendChildObject(builder, ManagedDisk, options, 2, false);
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void AppendChildObject(StringBuilder stringBuilder, object childObject, ModelReaderWriterOptions options, int spaces, bool indentFirstLine)
        {
            string indent = new string(' ', spaces);
            BinaryData data = ModelReaderWriter.Write(childObject, options);
            string[] lines = data.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            bool inMultilineString = false;
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                if (inMultilineString)
                {
                    if (line.Contains("'''"))
                    {
                        inMultilineString = false;
                    }
                    stringBuilder.AppendLine(line);
                    continue;
                }
                if (line.Contains("'''"))
                {
                    inMultilineString = true;
                    stringBuilder.AppendLine($"{indent}{line}");
                    continue;
                }
                if (i == 0 && !indentFirstLine)
                {
                    stringBuilder.AppendLine($" {line}");
                }
                else
                {
                    stringBuilder.AppendLine($"{indent}{line}");
                }
            }
        }

        BinaryData IPersistableModel<OSDisk>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OSDisk>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(OSDisk)} does not support '{options.Format}' format.");
            }
        }

        OSDisk IPersistableModel<OSDisk>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OSDisk>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeOSDisk(document.RootElement, options);
                    }
                case "bicep":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(OSDisk)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<OSDisk>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
