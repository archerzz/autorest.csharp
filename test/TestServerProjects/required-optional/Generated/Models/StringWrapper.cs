// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace required_optional.Models
{
    /// <summary> The StringWrapper. </summary>
    public partial class StringWrapper
    {
        /// <summary> Initializes a new instance of <see cref="StringWrapper"/>. </summary>
        /// <param name="value"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public StringWrapper(string value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value;
        }

        /// <summary> Gets the value. </summary>
        public string Value { get; }
    }
}
