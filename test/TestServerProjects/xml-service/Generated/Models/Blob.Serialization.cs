// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using Azure.Core;

namespace xml_service.Models
{
    public partial class Blob : IXmlSerializable, IPersistableModel<Blob>
    {
        private void WriteInternal(XmlWriter writer, string nameHint, ModelReaderWriterOptions options)
        {
            writer.WriteStartElement(nameHint ?? "Blob");
            writer.WriteStartElement("Name");
            writer.WriteValue(Name);
            writer.WriteEndElement();
            writer.WriteStartElement("Deleted");
            writer.WriteValue(Deleted);
            writer.WriteEndElement();
            writer.WriteStartElement("Snapshot");
            writer.WriteValue(Snapshot);
            writer.WriteEndElement();
            writer.WriteObjectValue(Properties, "Properties");
            if (Optional.IsCollectionDefined(Metadata))
            {
                foreach (var pair in Metadata)
                {
                    writer.WriteStartElement("String");
                    writer.WriteValue(pair.Value);
                    writer.WriteEndElement();
                }
            }
            writer.WriteEndElement();
        }

        void IXmlSerializable.Write(XmlWriter writer, string nameHint) => WriteInternal(writer, nameHint, new ModelReaderWriterOptions("W"));

        internal static Blob DeserializeBlob(XElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            string name = default;
            bool deleted = default;
            string snapshot = default;
            BlobProperties properties = default;
            IReadOnlyDictionary<string, string> metadata = default;
            if (element.Element("Name") is XElement nameElement)
            {
                name = (string)nameElement;
            }
            if (element.Element("Deleted") is XElement deletedElement)
            {
                deleted = (bool)deletedElement;
            }
            if (element.Element("Snapshot") is XElement snapshotElement)
            {
                snapshot = (string)snapshotElement;
            }
            if (element.Element("Properties") is XElement propertiesElement)
            {
                properties = BlobProperties.DeserializeBlobProperties(propertiesElement);
            }
            if (element.Element("Metadata") is XElement metadataElement)
            {
                var dictionary = new Dictionary<string, string>();
                foreach (var e in metadataElement.Elements())
                {
                    dictionary.Add(e.Name.LocalName, (string)e);
                }
                metadata = dictionary;
            }
            return new Blob(
                name,
                deleted,
                snapshot,
                properties,
                metadata,
                serializedAdditionalRawData: null);
        }

        BinaryData IPersistableModel<Blob>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Blob>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "X":
                    {
                        using MemoryStream stream = new MemoryStream();
                        using XmlWriter writer = XmlWriter.Create(stream);
                        WriteInternal(writer, null, options);
                        writer.Flush();
                        return new BinaryData(stream.GetBuffer().AsMemory(0, (int)stream.Position));
                    }
                default:
                    throw new FormatException($"The model {nameof(Blob)} does not support writing '{options.Format}' format.");
            }
        }

        Blob IPersistableModel<Blob>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<Blob>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "X":
                    return DeserializeBlob(XElement.Load(data.ToStream()), options);
                default:
                    throw new FormatException($"The model {nameof(Blob)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<Blob>.GetFormatFromOptions(ModelReaderWriterOptions options) => "X";
    }
}
