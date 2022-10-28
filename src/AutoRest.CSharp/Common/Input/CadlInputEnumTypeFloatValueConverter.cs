// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace AutoRest.CSharp.Common.Input
{
    internal sealed class CadlInputEnumTypeFloatValueConverter : CadlInputEnumTypeValueConverter<float>
    {
        public CadlInputEnumTypeFloatValueConverter(CadlReferenceHandler referenceHandler) : base(referenceHandler)
        {
        }

        protected override InputEnumTypeValue BuildEnumTypeValue(string name, float value, string? description)
        {
            return new InputEnumTypeFloatValue(name, value, description);
        }

        protected override float ReadValue(ref Utf8JsonReader reader)
        {
            return reader.GetSingle();
        }
    }
}
