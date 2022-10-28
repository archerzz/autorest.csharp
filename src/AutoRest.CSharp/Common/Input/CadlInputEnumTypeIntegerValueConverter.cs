// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace AutoRest.CSharp.Common.Input
{
    internal sealed class CadlInputEnumTypeIntegerValueConverter : CadlInputEnumTypeValueConverter<int>
    {
        public CadlInputEnumTypeIntegerValueConverter(CadlReferenceHandler referenceHandler) : base(referenceHandler)
        {
        }

        protected override InputEnumTypeValue BuildEnumTypeValue(string name, int value, string? description)
        {
            return new InputEnumTypeIntegerValue(name, value, description);
        }

        protected override int ReadValue(ref Utf8JsonReader reader)
        {
            return reader.GetInt32();
        }
    }
}
