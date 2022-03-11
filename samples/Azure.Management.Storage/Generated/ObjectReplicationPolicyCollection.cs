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

namespace Azure.Management.Storage
{
    /// <summary> A class representing collection of ObjectReplicationPolicy and their operations over its parent. </summary>
    public partial class ObjectReplicationPolicyCollection : ArmCollection, IEnumerable<ObjectReplicationPolicyResource>, IAsyncEnumerable<ObjectReplicationPolicyResource>
    {
        private readonly ClientDiagnostics _objectReplicationPolicyResourceObjectReplicationPoliciesClientDiagnostics;
        private readonly ObjectReplicationPoliciesRestOperations _objectReplicationPolicyResourceObjectReplicationPoliciesRestClient;

        /// <summary> Initializes a new instance of the <see cref="ObjectReplicationPolicyCollection"/> class for mocking. </summary>
        protected ObjectReplicationPolicyCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ObjectReplicationPolicyCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ObjectReplicationPolicyCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _objectReplicationPolicyResourceObjectReplicationPoliciesClientDiagnostics = new ClientDiagnostics("Azure.Management.Storage", ObjectReplicationPolicyResource.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ObjectReplicationPolicyResource.ResourceType, out string objectReplicationPolicyResourceObjectReplicationPoliciesApiVersion);
            _objectReplicationPolicyResourceObjectReplicationPoliciesRestClient = new ObjectReplicationPoliciesRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, objectReplicationPolicyResourceObjectReplicationPoliciesApiVersion);
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
        /// Create or update the object replication policy of the storage account.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/objectReplicationPolicies/{objectReplicationPolicyId}
        /// Operation Id: ObjectReplicationPolicies_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="objectReplicationPolicyId"> For the destination account, provide the value &apos;default&apos;. Configure the policy on the destination account first. For the source account, provide the value of the policy ID that is returned when you download the policy that was defined on the destination account. The policy is downloaded as a JSON file. </param>
        /// <param name="properties"> The object replication policy set to a storage account. A unique policy ID will be created if absent. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="objectReplicationPolicyId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="objectReplicationPolicyId"/> or <paramref name="properties"/> is null. </exception>
        public virtual async Task<ArmOperation<ObjectReplicationPolicyResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string objectReplicationPolicyId, ObjectReplicationPolicyData properties, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(objectReplicationPolicyId, nameof(objectReplicationPolicyId));
            Argument.AssertNotNull(properties, nameof(properties));

