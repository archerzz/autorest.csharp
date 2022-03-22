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

namespace MgmtCollectionParent
{
    /// <summary> A class to add extension methods to MgmtCollectionParent. </summary>
    public static partial class MgmtCollectionParentExtensions
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
        /// Lists order at subscription level.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.EdgeOrder/orders
        /// Operation Id: ListOrderAtSubscriptionLevel
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="skipToken"> $skipToken is supported on Get list of order, which provides the next page in the list of order. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="OrderResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<OrderResource> GetOrderResourcesAsync(this SubscriptionResource subscriptionResource, string skipToken = null, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetOrderResourcesAsync(skipToken, cancellationToken);
        }

        /// <summary>
        /// Lists order at subscription level.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.EdgeOrder/orders
        /// Operation Id: ListOrderAtSubscriptionLevel
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="skipToken"> $skipToken is supported on Get list of order, which provides the next page in the list of order. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="OrderResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<OrderResource> GetOrderResources(this SubscriptionResource subscriptionResource, string skipToken = null, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetOrderResources(skipToken, cancellationToken);
        }

        private static ResourceGroupResourceExtensionClient GetExtensionClient(ResourceGroupResource resourceGroupResource)
        {
            return resourceGroupResource.GetCachedClient((client) =>
            {
                return new ResourceGroupResourceExtensionClient(client, resourceGroupResource.Id);
            }
            );
        }

        /// <summary> Gets a collection of OrderResources in the OrderResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of OrderResources and their operations over a OrderResource. </returns>
        public static OrderResourceCollection GetOrderResources(this ResourceGroupResource resourceGroupResource)
        {
            return GetExtensionClient(resourceGroupResource).GetOrderResources();
        }

        /// <summary>
        /// Gets an order.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EdgeOrder/locations/{location}/orders/{orderName}
        /// Operation Id: GetOrderByName
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="orderName"> The name of the order. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> or <paramref name="orderName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="orderName"/> is null. </exception>
        public static async Task<Response<OrderResource>> GetOrderResourceAsync(this ResourceGroupResource resourceGroupResource, string location, string orderName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetOrderResources().GetAsync(location, orderName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets an order.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EdgeOrder/locations/{location}/orders/{orderName}
        /// Operation Id: GetOrderByName
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="orderName"> The name of the order. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> or <paramref name="orderName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="orderName"/> is null. </exception>
        public static Response<OrderResource> GetOrderResource(this ResourceGroupResource resourceGroupResource, string location, string orderName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetOrderResources().Get(location, orderName, cancellationToken);
        }

        #region OrderResource
        /// <summary> Gets an object representing a OrderResource along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="OrderResource" /> object. </returns>
        public static OrderResource GetOrderResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                OrderResource.ValidateResourceId(id);
                return new OrderResource(client, id);
            }
            );
        }
        #endregion
    }
}
