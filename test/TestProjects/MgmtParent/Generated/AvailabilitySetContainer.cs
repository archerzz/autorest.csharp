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
using MgmtParent.Models;

namespace MgmtParent
{
    /// <summary> A class representing collection of AvailabilitySet and their operations over a ResourceGroup. </summary>
    public partial class AvailabilitySetContainer : ResourceContainerBase<AvailabilitySet, AvailabilitySetData>
    {
        /// <summary> Initializes a new instance of the <see cref="AvailabilitySetContainer"/> class for mocking. </summary>
        protected AvailabilitySetContainer()
        {
        }

        /// <summary> Initializes a new instance of AvailabilitySetContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal AvailabilitySetContainer(OperationsBase parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
        }

        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Represents the REST operations. </summary>
        private AvailabilitySetsRestOperations _restClient => new AvailabilitySetsRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroupOperations.ResourceType;

        // Container level operations.

        /// <summary> Create or update an availability set. </summary>
        /// <param name="availabilitySetName"> The name of the availability set. </param>
        /// <param name="parameters"> Parameters supplied to the Create Availability Set operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="availabilitySetName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual Response<AvailabilitySet> CreateOrUpdate(string availabilitySetName, AvailabilitySetData parameters, CancellationToken cancellationToken = default)
        {
            if (availabilitySetName == null)
            {
                throw new ArgumentNullException(nameof(availabilitySetName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("AvailabilitySetContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = StartCreateOrUpdate(availabilitySetName, parameters, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create or update an availability set. </summary>
        /// <param name="availabilitySetName"> The name of the availability set. </param>
        /// <param name="parameters"> Parameters supplied to the Create Availability Set operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="availabilitySetName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<Response<AvailabilitySet>> CreateOrUpdateAsync(string availabilitySetName, AvailabilitySetData parameters, CancellationToken cancellationToken = default)
        {
            if (availabilitySetName == null)
            {
                throw new ArgumentNullException(nameof(availabilitySetName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("AvailabilitySetContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = await StartCreateOrUpdateAsync(availabilitySetName, parameters, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create or update an availability set. </summary>
        /// <param name="availabilitySetName"> The name of the availability set. </param>
        /// <param name="parameters"> Parameters supplied to the Create Availability Set operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="availabilitySetName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual AvailabilitySetsCreateOrUpdateOperation StartCreateOrUpdate(string availabilitySetName, AvailabilitySetData parameters, CancellationToken cancellationToken = default)
        {
            if (availabilitySetName == null)
            {
                throw new ArgumentNullException(nameof(availabilitySetName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("AvailabilitySetContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.CreateOrUpdate(Id.ResourceGroupName, availabilitySetName, parameters, cancellationToken);
                return new AvailabilitySetsCreateOrUpdateOperation(Parent, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create or update an availability set. </summary>
        /// <param name="availabilitySetName"> The name of the availability set. </param>
        /// <param name="parameters"> Parameters supplied to the Create Availability Set operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="availabilitySetName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<AvailabilitySetsCreateOrUpdateOperation> StartCreateOrUpdateAsync(string availabilitySetName, AvailabilitySetData parameters, CancellationToken cancellationToken = default)
        {
            if (availabilitySetName == null)
            {
                throw new ArgumentNullException(nameof(availabilitySetName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("AvailabilitySetContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateOrUpdateAsync(Id.ResourceGroupName, availabilitySetName, parameters, cancellationToken).ConfigureAwait(false);
                return new AvailabilitySetsCreateOrUpdateOperation(Parent, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="availabilitySetName"> The name of the availability set. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<AvailabilitySet> Get(string availabilitySetName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AvailabilitySetContainer.Get");
            scope.Start();
            try
            {
                if (availabilitySetName == null)
                {
                    throw new ArgumentNullException(nameof(availabilitySetName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, availabilitySetName, cancellationToken: cancellationToken);
                return Response.FromValue(new AvailabilitySet(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="availabilitySetName"> The name of the availability set. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<AvailabilitySet>> GetAsync(string availabilitySetName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AvailabilitySetContainer.Get");
            scope.Start();
            try
            {
                if (availabilitySetName == null)
                {
                    throw new ArgumentNullException(nameof(availabilitySetName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, availabilitySetName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new AvailabilitySet(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="availabilitySetName"> The name of the availability set. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual AvailabilitySet TryGet(string availabilitySetName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AvailabilitySetContainer.TryGet");
            scope.Start();
            try
            {
                if (availabilitySetName == null)
                {
                    throw new ArgumentNullException(nameof(availabilitySetName));
                }

                return Get(availabilitySetName, cancellationToken: cancellationToken).Value;
            }
            catch (RequestFailedException e) when (e.Status == 404)
            {
                return null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="availabilitySetName"> The name of the availability set. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<AvailabilitySet> TryGetAsync(string availabilitySetName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AvailabilitySetContainer.TryGet");
            scope.Start();
            try
            {
                if (availabilitySetName == null)
                {
                    throw new ArgumentNullException(nameof(availabilitySetName));
                }

                return await GetAsync(availabilitySetName, cancellationToken: cancellationToken).ConfigureAwait(false);
            }
            catch (RequestFailedException e) when (e.Status == 404)
            {
                return null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="availabilitySetName"> The name of the availability set. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual bool CheckIfExists(string availabilitySetName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AvailabilitySetContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (availabilitySetName == null)
                {
                    throw new ArgumentNullException(nameof(availabilitySetName));
                }

                return TryGet(availabilitySetName, cancellationToken: cancellationToken) != null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="availabilitySetName"> The name of the availability set. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<bool> CheckIfExistsAsync(string availabilitySetName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AvailabilitySetContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (availabilitySetName == null)
                {
                    throw new ArgumentNullException(nameof(availabilitySetName));
                }

                return await TryGetAsync(availabilitySetName, cancellationToken: cancellationToken).ConfigureAwait(false) != null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all availability sets in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AvailabilitySet" /> that may take multiple service requests to iterate over. </returns>
        public Pageable<AvailabilitySet> GetAll(CancellationToken cancellationToken = default)
        {
            Page<AvailabilitySet> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AvailabilitySetContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAll(Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AvailabilitySet(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<AvailabilitySet> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AvailabilitySetContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAllNextPage(nextLink, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AvailabilitySet(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all availability sets in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AvailabilitySet" /> that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<AvailabilitySet> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<AvailabilitySet>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AvailabilitySetContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllAsync(Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AvailabilitySet(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<AvailabilitySet>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AvailabilitySetContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllNextPageAsync(nextLink, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AvailabilitySet(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="AvailabilitySet" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResourceExpanded> GetAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AvailabilitySetContainer.GetAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(AvailabilitySetOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="AvailabilitySet" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResourceExpanded> GetAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("AvailabilitySetContainer.GetAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(AvailabilitySetOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<ResourceIdentifier, AvailabilitySet, AvailabilitySetData> Construct() { }
    }
}
