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
using Azure.Management.Storage.Models;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;

namespace Azure.Management.Storage
{
    /// <summary> A class representing collection of BlobInventoryPolicy and their operations over its parent. </summary>
    public partial class BlobInventoryPolicyCollection : ArmCollection, IEnumerable<BlobInventoryPolicyResource>, IAsyncEnumerable<BlobInventoryPolicyResource>
    {
        private readonly ClientDiagnostics _blobInventoryPolicyResourceBlobInventoryPoliciesClientDiagnostics;
        private readonly BlobInventoryPoliciesRestOperations _blobInventoryPolicyResourceBlobInventoryPoliciesRestClient;

        /// <summary> Initializes a new instance of the <see cref="BlobInventoryPolicyCollection"/> class for mocking. </summary>
        protected BlobInventoryPolicyCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="BlobInventoryPolicyCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal BlobInventoryPolicyCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _blobInventoryPolicyResourceBlobInventoryPoliciesClientDiagnostics = new ClientDiagnostics("Azure.Management.Storage", BlobInventoryPolicyResource.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(BlobInventoryPolicyResource.ResourceType, out string blobInventoryPolicyResourceBlobInventoryPoliciesApiVersion);
            _blobInventoryPolicyResourceBlobInventoryPoliciesRestClient = new BlobInventoryPoliciesRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, blobInventoryPolicyResourceBlobInventoryPoliciesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != StorageAccountResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, StorageAccountResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Sets the blob inventory policy to the specified storage account.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/inventoryPolicies/{blobInventoryPolicyName}
        /// Operation Id: BlobInventoryPolicies_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="blobInventoryPolicyName"> The name of the storage account blob inventory policy. It should always be &apos;default&apos;. </param>
        /// <param name="properties"> The blob inventory policy set to a storage account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public virtual async Task<ArmOperation<BlobInventoryPolicyResource>> CreateOrUpdateAsync(WaitUntil waitUntil, BlobInventoryPolicyName blobInventoryPolicyName, BlobInventoryPolicyData properties, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(properties, nameof(properties));

