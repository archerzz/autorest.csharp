// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;

namespace MgmtSubscriptionNameParameter
{
    /// <summary> A class representing collection of SBSubscription and their operations over its parent. </summary>
    public partial class SBSubscriptionCollection : ArmCollection, IEnumerable<SBSubscriptionResource>, IAsyncEnumerable<SBSubscriptionResource>
    {
        private readonly ClientDiagnostics _sbSubscriptionResourceSubscriptionsClientDiagnostics;
        private readonly SubscriptionsRestOperations _sbSubscriptionResourceSubscriptionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SBSubscriptionCollection"/> class for mocking. </summary>
        protected SBSubscriptionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SBSubscriptionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SBSubscriptionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sbSubscriptionResourceSubscriptionsClientDiagnostics = new ClientDiagnostics("MgmtSubscriptionNameParameter", SBSubscriptionResource.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(SBSubscriptionResource.ResourceType, out string sbSubscriptionResourceSubscriptionsApiVersion);
            _sbSubscriptionResourceSubscriptionsRestClient = new SubscriptionsRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, sbSubscriptionResourceSubscriptionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a topic subscription.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/subscriptions/{subscriptionName}
        /// Operation Id: Subscriptions_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="subscriptionName"> The subscription name. </param>
        /// <param name="parameters"> Parameters supplied to create a subscription resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual async Task<ArmOperation<SBSubscriptionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string subscriptionName, SBSubscriptionData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionName, nameof(subscriptionName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _sbSubscriptionResourceSubscriptionsClientDiagnostics.CreateScope("SBSubscriptionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _sbSubscriptionResourceSubscriptionsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, subscriptionName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new MgmtSubscriptionNameParameterArmOperation<SBSubscriptionResource>(Response.FromValue(new SBSubscriptionResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates a topic subscription.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/subscriptions/{subscriptionName}
        /// Operation Id: Subscriptions_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="subscriptionName"> The subscription name. </param>
        /// <param name="parameters"> Parameters supplied to create a subscription resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<SBSubscriptionResource> CreateOrUpdate(WaitUntil waitUntil, string subscriptionName, SBSubscriptionData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionName, nameof(subscriptionName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _sbSubscriptionResourceSubscriptionsClientDiagnostics.CreateScope("SBSubscriptionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _sbSubscriptionResourceSubscriptionsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, subscriptionName, parameters, cancellationToken);
                var operation = new MgmtSubscriptionNameParameterArmOperation<SBSubscriptionResource>(Response.FromValue(new SBSubscriptionResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns a subscription description for the specified topic.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/subscriptions/{subscriptionName}
        /// Operation Id: Subscriptions_Get
        /// </summary>
        /// <param name="subscriptionName"> The subscription name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionName"/> is null. </exception>
        public virtual async Task<Response<SBSubscriptionResource>> GetAsync(string subscriptionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionName, nameof(subscriptionName));

            using var scope = _sbSubscriptionResourceSubscriptionsClientDiagnostics.CreateScope("SBSubscriptionCollection.Get");
            scope.Start();
            try
            {
                var response = await _sbSubscriptionResourceSubscriptionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, subscriptionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SBSubscriptionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns a subscription description for the specified topic.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/subscriptions/{subscriptionName}
        /// Operation Id: Subscriptions_Get
        /// </summary>
        /// <param name="subscriptionName"> The subscription name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionName"/> is null. </exception>
        public virtual Response<SBSubscriptionResource> Get(string subscriptionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionName, nameof(subscriptionName));

            using var scope = _sbSubscriptionResourceSubscriptionsClientDiagnostics.CreateScope("SBSubscriptionCollection.Get");
            scope.Start();
            try
            {
                var response = _sbSubscriptionResourceSubscriptionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, subscriptionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SBSubscriptionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all the subscriptions under a specified topic.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/subscriptions
        /// Operation Id: Subscriptions_ListByTopic
        /// </summary>
        /// <param name="skip"> Skip is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skip parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="top"> May be used to limit the number of results to the most recent N usageDetails. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SBSubscriptionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SBSubscriptionResource> GetAllAsync(int? skip = null, int? top = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<SBSubscriptionResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _sbSubscriptionResourceSubscriptionsClientDiagnostics.CreateScope("SBSubscriptionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _sbSubscriptionResourceSubscriptionsRestClient.ListByTopicAsync(Id.SubscriptionId, Id.ResourceGroupName, skip, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SBSubscriptionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SBSubscriptionResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _sbSubscriptionResourceSubscriptionsClientDiagnostics.CreateScope("SBSubscriptionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _sbSubscriptionResourceSubscriptionsRestClient.ListByTopicNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, skip, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SBSubscriptionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// List all the subscriptions under a specified topic.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/subscriptions
        /// Operation Id: Subscriptions_ListByTopic
        /// </summary>
        /// <param name="skip"> Skip is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skip parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="top"> May be used to limit the number of results to the most recent N usageDetails. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SBSubscriptionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SBSubscriptionResource> GetAll(int? skip = null, int? top = null, CancellationToken cancellationToken = default)
        {
            Page<SBSubscriptionResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _sbSubscriptionResourceSubscriptionsClientDiagnostics.CreateScope("SBSubscriptionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _sbSubscriptionResourceSubscriptionsRestClient.ListByTopic(Id.SubscriptionId, Id.ResourceGroupName, skip, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SBSubscriptionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SBSubscriptionResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _sbSubscriptionResourceSubscriptionsClientDiagnostics.CreateScope("SBSubscriptionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _sbSubscriptionResourceSubscriptionsRestClient.ListByTopicNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, skip, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SBSubscriptionResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/subscriptions/{subscriptionName}
        /// Operation Id: Subscriptions_Get
        /// </summary>
        /// <param name="subscriptionName"> The subscription name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string subscriptionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionName, nameof(subscriptionName));

            using var scope = _sbSubscriptionResourceSubscriptionsClientDiagnostics.CreateScope("SBSubscriptionCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(subscriptionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/subscriptions/{subscriptionName}
        /// Operation Id: Subscriptions_Get
        /// </summary>
        /// <param name="subscriptionName"> The subscription name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionName"/> is null. </exception>
        public virtual Response<bool> Exists(string subscriptionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionName, nameof(subscriptionName));

            using var scope = _sbSubscriptionResourceSubscriptionsClientDiagnostics.CreateScope("SBSubscriptionCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(subscriptionName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/subscriptions/{subscriptionName}
        /// Operation Id: Subscriptions_Get
        /// </summary>
        /// <param name="subscriptionName"> The subscription name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionName"/> is null. </exception>
        public virtual async Task<Response<SBSubscriptionResource>> GetIfExistsAsync(string subscriptionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionName, nameof(subscriptionName));

            using var scope = _sbSubscriptionResourceSubscriptionsClientDiagnostics.CreateScope("SBSubscriptionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _sbSubscriptionResourceSubscriptionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, subscriptionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<SBSubscriptionResource>(null, response.GetRawResponse());
                return Response.FromValue(new SBSubscriptionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/subscriptions/{subscriptionName}
        /// Operation Id: Subscriptions_Get
        /// </summary>
        /// <param name="subscriptionName"> The subscription name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionName"/> is null. </exception>
        public virtual Response<SBSubscriptionResource> GetIfExists(string subscriptionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionName, nameof(subscriptionName));

            using var scope = _sbSubscriptionResourceSubscriptionsClientDiagnostics.CreateScope("SBSubscriptionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _sbSubscriptionResourceSubscriptionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, subscriptionName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<SBSubscriptionResource>(null, response.GetRawResponse());
                return Response.FromValue(new SBSubscriptionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SBSubscriptionResource> IEnumerable<SBSubscriptionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SBSubscriptionResource> IAsyncEnumerable<SBSubscriptionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
