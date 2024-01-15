// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace _Type.Union.Models
{
    /// <summary> The GetResponse8. </summary>
    public partial class GetResponse8
    {
        /// <summary> Initializes a new instance of <see cref="GetResponse8"/>. </summary>
        /// <param name="prop"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="prop"/> is null. </exception>
        internal GetResponse8(MixedLiteralsCases prop)
        {
            Argument.AssertNotNull(prop, nameof(prop));

            Prop = prop;
        }

        /// <summary> Gets the prop. </summary>
        public MixedLiteralsCases Prop { get; }
    }
}