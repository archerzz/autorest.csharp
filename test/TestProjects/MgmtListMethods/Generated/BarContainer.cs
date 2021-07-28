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
using MgmtListMethods.Models;

namespace MgmtListMethods
{
    /// <summary> A class representing collection of Bar and their operations over a ResourceGroup. </summary>
    public partial class BarContainer : ResourceContainerBase<Bar, BarData>
    {
        /// <summary> Initializes a new instance of the <see cref="BarContainer"/> class for mocking. </summary>
        protected BarContainer()
        {
        }

        /// <summary> Initializes a new instance of BarContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal BarContainer(OperationsBase parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
        }

        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Represents the REST operations. </summary>
        private BarsRestOperations _restClient => new BarsRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroupOperations.ResourceType;

        // Container level operations.

        /// <summary> Retrieves information about an fake. </summary>
        /// <param name="barName"> The name of the fake. </param>
        /// <param name="body"> The body parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="barName"/> or <paramref name="body"/> is null. </exception>
        public virtual Response<Bar> CreateOrUpdate(string barName, BarData body, CancellationToken cancellationToken = default)
        {
            if (barName == null)
            {
                throw new ArgumentNullException(nameof(barName));
            }
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            using var scope = _clientDiagnostics.CreateScope("BarContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = StartCreateOrUpdate(barName, body, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves information about an fake. </summary>
        /// <param name="barName"> The name of the fake. </param>
        /// <param name="body"> The body parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="barName"/> or <paramref name="body"/> is null. </exception>
        public async virtual Task<Response<Bar>> CreateOrUpdateAsync(string barName, BarData body, CancellationToken cancellationToken = default)
        {
            if (barName == null)
            {
                throw new ArgumentNullException(nameof(barName));
            }
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            using var scope = _clientDiagnostics.CreateScope("BarContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = await StartCreateOrUpdateAsync(barName, body, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves information about an fake. </summary>
        /// <param name="barName"> The name of the fake. </param>
        /// <param name="body"> The body parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="barName"/> or <paramref name="body"/> is null. </exception>
        public virtual BarsCreateOrUpdateOperation StartCreateOrUpdate(string barName, BarData body, CancellationToken cancellationToken = default)
        {
            if (barName == null)
            {
                throw new ArgumentNullException(nameof(barName));
            }
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            using var scope = _clientDiagnostics.CreateScope("BarContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.CreateOrUpdate(Id.ResourceGroupName, barName, body, cancellationToken);
                return new BarsCreateOrUpdateOperation(Parent, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves information about an fake. </summary>
        /// <param name="barName"> The name of the fake. </param>
        /// <param name="body"> The body parameter. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="barName"/> or <paramref name="body"/> is null. </exception>
        public async virtual Task<BarsCreateOrUpdateOperation> StartCreateOrUpdateAsync(string barName, BarData body, CancellationToken cancellationToken = default)
        {
            if (barName == null)
            {
                throw new ArgumentNullException(nameof(barName));
            }
            if (body == null)
            {
                throw new ArgumentNullException(nameof(body));
            }

            using var scope = _clientDiagnostics.CreateScope("BarContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateOrUpdateAsync(Id.ResourceGroupName, barName, body, cancellationToken).ConfigureAwait(false);
                return new BarsCreateOrUpdateOperation(Parent, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="barName"> The name of the fake. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<Bar> Get(string barName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BarContainer.Get");
            scope.Start();
            try
            {
                if (barName == null)
                {
                    throw new ArgumentNullException(nameof(barName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, barName, cancellationToken: cancellationToken);
                return Response.FromValue(new Bar(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="barName"> The name of the fake. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<Bar>> GetAsync(string barName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BarContainer.Get");
            scope.Start();
            try
            {
                if (barName == null)
                {
                    throw new ArgumentNullException(nameof(barName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, barName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new Bar(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="barName"> The name of the fake. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Bar TryGet(string barName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BarContainer.TryGet");
            scope.Start();
            try
            {
                if (barName == null)
                {
                    throw new ArgumentNullException(nameof(barName));
                }

                return Get(barName, cancellationToken: cancellationToken).Value;
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
        /// <param name="barName"> The name of the fake. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Bar> TryGetAsync(string barName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BarContainer.TryGet");
            scope.Start();
            try
            {
                if (barName == null)
                {
                    throw new ArgumentNullException(nameof(barName));
                }

                return await GetAsync(barName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <param name="barName"> The name of the fake. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual bool CheckIfExists(string barName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BarContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (barName == null)
                {
                    throw new ArgumentNullException(nameof(barName));
                }

                return TryGet(barName, cancellationToken: cancellationToken) != null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="barName"> The name of the fake. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<bool> CheckIfExistsAsync(string barName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BarContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (barName == null)
                {
                    throw new ArgumentNullException(nameof(barName));
                }

                return await TryGetAsync(barName, cancellationToken: cancellationToken).ConfigureAwait(false) != null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves information about an fake. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="Bar" /> that may take multiple service requests to iterate over. </returns>
        public Pageable<Bar> GetAll(CancellationToken cancellationToken = default)
        {
            Page<Bar> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("BarContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetBars(Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new Bar(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<Bar> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("BarContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetBarsNextPage(nextLink, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new Bar(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Retrieves information about an fake. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="Bar" /> that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<Bar> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<Bar>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("BarContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetBarsAsync(Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new Bar(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<Bar>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("BarContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetBarsNextPageAsync(nextLink, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new Bar(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="Bar" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResourceExpanded> GetAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BarContainer.GetAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(BarOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="Bar" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResourceExpanded> GetAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BarContainer.GetAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(BarOperations.ResourceType);
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
        // public ArmBuilder<ResourceIdentifier, Bar, BarData> Construct() { }
    }
}
