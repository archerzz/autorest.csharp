// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Versioning.Removed.OldVersion.Models
{
    internal static partial class EnumV2Extensions
    {
        public static string ToSerialString(this EnumV2 value) => value switch
        {
            EnumV2.EnumMemberV1 => "enumMemberV1",
            EnumV2.EnumMemberV2 => "enumMemberV2",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown EnumV2 value.")
        };

        public static EnumV2 ToEnumV2(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "enumMemberV1")) return EnumV2.EnumMemberV1;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "enumMemberV2")) return EnumV2.EnumMemberV2;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown EnumV2 value.");
        }
    }
}