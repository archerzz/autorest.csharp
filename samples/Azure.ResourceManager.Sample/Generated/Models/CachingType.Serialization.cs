// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Sample.Models
{
    internal static partial class CachingTypeExtensions
    {
        public static string ToSerialString(this CachingType value) => value switch
        {
            CachingType.None => "None",
            CachingType.ReadOnly => "ReadOnly",
            CachingType.ReadWrite => "ReadWrite",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown CachingType value.")
        };

        public static CachingType ToCachingType(this string value)
        {
            if (string.Equals(value, "None", StringComparison.InvariantCultureIgnoreCase)) return CachingType.None;
            if (string.Equals(value, "ReadOnly", StringComparison.InvariantCultureIgnoreCase)) return CachingType.ReadOnly;
            if (string.Equals(value, "ReadWrite", StringComparison.InvariantCultureIgnoreCase)) return CachingType.ReadWrite;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown CachingType value.");
        }
    }
}