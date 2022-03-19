// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Pagination
{
    /// <summary> A class to add extension methods to Pagination. </summary>
    public static partial class PaginationExtensions
    {
        private static ResourceGroupExtensionClient GetExtensionClient(ResourceGroup resourceGroup)
        {
            return resourceGroup.GetCachedClient((client) =>
            {
                return new ResourceGroupExtensionClient(client, resourceGroup.Id);
            }
            );
        }

        /// <summary> Gets a collection of PageSizeIntegerModelResources in the PageSizeIntegerModelResource. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of PageSizeIntegerModelResources and their operations over a PageSizeIntegerModelResource. </returns>
        public static PageSizeIntegerModelCollection GetPageSizeIntegerModels(this ResourceGroup resourceGroup)
        {
            return GetExtensionClient(resourceGroup).GetPageSizeIntegerModels();
        }

        /// <summary>
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/pageSizeIntegerModel/{name}
        /// Operation Id: PageSizeIntegerModels_Get
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="name"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public static async Task<Response<PageSizeIntegerModelResource>> GetPageSizeIntegerModelAsync(this ResourceGroup resourceGroup, string name, CancellationToken cancellationToken = default)
        {
            return await resourceGroup.GetPageSizeIntegerModels().GetAsync(name, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/pageSizeIntegerModel/{name}
        /// Operation Id: PageSizeIntegerModels_Get
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="name"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public static Response<PageSizeIntegerModelResource> GetPageSizeIntegerModel(this ResourceGroup resourceGroup, string name, CancellationToken cancellationToken = default)
        {
            return resourceGroup.GetPageSizeIntegerModels().Get(name, cancellationToken);
        }

        /// <summary> Gets a collection of PageSizeInt64ModelResources in the PageSizeInt64ModelResource. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of PageSizeInt64ModelResources and their operations over a PageSizeInt64ModelResource. </returns>
        public static PageSizeInt64ModelCollection GetPageSizeInt64Models(this ResourceGroup resourceGroup)
        {
            return GetExtensionClient(resourceGroup).GetPageSizeInt64Models();
        }

        /// <summary>
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/pageSizeInt64Model/{name}
        /// Operation Id: PageSizeInt64Models_Get
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="name"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public static async Task<Response<PageSizeInt64ModelResource>> GetPageSizeInt64ModelAsync(this ResourceGroup resourceGroup, string name, CancellationToken cancellationToken = default)
        {
            return await resourceGroup.GetPageSizeInt64Models().GetAsync(name, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/pageSizeInt64Model/{name}
        /// Operation Id: PageSizeInt64Models_Get
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="name"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public static Response<PageSizeInt64ModelResource> GetPageSizeInt64Model(this ResourceGroup resourceGroup, string name, CancellationToken cancellationToken = default)
        {
            return resourceGroup.GetPageSizeInt64Models().Get(name, cancellationToken);
        }

        /// <summary> Gets a collection of PageSizeInt32ModelResources in the PageSizeInt32ModelResource. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of PageSizeInt32ModelResources and their operations over a PageSizeInt32ModelResource. </returns>
        public static PageSizeInt32ModelCollection GetPageSizeInt32Models(this ResourceGroup resourceGroup)
        {
            return GetExtensionClient(resourceGroup).GetPageSizeInt32Models();
        }

        /// <summary>
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/pageSizeInt32Model/{name}
        /// Operation Id: PageSizeInt32Models_Get
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="name"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public static async Task<Response<PageSizeInt32ModelResource>> GetPageSizeInt32ModelAsync(this ResourceGroup resourceGroup, string name, CancellationToken cancellationToken = default)
        {
            return await resourceGroup.GetPageSizeInt32Models().GetAsync(name, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/pageSizeInt32Model/{name}
        /// Operation Id: PageSizeInt32Models_Get
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="name"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public static Response<PageSizeInt32ModelResource> GetPageSizeInt32Model(this ResourceGroup resourceGroup, string name, CancellationToken cancellationToken = default)
        {
            return resourceGroup.GetPageSizeInt32Models().Get(name, cancellationToken);
        }

        /// <summary> Gets a collection of PageSizeNumericModelResources in the PageSizeNumericModelResource. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of PageSizeNumericModelResources and their operations over a PageSizeNumericModelResource. </returns>
        public static PageSizeNumericModelCollection GetPageSizeNumericModels(this ResourceGroup resourceGroup)
        {
            return GetExtensionClient(resourceGroup).GetPageSizeNumericModels();
        }

        /// <summary>
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/pageSizeNumericModel/{name}
        /// Operation Id: PageSizeNumericModels_Get
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="name"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public static async Task<Response<PageSizeNumericModelResource>> GetPageSizeNumericModelAsync(this ResourceGroup resourceGroup, string name, CancellationToken cancellationToken = default)
        {
            return await resourceGroup.GetPageSizeNumericModels().GetAsync(name, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/pageSizeNumericModel/{name}
        /// Operation Id: PageSizeNumericModels_Get
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="name"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public static Response<PageSizeNumericModelResource> GetPageSizeNumericModel(this ResourceGroup resourceGroup, string name, CancellationToken cancellationToken = default)
        {
            return resourceGroup.GetPageSizeNumericModels().Get(name, cancellationToken);
        }

        /// <summary> Gets a collection of PageSizeFloatModelResources in the PageSizeFloatModelResource. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of PageSizeFloatModelResources and their operations over a PageSizeFloatModelResource. </returns>
        public static PageSizeFloatModelCollection GetPageSizeFloatModels(this ResourceGroup resourceGroup)
        {
            return GetExtensionClient(resourceGroup).GetPageSizeFloatModels();
        }

        /// <summary>
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/pageSizeFloatModel/{name}
        /// Operation Id: PageSizeFloatModels_Get
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="name"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public static async Task<Response<PageSizeFloatModelResource>> GetPageSizeFloatModelAsync(this ResourceGroup resourceGroup, string name, CancellationToken cancellationToken = default)
        {
            return await resourceGroup.GetPageSizeFloatModels().GetAsync(name, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/pageSizeFloatModel/{name}
        /// Operation Id: PageSizeFloatModels_Get
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="name"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public static Response<PageSizeFloatModelResource> GetPageSizeFloatModel(this ResourceGroup resourceGroup, string name, CancellationToken cancellationToken = default)
        {
            return resourceGroup.GetPageSizeFloatModels().Get(name, cancellationToken);
        }

        /// <summary> Gets a collection of PageSizeDoubleModelResources in the PageSizeDoubleModelResource. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of PageSizeDoubleModelResources and their operations over a PageSizeDoubleModelResource. </returns>
        public static PageSizeDoubleModelCollection GetPageSizeDoubleModels(this ResourceGroup resourceGroup)
        {
            return GetExtensionClient(resourceGroup).GetPageSizeDoubleModels();
        }

        /// <summary>
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/pageSizeDoubleModel/{name}
        /// Operation Id: PageSizeDoubleModels_Get
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="name"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public static async Task<Response<PageSizeDoubleModelResource>> GetPageSizeDoubleModelAsync(this ResourceGroup resourceGroup, string name, CancellationToken cancellationToken = default)
        {
            return await resourceGroup.GetPageSizeDoubleModels().GetAsync(name, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/pageSizeDoubleModel/{name}
        /// Operation Id: PageSizeDoubleModels_Get
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="name"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public static Response<PageSizeDoubleModelResource> GetPageSizeDoubleModel(this ResourceGroup resourceGroup, string name, CancellationToken cancellationToken = default)
        {
            return resourceGroup.GetPageSizeDoubleModels().Get(name, cancellationToken);
        }

        /// <summary> Gets a collection of PageSizeDecimalModelResources in the PageSizeDecimalModelResource. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of PageSizeDecimalModelResources and their operations over a PageSizeDecimalModelResource. </returns>
        public static PageSizeDecimalModelCollection GetPageSizeDecimalModels(this ResourceGroup resourceGroup)
        {
            return GetExtensionClient(resourceGroup).GetPageSizeDecimalModels();
        }

        /// <summary>
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/pageSizeDecimalModel/{name}
        /// Operation Id: PageSizeDecimalModels_Get
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="name"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public static async Task<Response<PageSizeDecimalModelResource>> GetPageSizeDecimalModelAsync(this ResourceGroup resourceGroup, string name, CancellationToken cancellationToken = default)
        {
            return await resourceGroup.GetPageSizeDecimalModels().GetAsync(name, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/pageSizeDecimalModel/{name}
        /// Operation Id: PageSizeDecimalModels_Get
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="name"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public static Response<PageSizeDecimalModelResource> GetPageSizeDecimalModel(this ResourceGroup resourceGroup, string name, CancellationToken cancellationToken = default)
        {
            return resourceGroup.GetPageSizeDecimalModels().Get(name, cancellationToken);
        }

        /// <summary> Gets a collection of PageSizeStringModelResources in the PageSizeStringModelResource. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of PageSizeStringModelResources and their operations over a PageSizeStringModelResource. </returns>
        public static PageSizeStringModelCollection GetPageSizeStringModels(this ResourceGroup resourceGroup)
        {
            return GetExtensionClient(resourceGroup).GetPageSizeStringModels();
        }

        /// <summary>
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/pageSizeStringModel/{name}
        /// Operation Id: PageSizeStringModels_Get
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="name"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public static async Task<Response<PageSizeStringModelResource>> GetPageSizeStringModelAsync(this ResourceGroup resourceGroup, string name, CancellationToken cancellationToken = default)
        {
            return await resourceGroup.GetPageSizeStringModels().GetAsync(name, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/pageSizeStringModel/{name}
        /// Operation Id: PageSizeStringModels_Get
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="name"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public static Response<PageSizeStringModelResource> GetPageSizeStringModel(this ResourceGroup resourceGroup, string name, CancellationToken cancellationToken = default)
        {
            return resourceGroup.GetPageSizeStringModels().Get(name, cancellationToken);
        }

        #region PageSizeIntegerModelResource
        /// <summary> Gets an object representing a PageSizeIntegerModelResource along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PageSizeIntegerModelResource" /> object. </returns>
        public static PageSizeIntegerModelResource GetPageSizeIntegerModelResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                PageSizeIntegerModelResource.ValidateResourceId(id);
                return new PageSizeIntegerModelResource(client, id);
            }
            );
        }
        #endregion

        #region PageSizeInt64ModelResource
        /// <summary> Gets an object representing a PageSizeInt64ModelResource along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PageSizeInt64ModelResource" /> object. </returns>
        public static PageSizeInt64ModelResource GetPageSizeInt64ModelResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                PageSizeInt64ModelResource.ValidateResourceId(id);
                return new PageSizeInt64ModelResource(client, id);
            }
            );
        }
        #endregion

        #region PageSizeInt32ModelResource
        /// <summary> Gets an object representing a PageSizeInt32ModelResource along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PageSizeInt32ModelResource" /> object. </returns>
        public static PageSizeInt32ModelResource GetPageSizeInt32ModelResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                PageSizeInt32ModelResource.ValidateResourceId(id);
                return new PageSizeInt32ModelResource(client, id);
            }
            );
        }
        #endregion

        #region PageSizeNumericModelResource
        /// <summary> Gets an object representing a PageSizeNumericModelResource along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PageSizeNumericModelResource" /> object. </returns>
        public static PageSizeNumericModelResource GetPageSizeNumericModelResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                PageSizeNumericModelResource.ValidateResourceId(id);
                return new PageSizeNumericModelResource(client, id);
            }
            );
        }
        #endregion

        #region PageSizeFloatModelResource
        /// <summary> Gets an object representing a PageSizeFloatModelResource along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PageSizeFloatModelResource" /> object. </returns>
        public static PageSizeFloatModelResource GetPageSizeFloatModelResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                PageSizeFloatModelResource.ValidateResourceId(id);
                return new PageSizeFloatModelResource(client, id);
            }
            );
        }
        #endregion

        #region PageSizeDoubleModelResource
        /// <summary> Gets an object representing a PageSizeDoubleModelResource along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PageSizeDoubleModelResource" /> object. </returns>
        public static PageSizeDoubleModelResource GetPageSizeDoubleModelResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                PageSizeDoubleModelResource.ValidateResourceId(id);
                return new PageSizeDoubleModelResource(client, id);
            }
            );
        }
        #endregion

        #region PageSizeDecimalModelResource
        /// <summary> Gets an object representing a PageSizeDecimalModelResource along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PageSizeDecimalModelResource" /> object. </returns>
        public static PageSizeDecimalModelResource GetPageSizeDecimalModelResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                PageSizeDecimalModelResource.ValidateResourceId(id);
                return new PageSizeDecimalModelResource(client, id);
            }
            );
        }
        #endregion

        #region PageSizeStringModelResource
        /// <summary> Gets an object representing a PageSizeStringModelResource along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PageSizeStringModelResource" /> object. </returns>
        public static PageSizeStringModelResource GetPageSizeStringModelResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                PageSizeStringModelResource.ValidateResourceId(id);
                return new PageSizeStringModelResource(client, id);
            }
            );
        }
        #endregion
    }
}
