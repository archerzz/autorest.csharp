// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace TypeSchemaMapping.Models
{
    /// <summary> The ModelWithAbstractModel. </summary>
    public partial class ModelWithAbstractModel
    {
        /// <summary> Initializes a new instance of ModelWithAbstractModel. </summary>
        internal ModelWithAbstractModel()
        {
        }

        /// <summary> Initializes a new instance of ModelWithAbstractModel. </summary>
        /// <param name="abstractModelProperty"> . </param>
        internal ModelWithAbstractModel(AbstractModel abstractModelProperty)
        {
            AbstractModelProperty = abstractModelProperty;
        }

        public AbstractModel AbstractModelProperty { get; }
    }
}