// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace ExactMatchInheritance.Models
{
    /// <summary> The ExactMatchModel9. </summary>
    public partial class ExactMatchModel9
    {
        /// <summary> Initializes a new instance of ExactMatchModel9. </summary>
        public ExactMatchModel9()
        {
        }

        /// <summary> Initializes a new instance of ExactMatchModel9. </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="model9Type"></param>
        internal ExactMatchModel9(int? id, string name, string model9Type)
        {
            Id = id;
            Name = name;
            Model9Type = model9Type;
        }

        /// <summary> Gets or sets the id. </summary>
        public int? Id { get; set; }
        /// <summary> Gets or sets the name. </summary>
        public string Name { get; set; }
        /// <summary> Gets or sets the model 9 type. </summary>
        public string Model9Type { get; set; }
    }
}
