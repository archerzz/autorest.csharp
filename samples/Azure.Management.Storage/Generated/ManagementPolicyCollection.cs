// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.Management.Storage.Models;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;

namespace Azure.Management.Storage
{
    /// <summary> A class representing collection of ManagementPolicy and their operations over its parent. </summary>
    public partial class ManagementPolicyCollection : ArmCollection
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly ManagementPoliciesRestOperations _managementPoliciesRestClient;

        /// <summary> Initializes a new instance of the <see cref="ManagementPolicyCollection"/> class for mocking. </summary>
        protected ManagementPolicyCollection()
        {
        }

        /// <summary> Initializes a new instance of ManagementPolicyCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal ManagementPolicyCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _managementPoliciesRestClient = new ManagementPoliciesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => StorageAccount.ResourceType;

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/managementPolicies/{managementPolicyName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}
        /// OperationId: ManagementPolicies_CreateOrUpdate
        /// <summary> Sets the managementpolicy to the specified storage account. </summary>
        /// <param name="managementPolicyName"> The name of the Storage Account Management Policy. It should always be &apos;default&apos;. </param>
        /// <param name="properties"> The ManagementPolicy set to a storage account. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public virtual ManagementPolicyCreateOrUpdateOperation CreateOrUpdate(ManagementPolicyName managementPolicyName, ManagementPolicyData properties, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            using var scope = _clientDiagnostics.CreateScope("ManagementPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _managementPoliciesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, managementPolicyName, properties, cancellationToken);
                var operation = new ManagementPolicyCreateOrUpdateOperation(Parent, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/managementPolicies/{managementPolicyName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}
        /// OperationId: ManagementPolicies_CreateOrUpdate
        /// <summary> Sets the managementpolicy to the specified storage account. </summary>
        /// <param name="managementPolicyName"> The name of the Storage Account Management Policy. It should always be &apos;default&apos;. </param>
        /// <param name="properties"> The ManagementPolicy set to a storage account. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public async virtual Task<ManagementPolicyCreateOrUpdateOperation> CreateOrUpdateAsync(ManagementPolicyName managementPolicyName, ManagementPolicyData properties, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            using var scope = _clientDiagnostics.CreateScope("ManagementPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _managementPoliciesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, managementPolicyName, properties, cancellationToken).ConfigureAwait(false);
                var operation = new ManagementPolicyCreateOrUpdateOperation(Parent, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/managementPolicies/{managementPolicyName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}
        /// OperationId: ManagementPolicies_Get
        /// <summary> Gets the managementpolicy associated with the specified storage account. </summary>
        /// <param name="managementPolicyName"> The name of the Storage Account Management Policy. It should always be &apos;default&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ManagementPolicy> Get(ManagementPolicyName managementPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagementPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = _managementPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, managementPolicyName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagementPolicy(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/managementPolicies/{managementPolicyName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}
        /// OperationId: ManagementPolicies_Get
        /// <summary> Gets the managementpolicy associated with the specified storage account. </summary>
        /// <param name="managementPolicyName"> The name of the Storage Account Management Policy. It should always be &apos;default&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<ManagementPolicy>> GetAsync(ManagementPolicyName managementPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagementPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = await _managementPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, managementPolicyName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ManagementPolicy(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="managementPolicyName"> The name of the Storage Account Management Policy. It should always be &apos;default&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ManagementPolicy> GetIfExists(ManagementPolicyName managementPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagementPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _managementPoliciesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, managementPolicyName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<ManagementPolicy>(null, response.GetRawResponse())
                    : Response.FromValue(new ManagementPolicy(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="managementPolicyName"> The name of the Storage Account Management Policy. It should always be &apos;default&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<ManagementPolicy>> GetIfExistsAsync(ManagementPolicyName managementPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagementPolicyCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _managementPoliciesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, managementPolicyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<ManagementPolicy>(null, response.GetRawResponse())
                    : Response.FromValue(new ManagementPolicy(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="managementPolicyName"> The name of the Storage Account Management Policy. It should always be &apos;default&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(ManagementPolicyName managementPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagementPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(managementPolicyName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="managementPolicyName"> The name of the Storage Account Management Policy. It should always be &apos;default&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<bool>> ExistsAsync(ManagementPolicyName managementPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagementPolicyCollection.ExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(managementPolicyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/managementPolicies/{managementPolicyName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}
        /// OperationId: ManagementPolicies_Delete
        /// <summary> Deletes the managementpolicy associated with the specified storage account. </summary>
        /// <param name="managementPolicyName"> The name of the Storage Account Management Policy. It should always be &apos;default&apos;. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ManagementPolicyDeleteOperation Delete(ManagementPolicyName managementPolicyName, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagementPolicyCollection.Delete");
            scope.Start();
            try
            {
                var response = _managementPoliciesRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, managementPolicyName, cancellationToken);
                var operation = new ManagementPolicyDeleteOperation(response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}/managementPolicies/{managementPolicyName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}
        /// OperationId: ManagementPolicies_Delete
        /// <summary> Deletes the managementpolicy associated with the specified storage account. </summary>
        /// <param name="managementPolicyName"> The name of the Storage Account Management Policy. It should always be &apos;default&apos;. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<ManagementPolicyDeleteOperation> DeleteAsync(ManagementPolicyName managementPolicyName, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagementPolicyCollection.Delete");
            scope.Start();
            try
            {
                var response = await _managementPoliciesRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, managementPolicyName, cancellationToken).ConfigureAwait(false);
                var operation = new ManagementPolicyDeleteOperation(response);
                if (waitForCompletion)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, ManagementPolicy, ManagementPolicyData> Construct() { }
    }
}
