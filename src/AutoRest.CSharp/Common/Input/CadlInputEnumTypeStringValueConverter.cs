// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace AutoRest.CSharp.Common.Input
{
    internal sealed class CadlInputEnumTypeStringValueConverter : CadlInputEnumTypeValueConverter<string>
    {
        public CadlInputEnumTypeStringValueConverter(CadlReferenceHandler referenceHandler) : base(referenceHandler)
        {
        }

        protected override InputEnumTypeValue BuildEnumTypeValue(string name, string value, string? description)
        {
            return new InputEnumTypeStringValue(name, value, description);
        }

        protected override string ReadValue(ref Utf8JsonReader reader)
        {
            return reader.GetString() ?? throw new JsonException();
        }
    }
}
