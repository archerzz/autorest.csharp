// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace ConfidentLevelsInTsp.Models
{
    /// <summary> The derived model. </summary>
    internal partial class DerivedModel : BaseModel
    {
        /// <summary> Initializes a new instance of DerivedModel. </summary>
        /// <param name="name"> The name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public DerivedModel(string name) : base(name)
        {
            Argument.AssertNotNull(name, nameof(name));
        }

        /// <summary> Initializes a new instance of DerivedModel. </summary>
        /// <param name="name"> The name. </param>
        /// <param name="size"> The size. </param>
        /// <param name="age"> The age. </param>
        internal DerivedModel(string name, double? size, int? age) : base(name, size)
        {
            Age = age;
        }

        /// <summary> The age. </summary>
        public int? Age { get; set; }
    }
}