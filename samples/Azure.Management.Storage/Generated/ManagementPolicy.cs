// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Core;

namespace Azure.Management.Storage
{
    /// <summary> A Class representing a ManagementPolicy along with the instance operations that can be performed on it. </summary>
    public class ManagementPolicy : ManagementPolicyOperations
    {
        /// <summary> Initializes a new instance of the <see cref = "ManagementPolicy"/> class for mocking. </summary>
        protected ManagementPolicy() : base()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ManagementPolicy"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal ManagementPolicy(OperationsBase options, ManagementPolicyData resource) : base(options, resource.Id)
        {
            Data = resource;
        }

        /// <summary> Gets or sets the ManagementPolicyData. </summary>
        public virtual ManagementPolicyData Data { get; private set; }
    }
}
