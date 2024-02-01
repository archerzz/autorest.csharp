// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace FirstTestTypeSpec.Models
{
    /// <summary> extension. </summary>
    public partial class Extension : Element
    {
        /// <summary> Initializes a new instance of <see cref="Extension"/>. </summary>
        /// <param name="level"></param>
        public Extension(int level)
        {
            Level = level;
        }

        /// <summary> Initializes a new instance of <see cref="Extension"/>. </summary>
        /// <param name="extension"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="level"></param>
        internal Extension(IList<Extension> extension, IDictionary<string, BinaryData> serializedAdditionalRawData, int level) : base(extension, serializedAdditionalRawData)
        {
            Level = level;
        }

        /// <summary> Initializes a new instance of <see cref="Extension"/> for deserialization. </summary>
        internal Extension()
        {
        }

        /// <summary> Gets the level. </summary>
        public int Level { get; }
    }
}
