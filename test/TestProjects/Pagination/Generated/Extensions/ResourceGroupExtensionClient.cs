// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;

namespace Pagination
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

        /// <summary> Gets a collection of PageSizeIntegerModelResources in the PageSizeIntegerModelResource. </summary>
        /// <returns> An object representing collection of PageSizeIntegerModelResources and their operations over a PageSizeIntegerModelResource. </returns>
        public virtual PageSizeIntegerModelCollection GetPageSizeIntegerModelResources()
        {
            return GetCachedClient(Client => new PageSizeIntegerModelCollection(Client, Id));
        }

        /// <summary> Gets a collection of PageSizeInt64ModelResources in the PageSizeInt64ModelResource. </summary>
        /// <returns> An object representing collection of PageSizeInt64ModelResources and their operations over a PageSizeInt64ModelResource. </returns>
        public virtual PageSizeInt64ModelCollection GetPageSizeInt64ModelResources()
        {
            return GetCachedClient(Client => new PageSizeInt64ModelCollection(Client, Id));
        }

        /// <summary> Gets a collection of PageSizeInt32ModelResources in the PageSizeInt32ModelResource. </summary>
        /// <returns> An object representing collection of PageSizeInt32ModelResources and their operations over a PageSizeInt32ModelResource. </returns>
        public virtual PageSizeInt32ModelCollection GetPageSizeInt32ModelResources()
        {
            return GetCachedClient(Client => new PageSizeInt32ModelCollection(Client, Id));
        }

        /// <summary> Gets a collection of PageSizeNumericModelResources in the PageSizeNumericModelResource. </summary>
        /// <returns> An object representing collection of PageSizeNumericModelResources and their operations over a PageSizeNumericModelResource. </returns>
        public virtual PageSizeNumericModelCollection GetPageSizeNumericModelResources()
        {
            return GetCachedClient(Client => new PageSizeNumericModelCollection(Client, Id));
        }

        /// <summary> Gets a collection of PageSizeFloatModelResources in the PageSizeFloatModelResource. </summary>
        /// <returns> An object representing collection of PageSizeFloatModelResources and their operations over a PageSizeFloatModelResource. </returns>
        public virtual PageSizeFloatModelCollection GetPageSizeFloatModelResources()
        {
            return GetCachedClient(Client => new PageSizeFloatModelCollection(Client, Id));
        }

        /// <summary> Gets a collection of PageSizeDoubleModelResources in the PageSizeDoubleModelResource. </summary>
        /// <returns> An object representing collection of PageSizeDoubleModelResources and their operations over a PageSizeDoubleModelResource. </returns>
        public virtual PageSizeDoubleModelCollection GetPageSizeDoubleModelResources()
        {
            return GetCachedClient(Client => new PageSizeDoubleModelCollection(Client, Id));
        }

        /// <summary> Gets a collection of PageSizeDecimalModelResources in the PageSizeDecimalModelResource. </summary>
        /// <returns> An object representing collection of PageSizeDecimalModelResources and their operations over a PageSizeDecimalModelResource. </returns>
        public virtual PageSizeDecimalModelCollection GetPageSizeDecimalModelResources()
        {
            return GetCachedClient(Client => new PageSizeDecimalModelCollection(Client, Id));
        }

        /// <summary> Gets a collection of PageSizeStringModelResources in the PageSizeStringModelResource. </summary>
        /// <returns> An object representing collection of PageSizeStringModelResources and their operations over a PageSizeStringModelResource. </returns>
        public virtual PageSizeStringModelCollection GetPageSizeStringModelResources()
        {
            return GetCachedClient(Client => new PageSizeStringModelCollection(Client, Id));
        }
    }
}
