// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;

namespace MgmtParamOrdering
{
    /// <summary> A class to add extension methods to Subscription. </summary>
    internal partial class SubscriptionExtensionClient : ArmResource
    {
        private ClientDiagnostics _availabilitySetResourceAvailabilitySetsClientDiagnostics;
        private AvailabilitySetsRestOperations _availabilitySetResourceAvailabilitySetsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionExtensionClient"/> class for mocking. </summary>
        protected SubscriptionExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SubscriptionExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics AvailabilitySetResourceAvailabilitySetsClientDiagnostics => _availabilitySetResourceAvailabilitySetsClientDiagnostics ??= new ClientDiagnostics("MgmtParamOrdering", AvailabilitySetResource.ResourceType.Namespace, DiagnosticOptions);
        private AvailabilitySetsRestOperations AvailabilitySetResourceAvailabilitySetsRestClient => _availabilitySetResourceAvailabilitySetsRestClient ??= new AvailabilitySetsRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, GetApiVersionOrNull(AvailabilitySetResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of VirtualMachineExtensionImageResources in the VirtualMachineExtensionImageResource. </summary>
        /// <param name="location"> The name of a supported Azure region. </param>
        /// <param name="publisherName"> The String to use. </param>
        /// <returns> An object representing collection of VirtualMachineExtensionImageResources and their operations over a VirtualMachineExtensionImageResource. </returns>
        public virtual VirtualMachineExtensionImageCollection GetVirtualMachineExtensionImageResources(string location, string publisherName)
        {
            return new VirtualMachineExtensionImageCollection(Client, Id, location, publisherName);
        }

        /// <summary>
        /// Lists all availability sets in a subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/availabilitySets
        /// Operation Id: AvailabilitySets_ListBySubscription
        /// </summary>
        /// <param name="expand"> The expand expression to apply to the operation. Allowed values are &apos;instanceView&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AvailabilitySetResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AvailabilitySetResource> GetAvailabilitySetResourcesAsync(string expand = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<AvailabilitySetResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = AvailabilitySetResourceAvailabilitySetsClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetAvailabilitySetResources");
                scope.Start();
                try
                {
                    var response = await AvailabilitySetResourceAvailabilitySetsRestClient.ListBySubscriptionAsync(Id.SubscriptionId, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AvailabilitySetResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<AvailabilitySetResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = AvailabilitySetResourceAvailabilitySetsClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetAvailabilitySetResources");
                scope.Start();
                try
                {
                    var response = await AvailabilitySetResourceAvailabilitySetsRestClient.ListBySubscriptionNextPageAsync(nextLink, Id.SubscriptionId, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AvailabilitySetResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Lists all availability sets in a subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/availabilitySets
        /// Operation Id: AvailabilitySets_ListBySubscription
        /// </summary>
        /// <param name="expand"> The expand expression to apply to the operation. Allowed values are &apos;instanceView&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AvailabilitySetResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AvailabilitySetResource> GetAvailabilitySetResources(string expand = null, CancellationToken cancellationToken = default)
        {
            Page<AvailabilitySetResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = AvailabilitySetResourceAvailabilitySetsClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetAvailabilitySetResources");
                scope.Start();
                try
                {
                    var response = AvailabilitySetResourceAvailabilitySetsRestClient.ListBySubscription(Id.SubscriptionId, expand, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AvailabilitySetResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<AvailabilitySetResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = AvailabilitySetResourceAvailabilitySetsClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetAvailabilitySetResources");
                scope.Start();
                try
                {
                    var response = AvailabilitySetResourceAvailabilitySetsRestClient.ListBySubscriptionNextPage(nextLink, Id.SubscriptionId, expand, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AvailabilitySetResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }
    }
}
