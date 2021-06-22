// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using System.Threading.Tasks;
using Azure.ResourceManager.Core;

namespace SupersetFlattenInheritance
{
    /// <summary> A Class representing a SubResourceModel1 along with the instance operations that can be performed on it. </summary>
    public class SubResourceModel1 : SubResourceModel1Operations
    {
        /// <summary> Initializes a new instance of the <see cref = "SubResourceModel1"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal SubResourceModel1(ResourceOperationsBase options, SubResourceModel1Data resource) : base(options, resource.Id)
        {
            Data = resource;
        }

        /// <summary> Gets or sets the SubResourceModel1Data. </summary>
        public SubResourceModel1Data Data { get; private set; }

        /// <inheritdoc />
        protected override SubResourceModel1 GetResource(CancellationToken cancellation = default)
        {
            return this;
        }

        /// <inheritdoc />
        protected override Task<SubResourceModel1> GetResourceAsync(CancellationToken cancellation = default)
        {
            return Task.FromResult(this);
        }
    }
}