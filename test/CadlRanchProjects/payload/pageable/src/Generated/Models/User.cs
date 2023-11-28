// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Payload.Pageable.Models
{
    /// <summary> User model. </summary>
    public partial class User
    {
        /// <summary> Initializes a new instance of <see cref="User"/>. </summary>
        /// <param name="name"> User name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        internal User(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        /// <summary> User name. </summary>
        public string Name { get; }
    }
}
