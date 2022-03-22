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

namespace MgmtOperations
{
    /// <summary> A class representing collection of AvailabilitySetChild and their operations over its parent. </summary>
    public partial class AvailabilitySetChildCollection : ArmCollection, IEnumerable<AvailabilitySetChildResource>, IAsyncEnumerable<AvailabilitySetChildResource>
    {
        private readonly ClientDiagnostics _availabilitySetChildavailabilitySetChildClientDiagnostics;
        private readonly AvailabilitySetChildRestOperations _availabilitySetChildavailabilitySetChildRestClient;

        /// <summary> Initializes a new instance of the <see cref="AvailabilitySetChildCollection"/> class for mocking. </summary>
        protected AvailabilitySetChildCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AvailabilitySetChildCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal AvailabilitySetChildCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _availabilitySetChildavailabilitySetChildClientDiagnostics = new ClientDiagnostics("MgmtOperations", AvailabilitySetChildResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(AvailabilitySetChildResource.ResourceType, out string availabilitySetChildavailabilitySetChildApiVersion);
            _availabilitySetChildavailabilitySetChildRestClient = new AvailabilitySetChildRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, availabilitySetChildavailabilitySetChildApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != AvailabilitySetResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, AvailabilitySetResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update an availability set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/availabilitySets/{availabilitySetName}/availabilitySetChildren/{availabilitySetChildName}
        /// Operation Id: availabilitySetChild_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="availabilitySetChildName"> The name of the availability set child. </param>
        /// <param name="parameters"> Parameters supplied to the Create Availability Set operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="availabilitySetChildName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="availabilitySetChildName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual async Task<ArmOperation<AvailabilitySetChildResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string availabilitySetChildName, AvailabilitySetChildData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(availabilitySetChildName, nameof(availabilitySetChildName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _availabilitySetChildavailabilitySetChildClientDiagnostics.CreateScope("AvailabilitySetChildCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _availabilitySetChildavailabilitySetChildRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, availabilitySetChildName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new MgmtOperationsArmOperation<AvailabilitySetChildResource>(Response.FromValue(new AvailabilitySetChildResource(Client, response), response.GetRawResponse()));
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
        /// Create or update an availability set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/availabilitySets/{availabilitySetName}/availabilitySetChildren/{availabilitySetChildName}
        /// Operation Id: availabilitySetChild_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="availabilitySetChildName"> The name of the availability set child. </param>
        /// <param name="parameters"> Parameters supplied to the Create Availability Set operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="availabilitySetChildName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="availabilitySetChildName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<AvailabilitySetChildResource> CreateOrUpdate(WaitUntil waitUntil, string availabilitySetChildName, AvailabilitySetChildData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(availabilitySetChildName, nameof(availabilitySetChildName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _availabilitySetChildavailabilitySetChildClientDiagnostics.CreateScope("AvailabilitySetChildCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _availabilitySetChildavailabilitySetChildRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, availabilitySetChildName, parameters, cancellationToken);
                var operation = new MgmtOperationsArmOperation<AvailabilitySetChildResource>(Response.FromValue(new AvailabilitySetChildResource(Client, response), response.GetRawResponse()));
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
        /// Retrieves information about an availability set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/availabilitySets/{availabilitySetName}/availabilitySetChildren/{availabilitySetChildName}
        /// Operation Id: availabilitySetChild_Get
        /// </summary>
        /// <param name="availabilitySetChildName"> The name of the availability set child. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="availabilitySetChildName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="availabilitySetChildName"/> is null. </exception>
        public virtual async Task<Response<AvailabilitySetChildResource>> GetAsync(string availabilitySetChildName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(availabilitySetChildName, nameof(availabilitySetChildName));

            using var scope = _availabilitySetChildavailabilitySetChildClientDiagnostics.CreateScope("AvailabilitySetChildCollection.Get");
            scope.Start();
            try
            {
                var response = await _availabilitySetChildavailabilitySetChildRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, availabilitySetChildName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AvailabilitySetChildResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves information about an availability set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/availabilitySets/{availabilitySetName}/availabilitySetChildren/{availabilitySetChildName}
        /// Operation Id: availabilitySetChild_Get
        /// </summary>
        /// <param name="availabilitySetChildName"> The name of the availability set child. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="availabilitySetChildName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="availabilitySetChildName"/> is null. </exception>
        public virtual Response<AvailabilitySetChildResource> Get(string availabilitySetChildName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(availabilitySetChildName, nameof(availabilitySetChildName));

            using var scope = _availabilitySetChildavailabilitySetChildClientDiagnostics.CreateScope("AvailabilitySetChildCollection.Get");
            scope.Start();
            try
            {
                var response = _availabilitySetChildavailabilitySetChildRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, availabilitySetChildName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AvailabilitySetChildResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves information about an availability set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/availabilitySets/{availabilitySetName}/availabilitySetChildren
        /// Operation Id: availabilitySetChild_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AvailabilitySetChildResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AvailabilitySetChildResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<AvailabilitySetChildResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _availabilitySetChildavailabilitySetChildClientDiagnostics.CreateScope("AvailabilitySetChildCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _availabilitySetChildavailabilitySetChildRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AvailabilitySetChildResource(Client, value)), null, response.GetRawResponse());
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
        /// Retrieves information about an availability set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/availabilitySets/{availabilitySetName}/availabilitySetChildren
        /// Operation Id: availabilitySetChild_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AvailabilitySetChildResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AvailabilitySetChildResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<AvailabilitySetChildResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _availabilitySetChildavailabilitySetChildClientDiagnostics.CreateScope("AvailabilitySetChildCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _availabilitySetChildavailabilitySetChildRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AvailabilitySetChildResource(Client, value)), null, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/availabilitySets/{availabilitySetName}/availabilitySetChildren/{availabilitySetChildName}
        /// Operation Id: availabilitySetChild_Get
        /// </summary>
        /// <param name="availabilitySetChildName"> The name of the availability set child. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="availabilitySetChildName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="availabilitySetChildName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string availabilitySetChildName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(availabilitySetChildName, nameof(availabilitySetChildName));

            using var scope = _availabilitySetChildavailabilitySetChildClientDiagnostics.CreateScope("AvailabilitySetChildCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(availabilitySetChildName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/availabilitySets/{availabilitySetName}/availabilitySetChildren/{availabilitySetChildName}
        /// Operation Id: availabilitySetChild_Get
        /// </summary>
        /// <param name="availabilitySetChildName"> The name of the availability set child. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="availabilitySetChildName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="availabilitySetChildName"/> is null. </exception>
        public virtual Response<bool> Exists(string availabilitySetChildName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(availabilitySetChildName, nameof(availabilitySetChildName));

            using var scope = _availabilitySetChildavailabilitySetChildClientDiagnostics.CreateScope("AvailabilitySetChildCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(availabilitySetChildName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/availabilitySets/{availabilitySetName}/availabilitySetChildren/{availabilitySetChildName}
        /// Operation Id: availabilitySetChild_Get
        /// </summary>
        /// <param name="availabilitySetChildName"> The name of the availability set child. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="availabilitySetChildName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="availabilitySetChildName"/> is null. </exception>
        public virtual async Task<Response<AvailabilitySetChildResource>> GetIfExistsAsync(string availabilitySetChildName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(availabilitySetChildName, nameof(availabilitySetChildName));

            using var scope = _availabilitySetChildavailabilitySetChildClientDiagnostics.CreateScope("AvailabilitySetChildCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _availabilitySetChildavailabilitySetChildRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, availabilitySetChildName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<AvailabilitySetChildResource>(null, response.GetRawResponse());
                return Response.FromValue(new AvailabilitySetChildResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/availabilitySets/{availabilitySetName}/availabilitySetChildren/{availabilitySetChildName}
        /// Operation Id: availabilitySetChild_Get
        /// </summary>
        /// <param name="availabilitySetChildName"> The name of the availability set child. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="availabilitySetChildName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="availabilitySetChildName"/> is null. </exception>
        public virtual Response<AvailabilitySetChildResource> GetIfExists(string availabilitySetChildName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(availabilitySetChildName, nameof(availabilitySetChildName));

            using var scope = _availabilitySetChildavailabilitySetChildClientDiagnostics.CreateScope("AvailabilitySetChildCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _availabilitySetChildavailabilitySetChildRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, availabilitySetChildName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<AvailabilitySetChildResource>(null, response.GetRawResponse());
                return Response.FromValue(new AvailabilitySetChildResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<AvailabilitySetChildResource> IEnumerable<AvailabilitySetChildResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AvailabilitySetChildResource> IAsyncEnumerable<AvailabilitySetChildResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
