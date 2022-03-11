// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;

namespace MgmtKeyvault
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

        /// <summary> Gets a collection of VaultResources in the VaultResource. </summary>
        /// <returns> An object representing collection of VaultResources and their operations over a VaultResource. </returns>
        public virtual VaultCollection GetVaultResources()
        {
            return GetCachedClient(Client => new VaultCollection(Client, Id));
        }

        /// <summary> Gets a collection of ManagedHsmResources in the ManagedHsmResource. </summary>
        /// <returns> An object representing collection of ManagedHsmResources and their operations over a ManagedHsmResource. </returns>
        public virtual ManagedHsmCollection GetManagedHsmResources()
        {
            return GetCachedClient(Client => new ManagedHsmCollection(Client, Id));
        }
    }
}
