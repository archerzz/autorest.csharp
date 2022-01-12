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
using MgmtListMethods.Models;

namespace MgmtListMethods
{
    /// <summary> A class representing collection of SubParentWithNonResCh and their operations over its parent. </summary>
    public partial class SubParentWithNonResChCollection : ArmCollection, IEnumerable<SubParentWithNonResCh>, IAsyncEnumerable<SubParentWithNonResCh>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly SubParentWithNonResChesRestOperations _subParentWithNonResChesRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubParentWithNonResChCollection"/> class for mocking. </summary>
        protected SubParentWithNonResChCollection()
        {
        }

        /// <summary> Initializes a new instance of SubParentWithNonResChCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal SubParentWithNonResChCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _subParentWithNonResChesRestClient = new SubParentWithNonResChesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != Subscription.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, Subscription.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.MgmtListMethods/subParentWithNonResChes/{subParentWithNonResChName}
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: SubParentWithNonResChes_CreateOrUpdate
        /// <summary> Create or update. </summary>
        /// <param name="subParentWithNonResChName"> Name. </param>
        /// <param name="parameters"> Parameters supplied to the Create. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subParentWithNonResChName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual SubParentWithNonResChCreateOrUpdateOperation CreateOrUpdate(string subParentWithNonResChName, SubParentWithNonResChData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (subParentWithNonResChName == null)
            {
                throw new ArgumentNullException(nameof(subParentWithNonResChName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("SubParentWithNonResChCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _subParentWithNonResChesRestClient.CreateOrUpdate(Id.SubscriptionId, subParentWithNonResChName, parameters, cancellationToken);
                var operation = new SubParentWithNonResChCreateOrUpdateOperation(Parent, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.MgmtListMethods/subParentWithNonResChes/{subParentWithNonResChName}
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: SubParentWithNonResChes_CreateOrUpdate
        /// <summary> Create or update. </summary>
        /// <param name="subParentWithNonResChName"> Name. </param>
        /// <param name="parameters"> Parameters supplied to the Create. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subParentWithNonResChName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<SubParentWithNonResChCreateOrUpdateOperation> CreateOrUpdateAsync(string subParentWithNonResChName, SubParentWithNonResChData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (subParentWithNonResChName == null)
            {
                throw new ArgumentNullException(nameof(subParentWithNonResChName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("SubParentWithNonResChCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _subParentWithNonResChesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, subParentWithNonResChName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new SubParentWithNonResChCreateOrUpdateOperation(Parent, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.MgmtListMethods/subParentWithNonResChes/{subParentWithNonResChName}
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: SubParentWithNonResChes_Get
        /// <summary> Retrieves information. </summary>
        /// <param name="subParentWithNonResChName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subParentWithNonResChName"/> is null. </exception>
        public virtual Response<SubParentWithNonResCh> Get(string subParentWithNonResChName, CancellationToken cancellationToken = default)
        {
            if (subParentWithNonResChName == null)
            {
                throw new ArgumentNullException(nameof(subParentWithNonResChName));
            }

            using var scope = _clientDiagnostics.CreateScope("SubParentWithNonResChCollection.Get");
            scope.Start();
            try
            {
                var response = _subParentWithNonResChesRestClient.Get(Id.SubscriptionId, subParentWithNonResChName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SubParentWithNonResCh(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.MgmtListMethods/subParentWithNonResChes/{subParentWithNonResChName}
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: SubParentWithNonResChes_Get
        /// <summary> Retrieves information. </summary>
        /// <param name="subParentWithNonResChName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subParentWithNonResChName"/> is null. </exception>
        public async virtual Task<Response<SubParentWithNonResCh>> GetAsync(string subParentWithNonResChName, CancellationToken cancellationToken = default)
        {
            if (subParentWithNonResChName == null)
            {
                throw new ArgumentNullException(nameof(subParentWithNonResChName));
            }

            using var scope = _clientDiagnostics.CreateScope("SubParentWithNonResChCollection.Get");
            scope.Start();
            try
            {
                var response = await _subParentWithNonResChesRestClient.GetAsync(Id.SubscriptionId, subParentWithNonResChName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SubParentWithNonResCh(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="subParentWithNonResChName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subParentWithNonResChName"/> is null. </exception>
        public virtual Response<SubParentWithNonResCh> GetIfExists(string subParentWithNonResChName, CancellationToken cancellationToken = default)
        {
            if (subParentWithNonResChName == null)
            {
                throw new ArgumentNullException(nameof(subParentWithNonResChName));
            }

            using var scope = _clientDiagnostics.CreateScope("SubParentWithNonResChCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _subParentWithNonResChesRestClient.Get(Id.SubscriptionId, subParentWithNonResChName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<SubParentWithNonResCh>(null, response.GetRawResponse())
                    : Response.FromValue(new SubParentWithNonResCh(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="subParentWithNonResChName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subParentWithNonResChName"/> is null. </exception>
        public async virtual Task<Response<SubParentWithNonResCh>> GetIfExistsAsync(string subParentWithNonResChName, CancellationToken cancellationToken = default)
        {
            if (subParentWithNonResChName == null)
            {
                throw new ArgumentNullException(nameof(subParentWithNonResChName));
            }

            using var scope = _clientDiagnostics.CreateScope("SubParentWithNonResChCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _subParentWithNonResChesRestClient.GetAsync(Id.SubscriptionId, subParentWithNonResChName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<SubParentWithNonResCh>(null, response.GetRawResponse())
                    : Response.FromValue(new SubParentWithNonResCh(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="subParentWithNonResChName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subParentWithNonResChName"/> is null. </exception>
        public virtual Response<bool> Exists(string subParentWithNonResChName, CancellationToken cancellationToken = default)
        {
            if (subParentWithNonResChName == null)
            {
                throw new ArgumentNullException(nameof(subParentWithNonResChName));
            }

            using var scope = _clientDiagnostics.CreateScope("SubParentWithNonResChCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(subParentWithNonResChName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="subParentWithNonResChName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subParentWithNonResChName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string subParentWithNonResChName, CancellationToken cancellationToken = default)
        {
            if (subParentWithNonResChName == null)
            {
                throw new ArgumentNullException(nameof(subParentWithNonResChName));
            }

            using var scope = _clientDiagnostics.CreateScope("SubParentWithNonResChCollection.ExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(subParentWithNonResChName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.MgmtListMethods/subParentWithNonResChes
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: SubParentWithNonResChes_List
        /// <summary> Lists all in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SubParentWithNonResCh" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SubParentWithNonResCh> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SubParentWithNonResCh> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SubParentWithNonResChCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _subParentWithNonResChesRestClient.List(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SubParentWithNonResCh(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SubParentWithNonResCh> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SubParentWithNonResChCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _subParentWithNonResChesRestClient.ListNextPage(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SubParentWithNonResCh(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.MgmtListMethods/subParentWithNonResChes
        /// ContextualPath: /subscriptions/{subscriptionId}
        /// OperationId: SubParentWithNonResChes_List
        /// <summary> Lists all in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SubParentWithNonResCh" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SubParentWithNonResCh> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SubParentWithNonResCh>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SubParentWithNonResChCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _subParentWithNonResChesRestClient.ListAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SubParentWithNonResCh(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SubParentWithNonResCh>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SubParentWithNonResChCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _subParentWithNonResChesRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SubParentWithNonResCh(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="SubParentWithNonResCh" /> for this subscription represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SubParentWithNonResChCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(SubParentWithNonResCh.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as Subscription, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="SubParentWithNonResCh" /> for this subscription represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SubParentWithNonResChCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(SubParentWithNonResCh.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as Subscription, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SubParentWithNonResCh> IEnumerable<SubParentWithNonResCh>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SubParentWithNonResCh> IAsyncEnumerable<SubParentWithNonResCh>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, SubParentWithNonResCh, SubParentWithNonResChData> Construct() { }
    }
}
