// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;

namespace MgmtParent
{
    /// <summary> A class to add extension methods to ResourceGroup. </summary>
    internal partial class ResourceGroupExtensionClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="ResourceGroupExtensionClient"/> class for mocking. </summary>
        protected ResourceGroupExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ResourceGroupExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ResourceGroupExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of AvailabilitySetResources in the AvailabilitySetResource. </summary>
        /// <returns> An object representing collection of AvailabilitySetResources and their operations over a AvailabilitySetResource. </returns>
        public virtual AvailabilitySetCollection GetAvailabilitySetResources()
        {
            return GetCachedClient(Client => new AvailabilitySetCollection(Client, Id));
        }

        /// <summary> Gets a collection of DedicatedHostGroupResources in the DedicatedHostGroupResource. </summary>
        /// <returns> An object representing collection of DedicatedHostGroupResources and their operations over a DedicatedHostGroupResource. </returns>
        public virtual DedicatedHostGroupCollection GetDedicatedHostGroupResources()
        {
            return GetCachedClient(Client => new DedicatedHostGroupCollection(Client, Id));
        }
    }
}
