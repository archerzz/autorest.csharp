// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Resources;

namespace MgmtHierarchicalNonResource
{
    /// <summary> A class to add extension methods to Subscription. </summary>
    public static partial class SubscriptionExtensions
    {
        private static SubscriptionExtensionClient GetExtensionClient(Subscription subscription)
        {
            return subscription.GetCachedClient((client) =>
            {
                return new SubscriptionExtensionClient(client, subscription.Id);
            }
            );
        }

        /// <summary> Gets a collection of SharedGalleries in the SharedGallery. </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="location"> Resource location. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        /// <returns> An object representing collection of SharedGalleries and their operations over a SharedGallery. </returns>
        public static SharedGalleryCollection GetSharedGalleries(this Subscription subscription, string location)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));

            return GetExtensionClient(subscription).GetSharedGalleries(location);
        }
        /// <summary>
        /// Get a shared gallery by subscription id or tenant id.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/sharedGalleries/{galleryUniqueName}
        /// Operation Id: SharedGalleries_Get
        /// </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="galleryUniqueName"> The unique name of the Shared Gallery. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> or <paramref name="galleryUniqueName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="galleryUniqueName"/> is null. </exception>
        public async static Task<Response<SharedGallery>> GetSharedGalleryAsync(this Subscription subscription, string location, string galleryUniqueName, CancellationToken cancellationToken = default)
        {
            return await subscription.GetSharedGalleries(location).GetAsync(galleryUniqueName, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get a shared gallery by subscription id or tenant id.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/sharedGalleries/{galleryUniqueName}
        /// Operation Id: SharedGalleries_Get
        /// </summary>
        /// <param name="subscription"> The <see cref="Subscription" /> instance the method will execute against. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="galleryUniqueName"> The unique name of the Shared Gallery. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> or <paramref name="galleryUniqueName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="galleryUniqueName"/> is null. </exception>
        public static Response<SharedGallery> GetSharedGallery(this Subscription subscription, string location, string galleryUniqueName, CancellationToken cancellationToken = default)
        {
            return subscription.GetSharedGalleries(location).Get(galleryUniqueName, cancellationToken);
        }
    }
}
