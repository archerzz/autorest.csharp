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

namespace MgmtSafeFlatten
{
    /// <summary> A class to add extension methods to MgmtSafeFlatten. </summary>
    public static partial class MgmtSafeFlattenExtensions
    {
        private static SubscriptionResourceExtensionClient GetExtensionClient(SubscriptionResource subscriptionResource)
        {
            return subscriptionResource.GetCachedClient((client) =>
            {
                return new SubscriptionResourceExtensionClient(client, subscriptionResource.Id);
            }
            );
        }

        /// <summary>
        /// Description for Validate information for a certificate order.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.TypeOne/typeOnes
        /// Operation Id: Common_ListTypeOnesBySubscription
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="TypeOneResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<TypeOneResource> GetTypeOnesAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetTypeOnesAsync(cancellationToken);
        }

        /// <summary>
        /// Description for Validate information for a certificate order.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.TypeOne/typeOnes
        /// Operation Id: Common_ListTypeOnesBySubscription
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="TypeOneResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<TypeOneResource> GetTypeOnes(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetTypeOnes(cancellationToken);
        }

        /// <summary>
        /// Description for Validate information for a certificate order.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.TypeTwo/typeTwos
        /// Operation Id: Common_ListTypeTwosBySubscription
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="TypeTwoResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<TypeTwoResource> GetTypeTwosAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetTypeTwosAsync(cancellationToken);
        }

        /// <summary>
        /// Description for Validate information for a certificate order.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.TypeTwo/typeTwos
        /// Operation Id: Common_ListTypeTwosBySubscription
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="TypeTwoResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<TypeTwoResource> GetTypeTwos(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetTypeTwos(cancellationToken);
        }

        private static ResourceGroupExtensionClient GetExtensionClient(ResourceGroup resourceGroup)
        {
            return resourceGroup.GetCachedClient((client) =>
            {
                return new ResourceGroupExtensionClient(client, resourceGroup.Id);
            }
            );
        }

        /// <summary> Gets a collection of TypeOneResources in the TypeOneResource. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of TypeOneResources and their operations over a TypeOneResource. </returns>
        public static TypeOneCollection GetTypeOnes(this ResourceGroup resourceGroup)
        {
            return GetExtensionClient(resourceGroup).GetTypeOnes();
        }

        /// <summary>
        /// Description for Validate information for a certificate order.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.TypeOne/typeOnes/{typeOneName}
        /// Operation Id: Common_GetTypeOne
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="typeOneName"> The name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="typeOneName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="typeOneName"/> is null. </exception>
        public static async Task<Response<TypeOneResource>> GetTypeOneAsync(this ResourceGroup resourceGroup, string typeOneName, CancellationToken cancellationToken = default)
        {
            return await resourceGroup.GetTypeOnes().GetAsync(typeOneName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Description for Validate information for a certificate order.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.TypeOne/typeOnes/{typeOneName}
        /// Operation Id: Common_GetTypeOne
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="typeOneName"> The name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="typeOneName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="typeOneName"/> is null. </exception>
        public static Response<TypeOneResource> GetTypeOne(this ResourceGroup resourceGroup, string typeOneName, CancellationToken cancellationToken = default)
        {
            return resourceGroup.GetTypeOnes().Get(typeOneName, cancellationToken);
        }

        /// <summary> Gets a collection of TypeTwoResources in the TypeTwoResource. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of TypeTwoResources and their operations over a TypeTwoResource. </returns>
        public static TypeTwoCollection GetTypeTwos(this ResourceGroup resourceGroup)
        {
            return GetExtensionClient(resourceGroup).GetTypeTwos();
        }

        /// <summary>
        /// Description for Validate information for a certificate order.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.TypeTwo/typeTwos/{typeTwoName}
        /// Operation Id: Common_GetTypeTwo
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="typeTwoName"> The name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="typeTwoName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="typeTwoName"/> is null. </exception>
        public static async Task<Response<TypeTwoResource>> GetTypeTwoAsync(this ResourceGroup resourceGroup, string typeTwoName, CancellationToken cancellationToken = default)
        {
            return await resourceGroup.GetTypeTwos().GetAsync(typeTwoName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Description for Validate information for a certificate order.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.TypeTwo/typeTwos/{typeTwoName}
        /// Operation Id: Common_GetTypeTwo
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="typeTwoName"> The name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="typeTwoName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="typeTwoName"/> is null. </exception>
        public static Response<TypeTwoResource> GetTypeTwo(this ResourceGroup resourceGroup, string typeTwoName, CancellationToken cancellationToken = default)
        {
            return resourceGroup.GetTypeTwos().Get(typeTwoName, cancellationToken);
        }

        #region TypeOneResource
        /// <summary> Gets an object representing a TypeOneResource along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="TypeOneResource" /> object. </returns>
        public static TypeOneResource GetTypeOneResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                TypeOneResource.ValidateResourceId(id);
                return new TypeOneResource(client, id);
            }
            );
        }
        #endregion

        #region TypeTwoResource
        /// <summary> Gets an object representing a TypeTwoResource along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="TypeTwoResource" /> object. </returns>
        public static TypeTwoResource GetTypeTwoResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                TypeTwoResource.ValidateResourceId(id);
                return new TypeTwoResource(client, id);
            }
            );
        }
        #endregion
    }
}