            using var scope = _blobInventoryPolicyResourceBlobInventoryPoliciesClientDiagnostics.CreateScope("BlobInventoryPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _blobInventoryPolicyResourceBlobInventoryPoliciesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, blobInventoryPolicyName, properties, cancellationToken).ConfigureAwait(false);
                var operation = new StorageArmOperation<BlobInventoryPolicyResource>(Response.FromValue(new BlobInventoryPolicyResource(Client, response), response.GetRawResponse()));
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
        /// Sets the blob inventory policy to the specified storage account.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/inventoryPolicies/{blobInventoryPolicyName}
        /// Operation Id: BlobInventoryPolicies_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="blobInventoryPolicyName"> The name of the storage account blob inventory policy. It should always be &apos;default&apos;. </param>
        /// <param name="properties"> The blob inventory policy set to a storage account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public virtual ArmOperation<BlobInventoryPolicyResource> CreateOrUpdate(WaitUntil waitUntil, BlobInventoryPolicyName blobInventoryPolicyName, BlobInventoryPolicyData properties, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(properties, nameof(properties));

            using var scope = _blobInventoryPolicyResourceBlobInventoryPoliciesClientDiagnostics.CreateScope("BlobInventoryPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _blobInventoryPolicyResourceBlobInventoryPoliciesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, blobInventoryPolicyName, properties, cancellationToken);
                var operation = new StorageArmOperation<BlobInventoryPolicyResource>(Response.FromValue(new BlobInventoryPolicyResource(Client, response), response.GetRawResponse()));
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
        /// Gets the blob inventory policy associated with the specified storage account.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/inventoryPolicies/{blobInventoryPolicyName}
        /// Operation Id: BlobInventoryPolicies_Get
        /// </summary>
        /// <param name="blobInventoryPolicyName"> The name of the storage account blob inventory policy. It should always be &apos;default&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<BlobInventoryPolicyResource>> GetAsync(BlobInventoryPolicyName blobInventoryPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _blobInventoryPolicyResourceBlobInventoryPoliciesClientDiagnostics.CreateScope("BlobInventoryPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = await _blobInventoryPolicyResourceBlobInventoryPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, blobInventoryPolicyName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BlobInventoryPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the blob inventory policy associated with the specified storage account.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/inventoryPolicies/{blobInventoryPolicyName}
        /// Operation Id: BlobInventoryPolicies_Get
        /// </summary>
        /// <param name="blobInventoryPolicyName"> The name of the storage account blob inventory policy. It should always be &apos;default&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<BlobInventoryPolicyResource> Get(BlobInventoryPolicyName blobInventoryPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _blobInventoryPolicyResourceBlobInventoryPoliciesClientDiagnostics.CreateScope("BlobInventoryPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = _blobInventoryPolicyResourceBlobInventoryPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, blobInventoryPolicyName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BlobInventoryPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the blob inventory policy associated with the specified storage account.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/inventoryPolicies
        /// Operation Id: BlobInventoryPolicies_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="BlobInventoryPolicyResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<BlobInventoryPolicyResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<BlobInventoryPolicyResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _blobInventoryPolicyResourceBlobInventoryPoliciesClientDiagnostics.CreateScope("BlobInventoryPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _blobInventoryPolicyResourceBlobInventoryPoliciesRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new BlobInventoryPolicyResource(Client, value)), null, response.GetRawResponse());
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
        /// Gets the blob inventory policy associated with the specified storage account.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/inventoryPolicies
        /// Operation Id: BlobInventoryPolicies_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="BlobInventoryPolicyResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<BlobInventoryPolicyResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<BlobInventoryPolicyResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _blobInventoryPolicyResourceBlobInventoryPoliciesClientDiagnostics.CreateScope("BlobInventoryPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _blobInventoryPolicyResourceBlobInventoryPoliciesRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new BlobInventoryPolicyResource(Client, value)), null, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/inventoryPolicies/{blobInventoryPolicyName}
        /// Operation Id: BlobInventoryPolicies_Get
        /// </summary>
        /// <param name="blobInventoryPolicyName"> The name of the storage account blob inventory policy. It should always be &apos;default&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(BlobInventoryPolicyName blobInventoryPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _blobInventoryPolicyResourceBlobInventoryPoliciesClientDiagnostics.CreateScope("BlobInventoryPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(blobInventoryPolicyName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/inventoryPolicies/{blobInventoryPolicyName}
        /// Operation Id: BlobInventoryPolicies_Get
        /// </summary>
        /// <param name="blobInventoryPolicyName"> The name of the storage account blob inventory policy. It should always be &apos;default&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(BlobInventoryPolicyName blobInventoryPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _blobInventoryPolicyResourceBlobInventoryPoliciesClientDiagnostics.CreateScope("BlobInventoryPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(blobInventoryPolicyName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/inventoryPolicies/{blobInventoryPolicyName}
        /// Operation Id: BlobInventoryPolicies_Get
        /// </summary>
        /// <param name="blobInventoryPolicyName"> The name of the storage account blob inventory policy. It should always be &apos;default&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<BlobInventoryPolicyResource>> GetIfExistsAsync(BlobInventoryPolicyName blobInventoryPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _blobInventoryPolicyResourceBlobInventoryPoliciesClientDiagnostics.CreateScope("BlobInventoryPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _blobInventoryPolicyResourceBlobInventoryPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, blobInventoryPolicyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<BlobInventoryPolicyResource>(null, response.GetRawResponse());
                return Response.FromValue(new BlobInventoryPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/inventoryPolicies/{blobInventoryPolicyName}
        /// Operation Id: BlobInventoryPolicies_Get
        /// </summary>
        /// <param name="blobInventoryPolicyName"> The name of the storage account blob inventory policy. It should always be &apos;default&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<BlobInventoryPolicyResource> GetIfExists(BlobInventoryPolicyName blobInventoryPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _blobInventoryPolicyResourceBlobInventoryPoliciesClientDiagnostics.CreateScope("BlobInventoryPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _blobInventoryPolicyResourceBlobInventoryPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, blobInventoryPolicyName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<BlobInventoryPolicyResource>(null, response.GetRawResponse());
                return Response.FromValue(new BlobInventoryPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<BlobInventoryPolicyResource> IEnumerable<BlobInventoryPolicyResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<BlobInventoryPolicyResource> IAsyncEnumerable<BlobInventoryPolicyResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
