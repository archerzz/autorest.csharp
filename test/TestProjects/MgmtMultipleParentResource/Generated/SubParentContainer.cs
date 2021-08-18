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
using Azure.ResourceManager.Resources;
using MgmtMultipleParentResource.Models;

namespace MgmtMultipleParentResource
{
    /// <summary> A class representing collection of SubParent and their operations over a Parent. </summary>
    public partial class SubParentContainer : ArmContainer
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly SubParentsRestOperations _restClient;

        /// <summary> Initializes a new instance of the <see cref="SubParentContainer"/> class for mocking. </summary>
        protected SubParentContainer()
        {
        }

        /// <summary> Initializes a new instance of SubParentContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal SubParentContainer(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new SubParentsRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => MgmtMultipleParentResource.Parent.ResourceType;

        // Container level operations.

        /// <summary> The operation to create or update the VMSS VM run command. </summary>
        /// <param name="instanceId"> The instance ID of the virtual machine. </param>
        /// <param name="subBody"> Parameters supplied to the Create Virtual Machine RunCommand operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceId"/> or <paramref name="subBody"/> is null. </exception>
        public virtual Response<SubParent> CreateOrUpdate(string instanceId, SubParentData subBody, CancellationToken cancellationToken = default)
        {
            if (instanceId == null)
            {
                throw new ArgumentNullException(nameof(instanceId));
            }
            if (subBody == null)
            {
                throw new ArgumentNullException(nameof(subBody));
            }

            using var scope = _clientDiagnostics.CreateScope("SubParentContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = StartCreateOrUpdate(instanceId, subBody, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update the VMSS VM run command. </summary>
        /// <param name="instanceId"> The instance ID of the virtual machine. </param>
        /// <param name="subBody"> Parameters supplied to the Create Virtual Machine RunCommand operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceId"/> or <paramref name="subBody"/> is null. </exception>
        public async virtual Task<Response<SubParent>> CreateOrUpdateAsync(string instanceId, SubParentData subBody, CancellationToken cancellationToken = default)
        {
            if (instanceId == null)
            {
                throw new ArgumentNullException(nameof(instanceId));
            }
            if (subBody == null)
            {
                throw new ArgumentNullException(nameof(subBody));
            }

            using var scope = _clientDiagnostics.CreateScope("SubParentContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = await StartCreateOrUpdateAsync(instanceId, subBody, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update the VMSS VM run command. </summary>
        /// <param name="instanceId"> The instance ID of the virtual machine. </param>
        /// <param name="subBody"> Parameters supplied to the Create Virtual Machine RunCommand operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceId"/> or <paramref name="subBody"/> is null. </exception>
        public virtual SubParentCreateOrUpdateOperation StartCreateOrUpdate(string instanceId, SubParentData subBody, CancellationToken cancellationToken = default)
        {
            if (instanceId == null)
            {
                throw new ArgumentNullException(nameof(instanceId));
            }
            if (subBody == null)
            {
                throw new ArgumentNullException(nameof(subBody));
            }

            using var scope = _clientDiagnostics.CreateScope("SubParentContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.CreateOrUpdate(Id.ResourceGroupName, Id.Name, instanceId, subBody, cancellationToken);
                return new SubParentCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, Id.Name, instanceId, subBody).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to create or update the VMSS VM run command. </summary>
        /// <param name="instanceId"> The instance ID of the virtual machine. </param>
        /// <param name="subBody"> Parameters supplied to the Create Virtual Machine RunCommand operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceId"/> or <paramref name="subBody"/> is null. </exception>
        public async virtual Task<SubParentCreateOrUpdateOperation> StartCreateOrUpdateAsync(string instanceId, SubParentData subBody, CancellationToken cancellationToken = default)
        {
            if (instanceId == null)
            {
                throw new ArgumentNullException(nameof(instanceId));
            }
            if (subBody == null)
            {
                throw new ArgumentNullException(nameof(subBody));
            }

            using var scope = _clientDiagnostics.CreateScope("SubParentContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateOrUpdateAsync(Id.ResourceGroupName, Id.Name, instanceId, subBody, cancellationToken).ConfigureAwait(false);
                return new SubParentCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, Id.Name, instanceId, subBody).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="instanceId"> The instance ID of the virtual machine. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<SubParent> Get(string instanceId, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SubParentContainer.Get");
            scope.Start();
            try
            {
                if (instanceId == null)
                {
                    throw new ArgumentNullException(nameof(instanceId));
                }

                var response = _restClient.Get(Id.ResourceGroupName, Id.Name, instanceId, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SubParent(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="instanceId"> The instance ID of the virtual machine. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<SubParent>> GetAsync(string instanceId, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SubParentContainer.Get");
            scope.Start();
            try
            {
                if (instanceId == null)
                {
                    throw new ArgumentNullException(nameof(instanceId));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Name, instanceId, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SubParent(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="instanceId"> The instance ID of the virtual machine. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<SubParent> GetIfExists(string instanceId, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SubParentContainer.GetIfExists");
            scope.Start();
            try
            {
                if (instanceId == null)
                {
                    throw new ArgumentNullException(nameof(instanceId));
                }

                var response = _restClient.Get(Id.ResourceGroupName, Id.Name, instanceId, expand, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<SubParent>(null, response.GetRawResponse())
                    : Response.FromValue(new SubParent(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="instanceId"> The instance ID of the virtual machine. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<SubParent>> GetIfExistsAsync(string instanceId, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SubParentContainer.GetIfExists");
            scope.Start();
            try
            {
                if (instanceId == null)
                {
                    throw new ArgumentNullException(nameof(instanceId));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Name, instanceId, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<SubParent>(null, response.GetRawResponse())
                    : Response.FromValue(new SubParent(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="instanceId"> The instance ID of the virtual machine. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<bool> CheckIfExists(string instanceId, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SubParentContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (instanceId == null)
                {
                    throw new ArgumentNullException(nameof(instanceId));
                }

                var response = GetIfExists(instanceId, expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="instanceId"> The instance ID of the virtual machine. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string instanceId, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SubParentContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (instanceId == null)
                {
                    throw new ArgumentNullException(nameof(instanceId));
                }

                var response = await GetIfExistsAsync(instanceId, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to get all run commands of an instance in Virtual Machine Scaleset. </summary>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SubParent" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SubParent> GetAll(string expand = null, CancellationToken cancellationToken = default)
        {
            Page<SubParent> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SubParentContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAll(Id.ResourceGroupName, Id.Name, expand, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SubParent(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SubParent> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SubParentContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAllNextPage(nextLink, Id.ResourceGroupName, Id.Name, expand, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SubParent(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> The operation to get all run commands of an instance in Virtual Machine Scaleset. </summary>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SubParent" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SubParent> GetAllAsync(string expand = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<SubParent>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SubParentContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllAsync(Id.ResourceGroupName, Id.Name, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SubParent(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SubParent>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SubParentContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllNextPageAsync(nextLink, Id.ResourceGroupName, Id.Name, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SubParent(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="SubParent" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SubParentContainer.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(SubParent.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="SubParent" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SubParentContainer.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(SubParent.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to delete the VMSS VM run command. </summary>
        /// <param name="instanceId"> The instance ID of the virtual machine. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceId"/> is null. </exception>
        public async virtual Task<Response> DeleteAsync(string instanceId, CancellationToken cancellationToken = default)
        {
            if (instanceId == null)
            {
                throw new ArgumentNullException(nameof(instanceId));
            }

            using var scope = _clientDiagnostics.CreateScope("SubParentContainer.Delete");
            scope.Start();
            try
            {
                var operation = await StartDeleteAsync(instanceId, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to delete the VMSS VM run command. </summary>
        /// <param name="instanceId"> The instance ID of the virtual machine. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceId"/> is null. </exception>
        public virtual Response Delete(string instanceId, CancellationToken cancellationToken = default)
        {
            if (instanceId == null)
            {
                throw new ArgumentNullException(nameof(instanceId));
            }

            using var scope = _clientDiagnostics.CreateScope("SubParentContainer.Delete");
            scope.Start();
            try
            {
                var operation = StartDelete(instanceId, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to delete the VMSS VM run command. </summary>
        /// <param name="instanceId"> The instance ID of the virtual machine. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceId"/> is null. </exception>
        public async virtual Task<SubParentDeleteOperation> StartDeleteAsync(string instanceId, CancellationToken cancellationToken = default)
        {
            if (instanceId == null)
            {
                throw new ArgumentNullException(nameof(instanceId));
            }

            using var scope = _clientDiagnostics.CreateScope("SubParentContainer.StartDelete");
            scope.Start();
            try
            {
                var response = await _restClient.DeleteAsync(Id.ResourceGroupName, Id.Name, instanceId, cancellationToken).ConfigureAwait(false);
                return new SubParentDeleteOperation(_clientDiagnostics, Pipeline, _restClient.CreateDeleteRequest(Id.ResourceGroupName, Id.Name, instanceId).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> The operation to delete the VMSS VM run command. </summary>
        /// <param name="instanceId"> The instance ID of the virtual machine. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="instanceId"/> is null. </exception>
        public virtual SubParentDeleteOperation StartDelete(string instanceId, CancellationToken cancellationToken = default)
        {
            if (instanceId == null)
            {
                throw new ArgumentNullException(nameof(instanceId));
            }

            using var scope = _clientDiagnostics.CreateScope("SubParentContainer.StartDelete");
            scope.Start();
            try
            {
                var response = _restClient.Delete(Id.ResourceGroupName, Id.Name, instanceId, cancellationToken);
                return new SubParentDeleteOperation(_clientDiagnostics, Pipeline, _restClient.CreateDeleteRequest(Id.ResourceGroupName, Id.Name, instanceId).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<ResourceIdentifier, SubParent, SubParentData> Construct() { }
    }
}
