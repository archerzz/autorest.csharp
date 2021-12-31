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
using MgmtScopeResource.Models;

namespace MgmtScopeResource
{
    /// <summary> A class representing collection of ResourceLink and their operations over its parent. </summary>
    public partial class ResourceLinkCollection : ArmCollection
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly ResourceLinksRestOperations _resourceLinksRestClient;

        /// <summary> Initializes a new instance of the <see cref="ResourceLinkCollection"/> class for mocking. </summary>
        protected ResourceLinkCollection()
        {
        }

        /// <summary> Initializes a new instance of ResourceLinkCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal ResourceLinkCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _resourceLinksRestClient = new ResourceLinksRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => Tenant.ResourceType;

        // Collection level operations.

        /// RequestPath: /{linkId}
        /// ContextualPath: /
        /// OperationId: ResourceLinks_CreateOrUpdate
        /// <summary> Creates or updates a resource link between the specified resources. </summary>
        /// <param name="linkId"> The fully qualified ID of the resource link. Use the format, /subscriptions/{subscription-id}/resourceGroups/{resource-group-name}/{provider-namespace}/{resource-type}/{resource-name}/Microsoft.Resources/links/{link-name}. For example, /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myGroup/Microsoft.Web/sites/mySite/Microsoft.Resources/links/myLink. </param>
        /// <param name="parameters"> Parameters for creating or updating a resource link. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="linkId"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ResourceLinkCreateOrUpdateOperation CreateOrUpdate(ResourceIdentifier linkId, ResourceLinkData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (linkId == null)
            {
                throw new ArgumentNullException(nameof(linkId));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ResourceLinkCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _resourceLinksRestClient.CreateOrUpdate(linkId, parameters, cancellationToken);
                var operation = new ResourceLinkCreateOrUpdateOperation(Parent, response);
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

        /// RequestPath: /{linkId}
        /// ContextualPath: /
        /// OperationId: ResourceLinks_CreateOrUpdate
        /// <summary> Creates or updates a resource link between the specified resources. </summary>
        /// <param name="linkId"> The fully qualified ID of the resource link. Use the format, /subscriptions/{subscription-id}/resourceGroups/{resource-group-name}/{provider-namespace}/{resource-type}/{resource-name}/Microsoft.Resources/links/{link-name}. For example, /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myGroup/Microsoft.Web/sites/mySite/Microsoft.Resources/links/myLink. </param>
        /// <param name="parameters"> Parameters for creating or updating a resource link. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="linkId"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ResourceLinkCreateOrUpdateOperation> CreateOrUpdateAsync(ResourceIdentifier linkId, ResourceLinkData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (linkId == null)
            {
                throw new ArgumentNullException(nameof(linkId));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ResourceLinkCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _resourceLinksRestClient.CreateOrUpdateAsync(linkId, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new ResourceLinkCreateOrUpdateOperation(Parent, response);
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

        /// RequestPath: /{linkId}
        /// ContextualPath: /
        /// OperationId: ResourceLinks_Get
        /// <summary> Gets a resource link with the specified ID. </summary>
        /// <param name="linkId"> The fully qualified Id of the resource link. For example, /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myGroup/Microsoft.Web/sites/mySite/Microsoft.Resources/links/myLink. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="linkId"/> is null. </exception>
        public virtual Response<ResourceLink> Get(ResourceIdentifier linkId, CancellationToken cancellationToken = default)
        {
            if (linkId == null)
            {
                throw new ArgumentNullException(nameof(linkId));
            }

            using var scope = _clientDiagnostics.CreateScope("ResourceLinkCollection.Get");
            scope.Start();
            try
            {
                var response = _resourceLinksRestClient.Get(linkId, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ResourceLink(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /{linkId}
        /// ContextualPath: /
        /// OperationId: ResourceLinks_Get
        /// <summary> Gets a resource link with the specified ID. </summary>
        /// <param name="linkId"> The fully qualified Id of the resource link. For example, /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myGroup/Microsoft.Web/sites/mySite/Microsoft.Resources/links/myLink. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="linkId"/> is null. </exception>
        public async virtual Task<Response<ResourceLink>> GetAsync(ResourceIdentifier linkId, CancellationToken cancellationToken = default)
        {
            if (linkId == null)
            {
                throw new ArgumentNullException(nameof(linkId));
            }

            using var scope = _clientDiagnostics.CreateScope("ResourceLinkCollection.Get");
            scope.Start();
            try
            {
                var response = await _resourceLinksRestClient.GetAsync(linkId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ResourceLink(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="linkId"> The fully qualified Id of the resource link. For example, /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myGroup/Microsoft.Web/sites/mySite/Microsoft.Resources/links/myLink. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="linkId"/> is null. </exception>
        public virtual Response<ResourceLink> GetIfExists(ResourceIdentifier linkId, CancellationToken cancellationToken = default)
        {
            if (linkId == null)
            {
                throw new ArgumentNullException(nameof(linkId));
            }

            using var scope = _clientDiagnostics.CreateScope("ResourceLinkCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _resourceLinksRestClient.Get(linkId, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<ResourceLink>(null, response.GetRawResponse())
                    : Response.FromValue(new ResourceLink(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="linkId"> The fully qualified Id of the resource link. For example, /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myGroup/Microsoft.Web/sites/mySite/Microsoft.Resources/links/myLink. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="linkId"/> is null. </exception>
        public async virtual Task<Response<ResourceLink>> GetIfExistsAsync(ResourceIdentifier linkId, CancellationToken cancellationToken = default)
        {
            if (linkId == null)
            {
                throw new ArgumentNullException(nameof(linkId));
            }

            using var scope = _clientDiagnostics.CreateScope("ResourceLinkCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _resourceLinksRestClient.GetAsync(linkId, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<ResourceLink>(null, response.GetRawResponse())
                    : Response.FromValue(new ResourceLink(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="linkId"> The fully qualified Id of the resource link. For example, /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myGroup/Microsoft.Web/sites/mySite/Microsoft.Resources/links/myLink. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="linkId"/> is null. </exception>
        public virtual Response<bool> Exists(ResourceIdentifier linkId, CancellationToken cancellationToken = default)
        {
            if (linkId == null)
            {
                throw new ArgumentNullException(nameof(linkId));
            }

            using var scope = _clientDiagnostics.CreateScope("ResourceLinkCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(linkId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="linkId"> The fully qualified Id of the resource link. For example, /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myGroup/Microsoft.Web/sites/mySite/Microsoft.Resources/links/myLink. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="linkId"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(ResourceIdentifier linkId, CancellationToken cancellationToken = default)
        {
            if (linkId == null)
            {
                throw new ArgumentNullException(nameof(linkId));
            }

            using var scope = _clientDiagnostics.CreateScope("ResourceLinkCollection.ExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(linkId, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /{linkId}
        /// ContextualPath: /
        /// OperationId: ResourceLinks_Delete
        /// <summary> Deletes a resource link with the specified ID. </summary>
        /// <param name="linkId"> The fully qualified ID of the resource link. Use the format, /subscriptions/{subscription-id}/resourceGroups/{resource-group-name}/{provider-namespace}/{resource-type}/{resource-name}/Microsoft.Resources/links/{link-name}. For example, /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myGroup/Microsoft.Web/sites/mySite/Microsoft.Resources/links/myLink. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="linkId"/> is null. </exception>
        public virtual ResourceLinkDeleteOperation Delete(ResourceIdentifier linkId, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (linkId == null)
            {
                throw new ArgumentNullException(nameof(linkId));
            }

            using var scope = _clientDiagnostics.CreateScope("ResourceLinkCollection.Delete");
            scope.Start();
            try
            {
                var response = _resourceLinksRestClient.Delete(linkId, cancellationToken);
                var operation = new ResourceLinkDeleteOperation(response);
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

        /// RequestPath: /{linkId}
        /// ContextualPath: /
        /// OperationId: ResourceLinks_Delete
        /// <summary> Deletes a resource link with the specified ID. </summary>
        /// <param name="linkId"> The fully qualified ID of the resource link. Use the format, /subscriptions/{subscription-id}/resourceGroups/{resource-group-name}/{provider-namespace}/{resource-type}/{resource-name}/Microsoft.Resources/links/{link-name}. For example, /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myGroup/Microsoft.Web/sites/mySite/Microsoft.Resources/links/myLink. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="linkId"/> is null. </exception>
        public async virtual Task<ResourceLinkDeleteOperation> DeleteAsync(ResourceIdentifier linkId, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (linkId == null)
            {
                throw new ArgumentNullException(nameof(linkId));
            }

            using var scope = _clientDiagnostics.CreateScope("ResourceLinkCollection.Delete");
            scope.Start();
            try
            {
                var response = await _resourceLinksRestClient.DeleteAsync(linkId, cancellationToken).ConfigureAwait(false);
                var operation = new ResourceLinkDeleteOperation(response);
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

        /// RequestPath: /{scope}/providers/Microsoft.Resources/links
        /// ContextualPath: /
        /// OperationId: ResourceLinks_ListAtSourceScope
        /// <summary> Gets a list of resource links at and below the specified source scope. </summary>
        /// <param name="scope"> The fully qualified ID of the scope for getting the resource links. For example, to list resource links at and under a resource group, set the scope to /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myGroup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ResourceLink" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ResourceLink> GetAll(string scope, CancellationToken cancellationToken = default)
        {
            if (scope == null)
            {
                throw new ArgumentNullException(nameof(scope));
            }

            Page<ResourceLink> FirstPageFunc(int? pageSizeHint)
            {
                using var scope0 = _clientDiagnostics.CreateScope("ResourceLinkCollection.GetAll");
                scope0.Start();
                try
                {
                    var response = _resourceLinksRestClient.ListAtSourceScope(scope, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ResourceLink(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope0.Failed(e);
                    throw;
                }
            }
            Page<ResourceLink> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope0 = _clientDiagnostics.CreateScope("ResourceLinkCollection.GetAll");
                scope0.Start();
                try
                {
                    var response = _resourceLinksRestClient.ListAtSourceScopeNextPage(nextLink, scope, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ResourceLink(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope0.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /{scope}/providers/Microsoft.Resources/links
        /// ContextualPath: /
        /// OperationId: ResourceLinks_ListAtSourceScope
        /// <summary> Gets a list of resource links at and below the specified source scope. </summary>
        /// <param name="scope"> The fully qualified ID of the scope for getting the resource links. For example, to list resource links at and under a resource group, set the scope to /subscriptions/00000000-0000-0000-0000-000000000000/resourceGroups/myGroup. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ResourceLink" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ResourceLink> GetAllAsync(string scope, CancellationToken cancellationToken = default)
        {
            if (scope == null)
            {
                throw new ArgumentNullException(nameof(scope));
            }

            async Task<Page<ResourceLink>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope0 = _clientDiagnostics.CreateScope("ResourceLinkCollection.GetAll");
                scope0.Start();
                try
                {
                    var response = await _resourceLinksRestClient.ListAtSourceScopeAsync(scope, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ResourceLink(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope0.Failed(e);
                    throw;
                }
            }
            async Task<Page<ResourceLink>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope0 = _clientDiagnostics.CreateScope("ResourceLinkCollection.GetAll");
                scope0.Start();
                try
                {
                    var response = await _resourceLinksRestClient.ListAtSourceScopeNextPageAsync(nextLink, scope, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ResourceLink(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope0.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, ResourceLink, ResourceLinkData> Construct() { }
    }
}
