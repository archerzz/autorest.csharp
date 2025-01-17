// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace _Azure.ResourceManager.Resources.Mocking
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    public partial class Mockable_AzureResourceManagerResourcesSubscriptionResource : ArmResource
    {
        private ClientDiagnostics _topLevelTrackedResourceTopLevelClientDiagnostics;
        private TopLevelRestOperations _topLevelTrackedResourceTopLevelRestClient;

        /// <summary> Initializes a new instance of the <see cref="Mockable_AzureResourceManagerResourcesSubscriptionResource"/> class for mocking. </summary>
        protected Mockable_AzureResourceManagerResourcesSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="Mockable_AzureResourceManagerResourcesSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal Mockable_AzureResourceManagerResourcesSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics TopLevelTrackedResourceTopLevelClientDiagnostics => _topLevelTrackedResourceTopLevelClientDiagnostics ??= new ClientDiagnostics("_Azure.ResourceManager.Resources", TopLevelTrackedResource.ResourceType.Namespace, Diagnostics);
        private TopLevelRestOperations TopLevelTrackedResourceTopLevelRestClient => _topLevelTrackedResourceTopLevelRestClient ??= new TopLevelRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(TopLevelTrackedResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of LocationResources in the SubscriptionResource. </summary>
        /// <param name="location"> The name of the Azure region. </param>
        /// <returns> An object representing collection of LocationResources and their operations over a LocationResource. </returns>
        public virtual LocationResourceCollection GetLocationResources(AzureLocation location)
        {
            return new LocationResourceCollection(Client, Id, location);
        }

        /// <summary>
        /// Get a LocationResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Azure.ResourceManager.Resources/locations/{location}/locationResources/{locationResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LocationResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LocationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The name of the Azure region. </param>
        /// <param name="locationResourceName"> The name of the LocationResource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="locationResourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="locationResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<LocationResource>> GetLocationResourceAsync(AzureLocation location, string locationResourceName, CancellationToken cancellationToken = default)
        {
            return await GetLocationResources(location).GetAsync(locationResourceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a LocationResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Azure.ResourceManager.Resources/locations/{location}/locationResources/{locationResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LocationResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="LocationResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The name of the Azure region. </param>
        /// <param name="locationResourceName"> The name of the LocationResource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="locationResourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="locationResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<LocationResource> GetLocationResource(AzureLocation location, string locationResourceName, CancellationToken cancellationToken = default)
        {
            return GetLocationResources(location).Get(locationResourceName, cancellationToken);
        }

        /// <summary>
        /// List TopLevelTrackedResource resources by subscription ID
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Azure.ResourceManager.Resources/topLevelTrackedResources</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TopLevelTrackedResource_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TopLevelTrackedResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="TopLevelTrackedResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<TopLevelTrackedResource> GetTopLevelTrackedResourcesAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => TopLevelTrackedResourceTopLevelRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => TopLevelTrackedResourceTopLevelRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new TopLevelTrackedResource(Client, TopLevelTrackedResourceData.DeserializeTopLevelTrackedResourceData(e)), TopLevelTrackedResourceTopLevelClientDiagnostics, Pipeline, "Mockable_AzureResourceManagerResourcesSubscriptionResource.GetTopLevelTrackedResources", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List TopLevelTrackedResource resources by subscription ID
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Azure.ResourceManager.Resources/topLevelTrackedResources</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TopLevelTrackedResource_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-12-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TopLevelTrackedResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="TopLevelTrackedResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<TopLevelTrackedResource> GetTopLevelTrackedResources(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => TopLevelTrackedResourceTopLevelRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => TopLevelTrackedResourceTopLevelRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new TopLevelTrackedResource(Client, TopLevelTrackedResourceData.DeserializeTopLevelTrackedResourceData(e)), TopLevelTrackedResourceTopLevelClientDiagnostics, Pipeline, "Mockable_AzureResourceManagerResourcesSubscriptionResource.GetTopLevelTrackedResources", "value", "nextLink", cancellationToken);
        }
    }
}
