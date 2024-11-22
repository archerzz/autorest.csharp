// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace _Azure.ResourceManager.CommonProperties
{
    public partial class ManagedIdentityTrackedResource : IJsonModel<ManagedIdentityTrackedResourceData>
    {
        void IJsonModel<ManagedIdentityTrackedResourceData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<ManagedIdentityTrackedResourceData>)Data).Write(writer, options);

        ManagedIdentityTrackedResourceData IJsonModel<ManagedIdentityTrackedResourceData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<ManagedIdentityTrackedResourceData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<ManagedIdentityTrackedResourceData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        ManagedIdentityTrackedResourceData IPersistableModel<ManagedIdentityTrackedResourceData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<ManagedIdentityTrackedResourceData>(data, options);

        string IPersistableModel<ManagedIdentityTrackedResourceData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<ManagedIdentityTrackedResourceData>)Data).GetFormatFromOptions(options);
    }
}