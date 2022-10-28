// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AutoRest.CSharp.Common.Input
{
    internal abstract class CadlInputEnumTypeValueConverter<T> : JsonConverter<InputEnumTypeValue>
    {
        private readonly CadlReferenceHandler _referenceHandler;

        public CadlInputEnumTypeValueConverter(CadlReferenceHandler referenceHandler)
        {
            _referenceHandler = referenceHandler;
        }

        public override InputEnumTypeValue Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            => reader.ReadReferenceAndResolve<InputEnumTypeValue>(_referenceHandler.CurrentResolver) ?? CreateEnumTypeValue(ref reader, null, null, options, _referenceHandler.CurrentResolver);

        public override void Write(Utf8JsonWriter writer, InputEnumTypeValue value, JsonSerializerOptions options)
            => throw new NotSupportedException("Writing not supported");

        protected InputEnumTypeValue CreateEnumTypeValue(ref Utf8JsonReader reader, string? id, string? name, JsonSerializerOptions options, ReferenceResolver resolver)
        {
            var isFirstProperty = id == null;
            T? value = default;
            string? description = null;
            while (reader.TokenType != JsonTokenType.EndObject)
            {
                var isKnownProperty = reader.TryReadReferenceId(ref isFirstProperty, ref id)
                    || reader.TryReadString(nameof(InputEnumTypeValue.Name), ref name)
                    || TryReadValue(ref reader, out value)
                    || reader.TryReadString(nameof(InputEnumTypeValue.Description), ref description);

                if (!isKnownProperty)
                {
                    reader.SkipProperty();
                }
            }

            name = name ?? throw new JsonException("EnumValue must have name");

            value = value ?? throw new JsonException("EnumValue must have value");

            var enumValue = BuildEnumTypeValue(name, value, description);
            if (id != null)
            {
                resolver.AddReference(id, enumValue);
            }
            return enumValue;
        }

        protected bool TryReadValue(ref Utf8JsonReader reader, out T? value)
        {
            value = default;
            if (reader.TokenType != JsonTokenType.PropertyName)
            {
                throw new JsonException();
            }

            if (reader.GetString() != nameof(InputEnumTypeValue.Value))
            {
                return false;
            }

            reader.Read();
            value = ReadValue(ref reader);
            reader.Read();
            return true;

        }

        protected abstract T ReadValue(ref Utf8JsonReader reader);
        protected abstract InputEnumTypeValue BuildEnumTypeValue(string name, T value, string? description);
    }
}