            using var scope = _objectReplicationPolicyResourceObjectReplicationPoliciesClientDiagnostics.CreateScope("ObjectReplicationPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _objectReplicationPolicyResourceObjectReplicationPoliciesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, objectReplicationPolicyId, properties, cancellationToken).ConfigureAwait(false);
                var operation = new StorageArmOperation<ObjectReplicationPolicyResource>(Response.FromValue(new ObjectReplicationPolicyResource(Client, response), response.GetRawResponse()));
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
        /// Create or update the object replication policy of the storage account.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/objectReplicationPolicies/{objectReplicationPolicyId}
        /// Operation Id: ObjectReplicationPolicies_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="objectReplicationPolicyId"> For the destination account, provide the value &apos;default&apos;. Configure the policy on the destination account first. For the source account, provide the value of the policy ID that is returned when you download the policy that was defined on the destination account. The policy is downloaded as a JSON file. </param>
        /// <param name="properties"> The object replication policy set to a storage account. A unique policy ID will be created if absent. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="objectReplicationPolicyId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="objectReplicationPolicyId"/> or <paramref name="properties"/> is null. </exception>
        public virtual ArmOperation<ObjectReplicationPolicyResource> CreateOrUpdate(WaitUntil waitUntil, string objectReplicationPolicyId, ObjectReplicationPolicyData properties, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(objectReplicationPolicyId, nameof(objectReplicationPolicyId));
            Argument.AssertNotNull(properties, nameof(properties));

            using var scope = _objectReplicationPolicyResourceObjectReplicationPoliciesClientDiagnostics.CreateScope("ObjectReplicationPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _objectReplicationPolicyResourceObjectReplicationPoliciesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, objectReplicationPolicyId, properties, cancellationToken);
                var operation = new StorageArmOperation<ObjectReplicationPolicyResource>(Response.FromValue(new ObjectReplicationPolicyResource(Client, response), response.GetRawResponse()));
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
        /// Get the object replication policy of the storage account by policy ID.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/objectReplicationPolicies/{objectReplicationPolicyId}
        /// Operation Id: ObjectReplicationPolicies_Get
        /// </summary>
        /// <param name="objectReplicationPolicyId"> For the destination account, provide the value &apos;default&apos;. Configure the policy on the destination account first. For the source account, provide the value of the policy ID that is returned when you download the policy that was defined on the destination account. The policy is downloaded as a JSON file. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="objectReplicationPolicyId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="objectReplicationPolicyId"/> is null. </exception>
        public virtual async Task<Response<ObjectReplicationPolicyResource>> GetAsync(string objectReplicationPolicyId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(objectReplicationPolicyId, nameof(objectReplicationPolicyId));

            using var scope = _objectReplicationPolicyResourceObjectReplicationPoliciesClientDiagnostics.CreateScope("ObjectReplicationPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = await _objectReplicationPolicyResourceObjectReplicationPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, objectReplicationPolicyId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ObjectReplicationPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the object replication policy of the storage account by policy ID.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/objectReplicationPolicies/{objectReplicationPolicyId}
        /// Operation Id: ObjectReplicationPolicies_Get
        /// </summary>
        /// <param name="objectReplicationPolicyId"> For the destination account, provide the value &apos;default&apos;. Configure the policy on the destination account first. For the source account, provide the value of the policy ID that is returned when you download the policy that was defined on the destination account. The policy is downloaded as a JSON file. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="objectReplicationPolicyId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="objectReplicationPolicyId"/> is null. </exception>
        public virtual Response<ObjectReplicationPolicyResource> Get(string objectReplicationPolicyId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(objectReplicationPolicyId, nameof(objectReplicationPolicyId));

            using var scope = _objectReplicationPolicyResourceObjectReplicationPoliciesClientDiagnostics.CreateScope("ObjectReplicationPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = _objectReplicationPolicyResourceObjectReplicationPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, objectReplicationPolicyId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ObjectReplicationPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List the object replication policies associated with the storage account.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/objectReplicationPolicies
        /// Operation Id: ObjectReplicationPolicies_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ObjectReplicationPolicyResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ObjectReplicationPolicyResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ObjectReplicationPolicyResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _objectReplicationPolicyResourceObjectReplicationPoliciesClientDiagnostics.CreateScope("ObjectReplicationPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _objectReplicationPolicyResourceObjectReplicationPoliciesRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ObjectReplicationPolicyResource(Client, value)), null, response.GetRawResponse());
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
        /// List the object replication policies associated with the storage account.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/objectReplicationPolicies
        /// Operation Id: ObjectReplicationPolicies_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ObjectReplicationPolicyResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ObjectReplicationPolicyResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ObjectReplicationPolicyResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _objectReplicationPolicyResourceObjectReplicationPoliciesClientDiagnostics.CreateScope("ObjectReplicationPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _objectReplicationPolicyResourceObjectReplicationPoliciesRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ObjectReplicationPolicyResource(Client, value)), null, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/objectReplicationPolicies/{objectReplicationPolicyId}
        /// Operation Id: ObjectReplicationPolicies_Get
        /// </summary>
        /// <param name="objectReplicationPolicyId"> For the destination account, provide the value &apos;default&apos;. Configure the policy on the destination account first. For the source account, provide the value of the policy ID that is returned when you download the policy that was defined on the destination account. The policy is downloaded as a JSON file. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="objectReplicationPolicyId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="objectReplicationPolicyId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string objectReplicationPolicyId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(objectReplicationPolicyId, nameof(objectReplicationPolicyId));

            using var scope = _objectReplicationPolicyResourceObjectReplicationPoliciesClientDiagnostics.CreateScope("ObjectReplicationPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(objectReplicationPolicyId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/objectReplicationPolicies/{objectReplicationPolicyId}
        /// Operation Id: ObjectReplicationPolicies_Get
        /// </summary>
        /// <param name="objectReplicationPolicyId"> For the destination account, provide the value &apos;default&apos;. Configure the policy on the destination account first. For the source account, provide the value of the policy ID that is returned when you download the policy that was defined on the destination account. The policy is downloaded as a JSON file. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="objectReplicationPolicyId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="objectReplicationPolicyId"/> is null. </exception>
        public virtual Response<bool> Exists(string objectReplicationPolicyId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(objectReplicationPolicyId, nameof(objectReplicationPolicyId));

            using var scope = _objectReplicationPolicyResourceObjectReplicationPoliciesClientDiagnostics.CreateScope("ObjectReplicationPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(objectReplicationPolicyId, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/objectReplicationPolicies/{objectReplicationPolicyId}
        /// Operation Id: ObjectReplicationPolicies_Get
        /// </summary>
        /// <param name="objectReplicationPolicyId"> For the destination account, provide the value &apos;default&apos;. Configure the policy on the destination account first. For the source account, provide the value of the policy ID that is returned when you download the policy that was defined on the destination account. The policy is downloaded as a JSON file. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="objectReplicationPolicyId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="objectReplicationPolicyId"/> is null. </exception>
        public virtual async Task<Response<ObjectReplicationPolicyResource>> GetIfExistsAsync(string objectReplicationPolicyId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(objectReplicationPolicyId, nameof(objectReplicationPolicyId));

            using var scope = _objectReplicationPolicyResourceObjectReplicationPoliciesClientDiagnostics.CreateScope("ObjectReplicationPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _objectReplicationPolicyResourceObjectReplicationPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, objectReplicationPolicyId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<ObjectReplicationPolicyResource>(null, response.GetRawResponse());
                return Response.FromValue(new ObjectReplicationPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/objectReplicationPolicies/{objectReplicationPolicyId}
        /// Operation Id: ObjectReplicationPolicies_Get
        /// </summary>
        /// <param name="objectReplicationPolicyId"> For the destination account, provide the value &apos;default&apos;. Configure the policy on the destination account first. For the source account, provide the value of the policy ID that is returned when you download the policy that was defined on the destination account. The policy is downloaded as a JSON file. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="objectReplicationPolicyId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="objectReplicationPolicyId"/> is null. </exception>
        public virtual Response<ObjectReplicationPolicyResource> GetIfExists(string objectReplicationPolicyId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(objectReplicationPolicyId, nameof(objectReplicationPolicyId));

            using var scope = _objectReplicationPolicyResourceObjectReplicationPoliciesClientDiagnostics.CreateScope("ObjectReplicationPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _objectReplicationPolicyResourceObjectReplicationPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, objectReplicationPolicyId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<ObjectReplicationPolicyResource>(null, response.GetRawResponse());
                return Response.FromValue(new ObjectReplicationPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ObjectReplicationPolicyResource> IEnumerable<ObjectReplicationPolicyResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ObjectReplicationPolicyResource> IAsyncEnumerable<ObjectReplicationPolicyResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
