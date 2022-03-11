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

namespace MgmtLRO
{
    /// <summary> A class representing collection of Fake and their operations over its parent. </summary>
    public partial class FakeCollection : ArmCollection, IEnumerable<FakeResource>, IAsyncEnumerable<FakeResource>
    {
        private readonly ClientDiagnostics _fakeResourceFakesClientDiagnostics;
        private readonly FakesRestOperations _fakeResourceFakesRestClient;

        /// <summary> Initializes a new instance of the <see cref="FakeCollection"/> class for mocking. </summary>
        protected FakeCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="FakeCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal FakeCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _fakeResourceFakesClientDiagnostics = new ClientDiagnostics("MgmtLRO", FakeResource.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(FakeResource.ResourceType, out string fakeResourceFakesApiVersion);
            _fakeResourceFakesRestClient = new FakesRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, fakeResourceFakesApiVersion);
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
        /// Create or update an fake.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Fake/fakes/{fakeName}
        /// Operation Id: Fakes_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="fakeName"> The name of the fake. </param>
        /// <param name="parameters"> Parameters supplied to the Create Availability Set operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fakeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fakeName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual async Task<ArmOperation<FakeResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string fakeName, FakeData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fakeName, nameof(fakeName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _fakeResourceFakesClientDiagnostics.CreateScope("FakeCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _fakeResourceFakesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, fakeName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new MgmtLROArmOperation<FakeResource>(new FakeResourceOperationSource(Client), _fakeResourceFakesClientDiagnostics, Pipeline, _fakeResourceFakesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, fakeName, parameters).Request, response, OperationFinalStateVia.Location);
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
        /// Create or update an fake.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Fake/fakes/{fakeName}
        /// Operation Id: Fakes_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="fakeName"> The name of the fake. </param>
        /// <param name="parameters"> Parameters supplied to the Create Availability Set operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fakeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fakeName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<FakeResource> CreateOrUpdate(WaitUntil waitUntil, string fakeName, FakeData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fakeName, nameof(fakeName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _fakeResourceFakesClientDiagnostics.CreateScope("FakeCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _fakeResourceFakesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, fakeName, parameters, cancellationToken);
                var operation = new MgmtLROArmOperation<FakeResource>(new FakeResourceOperationSource(Client), _fakeResourceFakesClientDiagnostics, Pipeline, _fakeResourceFakesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, fakeName, parameters).Request, response, OperationFinalStateVia.Location);
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
        /// Retrieves information about an fake.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Fake/fakes/{fakeName}
        /// Operation Id: Fakes_Get
        /// </summary>
        /// <param name="fakeName"> The name of the fake. </param>
        /// <param name="expand"> May be used to expand the participants. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fakeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fakeName"/> is null. </exception>
        public virtual async Task<Response<FakeResource>> GetAsync(string fakeName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fakeName, nameof(fakeName));

            using var scope = _fakeResourceFakesClientDiagnostics.CreateScope("FakeCollection.Get");
            scope.Start();
            try
            {
                var response = await _fakeResourceFakesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, fakeName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FakeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves information about an fake.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Fake/fakes/{fakeName}
        /// Operation Id: Fakes_Get
        /// </summary>
        /// <param name="fakeName"> The name of the fake. </param>
        /// <param name="expand"> May be used to expand the participants. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fakeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fakeName"/> is null. </exception>
        public virtual Response<FakeResource> Get(string fakeName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fakeName, nameof(fakeName));

            using var scope = _fakeResourceFakesClientDiagnostics.CreateScope("FakeCollection.Get");
            scope.Start();
            try
            {
                var response = _fakeResourceFakesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, fakeName, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FakeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all fakes in a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Fake/fakes
        /// Operation Id: Fakes_List
        /// </summary>
        /// <param name="optionalParam"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="FakeResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<FakeResource> GetAllAsync(string optionalParam = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<FakeResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _fakeResourceFakesClientDiagnostics.CreateScope("FakeCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _fakeResourceFakesRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, optionalParam, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new FakeResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Lists all fakes in a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Fake/fakes
        /// Operation Id: Fakes_List
        /// </summary>
        /// <param name="optionalParam"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="FakeResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<FakeResource> GetAll(string optionalParam = null, CancellationToken cancellationToken = default)
        {
            Page<FakeResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _fakeResourceFakesClientDiagnostics.CreateScope("FakeCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _fakeResourceFakesRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, optionalParam, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new FakeResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Fake/fakes/{fakeName}
        /// Operation Id: Fakes_Get
        /// </summary>
        /// <param name="fakeName"> The name of the fake. </param>
        /// <param name="expand"> May be used to expand the participants. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fakeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fakeName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string fakeName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fakeName, nameof(fakeName));

            using var scope = _fakeResourceFakesClientDiagnostics.CreateScope("FakeCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(fakeName, expand: expand, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Fake/fakes/{fakeName}
        /// Operation Id: Fakes_Get
        /// </summary>
        /// <param name="fakeName"> The name of the fake. </param>
        /// <param name="expand"> May be used to expand the participants. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fakeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fakeName"/> is null. </exception>
        public virtual Response<bool> Exists(string fakeName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fakeName, nameof(fakeName));

            using var scope = _fakeResourceFakesClientDiagnostics.CreateScope("FakeCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(fakeName, expand: expand, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Fake/fakes/{fakeName}
        /// Operation Id: Fakes_Get
        /// </summary>
        /// <param name="fakeName"> The name of the fake. </param>
        /// <param name="expand"> May be used to expand the participants. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fakeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fakeName"/> is null. </exception>
        public virtual async Task<Response<FakeResource>> GetIfExistsAsync(string fakeName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fakeName, nameof(fakeName));

            using var scope = _fakeResourceFakesClientDiagnostics.CreateScope("FakeCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _fakeResourceFakesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, fakeName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<FakeResource>(null, response.GetRawResponse());
                return Response.FromValue(new FakeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Fake/fakes/{fakeName}
        /// Operation Id: Fakes_Get
        /// </summary>
        /// <param name="fakeName"> The name of the fake. </param>
        /// <param name="expand"> May be used to expand the participants. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="fakeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="fakeName"/> is null. </exception>
        public virtual Response<FakeResource> GetIfExists(string fakeName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(fakeName, nameof(fakeName));

            using var scope = _fakeResourceFakesClientDiagnostics.CreateScope("FakeCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _fakeResourceFakesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, fakeName, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<FakeResource>(null, response.GetRawResponse());
                return Response.FromValue(new FakeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<FakeResource> IEnumerable<FakeResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<FakeResource> IAsyncEnumerable<FakeResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
