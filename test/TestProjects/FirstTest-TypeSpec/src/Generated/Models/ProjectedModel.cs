// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace FirstTestTypeSpec.Models
{
    /// <summary> this is a model with a projected name. </summary>
    public partial class ProjectedModel
    {
        /// <summary> Initializes a new instance of <see cref="ProjectedModel"/>. </summary>
        /// <param name="name"> name of the ModelWithProjectedName. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public ProjectedModel(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        /// <summary> name of the ModelWithProjectedName. </summary>
        public string Name { get; set; }
    }
}
