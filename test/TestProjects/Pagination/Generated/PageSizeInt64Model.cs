// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Core;
using Pagination.Models;

namespace Pagination
{
    /// <summary> A Class representing a PageSizeInt64Model along with the instance operations that can be performed on it. </summary>
    public class PageSizeInt64Model : PageSizeInt64ModelOperations
    {
        /// <summary> Initializes a new instance of the <see cref = "PageSizeInt64Model"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal PageSizeInt64Model(OperationsBase options, PageSizeInt64ModelData resource) : base(options, resource.Id)
        {
            Data = resource;
        }

        /// <summary> Gets or sets the PageSizeInt64ModelData. </summary>
        public PageSizeInt64ModelData Data { get; private set; }
    }
}
