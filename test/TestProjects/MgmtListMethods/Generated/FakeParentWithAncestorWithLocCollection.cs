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
using Azure.ResourceManager.Core;
using MgmtListMethods.Models;

namespace MgmtListMethods
{
    /// <summary> A class representing collection of FakeParentWithAncestorWithLoc and their operations over its parent. </summary>
    public partial class FakeParentWithAncestorWithLocCollection : ArmCollection, IEnumerable<FakeParentWithAncestorWithLoc>, IAsyncEnumerable<FakeParentWithAncestorWithLoc>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly FakeParentWithAncestorWithLocsRestOperations _fakeParentWithAncestorWithLocsRestClient;

        /// <summary> Initializes a new instance of the <see cref="FakeParentWithAncestorWithLocCollection"/> class for mocking. </summary>
        protected FakeParentWithAncestorWithLocCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="FakeParentWithAncestorWithLocCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal FakeParentWithAncestorWithLocCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _fakeParentWithAncestorWithLocsRestClient = new FakeParentWithAncestorWithLocsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != Fake.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, Fake.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}/fakeParentWithAncestorWithLocs/{fakeParentWithAncestorWithLocName}
        /// ContextualPath: /subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}
        /// OperationId: FakeParentWithAncestorWithLocs_CreateOrUpdate
        /// <summary> Create or update. </summary>
        /// <param name="fakeParentWithAncestorWithLocName"> Name. </param>
        /// <param name="parameters"> Parameters supplied to the Create. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fakeParentWithAncestorWithLocName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual FakeParentWithAncestorWithLocCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string fakeParentWithAncestorWithLocName, FakeParentWithAncestorWithLocData parameters, CancellationToken cancellationToken = default)
        {
            if (fakeParentWithAncestorWithLocName == null)
            {
                throw new ArgumentNullException(nameof(fakeParentWithAncestorWithLocName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("FakeParentWithAncestorWithLocCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _fakeParentWithAncestorWithLocsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.Name, fakeParentWithAncestorWithLocName, parameters, cancellationToken);
                var operation = new FakeParentWithAncestorWithLocCreateOrUpdateOperation(Parent, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}/fakeParentWithAncestorWithLocs/{fakeParentWithAncestorWithLocName}
        /// ContextualPath: /subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}
        /// OperationId: FakeParentWithAncestorWithLocs_CreateOrUpdate
        /// <summary> Create or update. </summary>
        /// <param name="fakeParentWithAncestorWithLocName"> Name. </param>
        /// <param name="parameters"> Parameters supplied to the Create. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fakeParentWithAncestorWithLocName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<FakeParentWithAncestorWithLocCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string fakeParentWithAncestorWithLocName, FakeParentWithAncestorWithLocData parameters, CancellationToken cancellationToken = default)
        {
            if (fakeParentWithAncestorWithLocName == null)
            {
                throw new ArgumentNullException(nameof(fakeParentWithAncestorWithLocName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("FakeParentWithAncestorWithLocCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _fakeParentWithAncestorWithLocsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.Name, fakeParentWithAncestorWithLocName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new FakeParentWithAncestorWithLocCreateOrUpdateOperation(Parent, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}/fakeParentWithAncestorWithLocs/{fakeParentWithAncestorWithLocName}
        /// ContextualPath: /subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}
        /// OperationId: FakeParentWithAncestorWithLocs_Get
        /// <summary> Retrieves information. </summary>
        /// <param name="fakeParentWithAncestorWithLocName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fakeParentWithAncestorWithLocName"/> is null. </exception>
        public virtual Response<FakeParentWithAncestorWithLoc> Get(string fakeParentWithAncestorWithLocName, CancellationToken cancellationToken = default)
        {
            if (fakeParentWithAncestorWithLocName == null)
            {
                throw new ArgumentNullException(nameof(fakeParentWithAncestorWithLocName));
            }

            using var scope = _clientDiagnostics.CreateScope("FakeParentWithAncestorWithLocCollection.Get");
            scope.Start();
            try
            {
                var response = _fakeParentWithAncestorWithLocsRestClient.Get(Id.SubscriptionId, Id.Name, fakeParentWithAncestorWithLocName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FakeParentWithAncestorWithLoc(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}/fakeParentWithAncestorWithLocs/{fakeParentWithAncestorWithLocName}
        /// ContextualPath: /subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}
        /// OperationId: FakeParentWithAncestorWithLocs_Get
        /// <summary> Retrieves information. </summary>
        /// <param name="fakeParentWithAncestorWithLocName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fakeParentWithAncestorWithLocName"/> is null. </exception>
        public async virtual Task<Response<FakeParentWithAncestorWithLoc>> GetAsync(string fakeParentWithAncestorWithLocName, CancellationToken cancellationToken = default)
        {
            if (fakeParentWithAncestorWithLocName == null)
            {
                throw new ArgumentNullException(nameof(fakeParentWithAncestorWithLocName));
            }

            using var scope = _clientDiagnostics.CreateScope("FakeParentWithAncestorWithLocCollection.Get");
            scope.Start();
            try
            {
                var response = await _fakeParentWithAncestorWithLocsRestClient.GetAsync(Id.SubscriptionId, Id.Name, fakeParentWithAncestorWithLocName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new FakeParentWithAncestorWithLoc(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="fakeParentWithAncestorWithLocName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fakeParentWithAncestorWithLocName"/> is null. </exception>
        public virtual Response<FakeParentWithAncestorWithLoc> GetIfExists(string fakeParentWithAncestorWithLocName, CancellationToken cancellationToken = default)
        {
            if (fakeParentWithAncestorWithLocName == null)
            {
                throw new ArgumentNullException(nameof(fakeParentWithAncestorWithLocName));
            }

            using var scope = _clientDiagnostics.CreateScope("FakeParentWithAncestorWithLocCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _fakeParentWithAncestorWithLocsRestClient.Get(Id.SubscriptionId, Id.Name, fakeParentWithAncestorWithLocName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<FakeParentWithAncestorWithLoc>(null, response.GetRawResponse());
                return Response.FromValue(new FakeParentWithAncestorWithLoc(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="fakeParentWithAncestorWithLocName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fakeParentWithAncestorWithLocName"/> is null. </exception>
        public async virtual Task<Response<FakeParentWithAncestorWithLoc>> GetIfExistsAsync(string fakeParentWithAncestorWithLocName, CancellationToken cancellationToken = default)
        {
            if (fakeParentWithAncestorWithLocName == null)
            {
                throw new ArgumentNullException(nameof(fakeParentWithAncestorWithLocName));
            }

            using var scope = _clientDiagnostics.CreateScope("FakeParentWithAncestorWithLocCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _fakeParentWithAncestorWithLocsRestClient.GetAsync(Id.SubscriptionId, Id.Name, fakeParentWithAncestorWithLocName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<FakeParentWithAncestorWithLoc>(null, response.GetRawResponse());
                return Response.FromValue(new FakeParentWithAncestorWithLoc(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="fakeParentWithAncestorWithLocName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fakeParentWithAncestorWithLocName"/> is null. </exception>
        public virtual Response<bool> Exists(string fakeParentWithAncestorWithLocName, CancellationToken cancellationToken = default)
        {
            if (fakeParentWithAncestorWithLocName == null)
            {
                throw new ArgumentNullException(nameof(fakeParentWithAncestorWithLocName));
            }

            using var scope = _clientDiagnostics.CreateScope("FakeParentWithAncestorWithLocCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(fakeParentWithAncestorWithLocName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="fakeParentWithAncestorWithLocName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="fakeParentWithAncestorWithLocName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string fakeParentWithAncestorWithLocName, CancellationToken cancellationToken = default)
        {
            if (fakeParentWithAncestorWithLocName == null)
            {
                throw new ArgumentNullException(nameof(fakeParentWithAncestorWithLocName));
            }

            using var scope = _clientDiagnostics.CreateScope("FakeParentWithAncestorWithLocCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(fakeParentWithAncestorWithLocName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}/fakeParentWithAncestorWithLocs
        /// ContextualPath: /subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}
        /// OperationId: FakeParentWithAncestorWithLocs_ListTest
        /// <summary> Lists all in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="FakeParentWithAncestorWithLoc" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<FakeParentWithAncestorWithLoc> GetAll(CancellationToken cancellationToken = default)
        {
            Page<FakeParentWithAncestorWithLoc> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FakeParentWithAncestorWithLocCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _fakeParentWithAncestorWithLocsRestClient.ListTest(Id.SubscriptionId, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new FakeParentWithAncestorWithLoc(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<FakeParentWithAncestorWithLoc> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FakeParentWithAncestorWithLocCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _fakeParentWithAncestorWithLocsRestClient.ListTestNextPage(nextLink, Id.SubscriptionId, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new FakeParentWithAncestorWithLoc(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}/fakeParentWithAncestorWithLocs
        /// ContextualPath: /subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}
        /// OperationId: FakeParentWithAncestorWithLocs_ListTest
        /// <summary> Lists all in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="FakeParentWithAncestorWithLoc" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<FakeParentWithAncestorWithLoc> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<FakeParentWithAncestorWithLoc>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FakeParentWithAncestorWithLocCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _fakeParentWithAncestorWithLocsRestClient.ListTestAsync(Id.SubscriptionId, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new FakeParentWithAncestorWithLoc(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<FakeParentWithAncestorWithLoc>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FakeParentWithAncestorWithLocCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _fakeParentWithAncestorWithLocsRestClient.ListTestNextPageAsync(nextLink, Id.SubscriptionId, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new FakeParentWithAncestorWithLoc(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<FakeParentWithAncestorWithLoc> IEnumerable<FakeParentWithAncestorWithLoc>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<FakeParentWithAncestorWithLoc> IAsyncEnumerable<FakeParentWithAncestorWithLoc>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, FakeParentWithAncestorWithLoc, FakeParentWithAncestorWithLocData> Construct() { }
    }
}
