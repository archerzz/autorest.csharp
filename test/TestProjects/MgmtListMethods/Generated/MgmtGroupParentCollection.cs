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
using Azure.ResourceManager.Management;
using MgmtListMethods.Models;

namespace MgmtListMethods
{
    /// <summary> A class representing collection of MgmtGroupParent and their operations over its parent. </summary>
    public partial class MgmtGroupParentCollection : ArmCollection, IEnumerable<MgmtGroupParent>, IAsyncEnumerable<MgmtGroupParent>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly MgmtGroupParentsRestOperations _mgmtGroupParentsRestClient;

        /// <summary> Initializes a new instance of the <see cref="MgmtGroupParentCollection"/> class for mocking. </summary>
        protected MgmtGroupParentCollection()
        {
        }

        /// <summary> Initializes a new instance of MgmtGroupParentCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal MgmtGroupParentCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _mgmtGroupParentsRestClient = new MgmtGroupParentsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ManagementGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ManagementGroup.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// RequestPath: /providers/Microsoft.Management/managementGroups/{groupId}/mgmtGroupParents/{mgmtGroupParentName}
        /// ContextualPath: /providers/Microsoft.Management/managementGroups/{managementGroupId}
        /// OperationId: MgmtGroupParents_CreateOrUpdate
        /// <summary> Create or update. </summary>
        /// <param name="mgmtGroupParentName"> Name. </param>
        /// <param name="parameters"> Parameters supplied to the Create. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="mgmtGroupParentName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual MgmtGroupParentCreateOrUpdateOperation CreateOrUpdate(string mgmtGroupParentName, MgmtGroupParentData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (mgmtGroupParentName == null)
            {
                throw new ArgumentNullException(nameof(mgmtGroupParentName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("MgmtGroupParentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _mgmtGroupParentsRestClient.CreateOrUpdate(Id.Name, mgmtGroupParentName, parameters, cancellationToken);
                var operation = new MgmtGroupParentCreateOrUpdateOperation(Parent, response);
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

        /// RequestPath: /providers/Microsoft.Management/managementGroups/{groupId}/mgmtGroupParents/{mgmtGroupParentName}
        /// ContextualPath: /providers/Microsoft.Management/managementGroups/{managementGroupId}
        /// OperationId: MgmtGroupParents_CreateOrUpdate
        /// <summary> Create or update. </summary>
        /// <param name="mgmtGroupParentName"> Name. </param>
        /// <param name="parameters"> Parameters supplied to the Create. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="mgmtGroupParentName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<MgmtGroupParentCreateOrUpdateOperation> CreateOrUpdateAsync(string mgmtGroupParentName, MgmtGroupParentData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (mgmtGroupParentName == null)
            {
                throw new ArgumentNullException(nameof(mgmtGroupParentName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("MgmtGroupParentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _mgmtGroupParentsRestClient.CreateOrUpdateAsync(Id.Name, mgmtGroupParentName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new MgmtGroupParentCreateOrUpdateOperation(Parent, response);
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

        /// RequestPath: /providers/Microsoft.Management/managementGroups/{groupId}/mgmtGroupParents/{mgmtGroupParentName}
        /// ContextualPath: /providers/Microsoft.Management/managementGroups/{managementGroupId}
        /// OperationId: MgmtGroupParents_Get
        /// <summary> Retrieves information. </summary>
        /// <param name="mgmtGroupParentName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="mgmtGroupParentName"/> is null. </exception>
        public virtual Response<MgmtGroupParent> Get(string mgmtGroupParentName, CancellationToken cancellationToken = default)
        {
            if (mgmtGroupParentName == null)
            {
                throw new ArgumentNullException(nameof(mgmtGroupParentName));
            }

            using var scope = _clientDiagnostics.CreateScope("MgmtGroupParentCollection.Get");
            scope.Start();
            try
            {
                var response = _mgmtGroupParentsRestClient.Get(Id.Name, mgmtGroupParentName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MgmtGroupParent(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /providers/Microsoft.Management/managementGroups/{groupId}/mgmtGroupParents/{mgmtGroupParentName}
        /// ContextualPath: /providers/Microsoft.Management/managementGroups/{managementGroupId}
        /// OperationId: MgmtGroupParents_Get
        /// <summary> Retrieves information. </summary>
        /// <param name="mgmtGroupParentName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="mgmtGroupParentName"/> is null. </exception>
        public async virtual Task<Response<MgmtGroupParent>> GetAsync(string mgmtGroupParentName, CancellationToken cancellationToken = default)
        {
            if (mgmtGroupParentName == null)
            {
                throw new ArgumentNullException(nameof(mgmtGroupParentName));
            }

            using var scope = _clientDiagnostics.CreateScope("MgmtGroupParentCollection.Get");
            scope.Start();
            try
            {
                var response = await _mgmtGroupParentsRestClient.GetAsync(Id.Name, mgmtGroupParentName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new MgmtGroupParent(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="mgmtGroupParentName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="mgmtGroupParentName"/> is null. </exception>
        public virtual Response<MgmtGroupParent> GetIfExists(string mgmtGroupParentName, CancellationToken cancellationToken = default)
        {
            if (mgmtGroupParentName == null)
            {
                throw new ArgumentNullException(nameof(mgmtGroupParentName));
            }

            using var scope = _clientDiagnostics.CreateScope("MgmtGroupParentCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _mgmtGroupParentsRestClient.Get(Id.Name, mgmtGroupParentName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<MgmtGroupParent>(null, response.GetRawResponse())
                    : Response.FromValue(new MgmtGroupParent(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="mgmtGroupParentName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="mgmtGroupParentName"/> is null. </exception>
        public async virtual Task<Response<MgmtGroupParent>> GetIfExistsAsync(string mgmtGroupParentName, CancellationToken cancellationToken = default)
        {
            if (mgmtGroupParentName == null)
            {
                throw new ArgumentNullException(nameof(mgmtGroupParentName));
            }

            using var scope = _clientDiagnostics.CreateScope("MgmtGroupParentCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _mgmtGroupParentsRestClient.GetAsync(Id.Name, mgmtGroupParentName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<MgmtGroupParent>(null, response.GetRawResponse())
                    : Response.FromValue(new MgmtGroupParent(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="mgmtGroupParentName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="mgmtGroupParentName"/> is null. </exception>
        public virtual Response<bool> Exists(string mgmtGroupParentName, CancellationToken cancellationToken = default)
        {
            if (mgmtGroupParentName == null)
            {
                throw new ArgumentNullException(nameof(mgmtGroupParentName));
            }

            using var scope = _clientDiagnostics.CreateScope("MgmtGroupParentCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(mgmtGroupParentName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="mgmtGroupParentName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="mgmtGroupParentName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string mgmtGroupParentName, CancellationToken cancellationToken = default)
        {
            if (mgmtGroupParentName == null)
            {
                throw new ArgumentNullException(nameof(mgmtGroupParentName));
            }

            using var scope = _clientDiagnostics.CreateScope("MgmtGroupParentCollection.ExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(mgmtGroupParentName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /providers/Microsoft.Management/managementGroups/{groupId}/mgmtGroupParents
        /// ContextualPath: /providers/Microsoft.Management/managementGroups/{managementGroupId}
        /// OperationId: MgmtGroupParents_List
        /// <summary> Lists all in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MgmtGroupParent" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MgmtGroupParent> GetAll(CancellationToken cancellationToken = default)
        {
            Page<MgmtGroupParent> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("MgmtGroupParentCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _mgmtGroupParentsRestClient.List(Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new MgmtGroupParent(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<MgmtGroupParent> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("MgmtGroupParentCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _mgmtGroupParentsRestClient.ListNextPage(nextLink, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new MgmtGroupParent(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /providers/Microsoft.Management/managementGroups/{groupId}/mgmtGroupParents
        /// ContextualPath: /providers/Microsoft.Management/managementGroups/{managementGroupId}
        /// OperationId: MgmtGroupParents_List
        /// <summary> Lists all in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MgmtGroupParent" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MgmtGroupParent> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<MgmtGroupParent>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("MgmtGroupParentCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _mgmtGroupParentsRestClient.ListAsync(Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new MgmtGroupParent(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<MgmtGroupParent>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("MgmtGroupParentCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _mgmtGroupParentsRestClient.ListNextPageAsync(nextLink, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new MgmtGroupParent(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<MgmtGroupParent> IEnumerable<MgmtGroupParent>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<MgmtGroupParent> IAsyncEnumerable<MgmtGroupParent>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, MgmtGroupParent, MgmtGroupParentData> Construct() { }
    }
}
