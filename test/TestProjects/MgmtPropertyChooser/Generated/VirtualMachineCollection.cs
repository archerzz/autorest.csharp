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

namespace MgmtPropertyChooser
{
    /// <summary> A class representing collection of VirtualMachine and their operations over its parent. </summary>
    public partial class VirtualMachineCollection : ArmCollection, IEnumerable<VirtualMachineResource>, IAsyncEnumerable<VirtualMachineResource>
    {
        private readonly ClientDiagnostics _virtualMachineResourceVirtualMachinesClientDiagnostics;
        private readonly VirtualMachinesRestOperations _virtualMachineResourceVirtualMachinesRestClient;

        /// <summary> Initializes a new instance of the <see cref="VirtualMachineCollection"/> class for mocking. </summary>
        protected VirtualMachineCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VirtualMachineCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal VirtualMachineCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _virtualMachineResourceVirtualMachinesClientDiagnostics = new ClientDiagnostics("MgmtPropertyChooser", VirtualMachineResource.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(VirtualMachineResource.ResourceType, out string virtualMachineResourceVirtualMachinesApiVersion);
            _virtualMachineResourceVirtualMachinesRestClient = new VirtualMachinesRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, virtualMachineResourceVirtualMachinesApiVersion);
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
        /// The operation to create or update a virtual machine. Please note some properties can be set only during virtual machine creation.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}
        /// Operation Id: VirtualMachines_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="vmName"> The name of the virtual machine. </param>
        /// <param name="parameters"> Parameters supplied to the Create Virtual Machine operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual async Task<ArmOperation<VirtualMachineResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string vmName, VirtualMachineData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmName, nameof(vmName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _virtualMachineResourceVirtualMachinesClientDiagnostics.CreateScope("VirtualMachineCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _virtualMachineResourceVirtualMachinesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, vmName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new MgmtPropertyChooserArmOperation<VirtualMachineResource>(new VirtualMachineResourceOperationSource(Client), _virtualMachineResourceVirtualMachinesClientDiagnostics, Pipeline, _virtualMachineResourceVirtualMachinesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, vmName, parameters).Request, response, OperationFinalStateVia.Location);
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
        /// The operation to create or update a virtual machine. Please note some properties can be set only during virtual machine creation.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}
        /// Operation Id: VirtualMachines_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="vmName"> The name of the virtual machine. </param>
        /// <param name="parameters"> Parameters supplied to the Create Virtual Machine operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<VirtualMachineResource> CreateOrUpdate(WaitUntil waitUntil, string vmName, VirtualMachineData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmName, nameof(vmName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _virtualMachineResourceVirtualMachinesClientDiagnostics.CreateScope("VirtualMachineCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _virtualMachineResourceVirtualMachinesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, vmName, parameters, cancellationToken);
                var operation = new MgmtPropertyChooserArmOperation<VirtualMachineResource>(new VirtualMachineResourceOperationSource(Client), _virtualMachineResourceVirtualMachinesClientDiagnostics, Pipeline, _virtualMachineResourceVirtualMachinesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, vmName, parameters).Request, response, OperationFinalStateVia.Location);
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
        /// Retrieves information about the model view or the instance view of a virtual machine.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}
        /// Operation Id: VirtualMachines_Get
        /// </summary>
        /// <param name="vmName"> The name of the virtual machine. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmName"/> is null. </exception>
        public virtual async Task<Response<VirtualMachineResource>> GetAsync(string vmName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmName, nameof(vmName));

            using var scope = _virtualMachineResourceVirtualMachinesClientDiagnostics.CreateScope("VirtualMachineCollection.Get");
            scope.Start();
            try
            {
                var response = await _virtualMachineResourceVirtualMachinesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, vmName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualMachineResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves information about the model view or the instance view of a virtual machine.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}
        /// Operation Id: VirtualMachines_Get
        /// </summary>
        /// <param name="vmName"> The name of the virtual machine. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmName"/> is null. </exception>
        public virtual Response<VirtualMachineResource> Get(string vmName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmName, nameof(vmName));

            using var scope = _virtualMachineResourceVirtualMachinesClientDiagnostics.CreateScope("VirtualMachineCollection.Get");
            scope.Start();
            try
            {
                var response = _virtualMachineResourceVirtualMachinesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, vmName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualMachineResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves information about the model view or the instance view of a virtual machine.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines
        /// Operation Id: VirtualMachines_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VirtualMachineResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VirtualMachineResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<VirtualMachineResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _virtualMachineResourceVirtualMachinesClientDiagnostics.CreateScope("VirtualMachineCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _virtualMachineResourceVirtualMachinesRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualMachineResource(Client, value)), null, response.GetRawResponse());
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
        /// Retrieves information about the model view or the instance view of a virtual machine.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines
        /// Operation Id: VirtualMachines_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VirtualMachineResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VirtualMachineResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<VirtualMachineResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _virtualMachineResourceVirtualMachinesClientDiagnostics.CreateScope("VirtualMachineCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _virtualMachineResourceVirtualMachinesRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualMachineResource(Client, value)), null, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}
        /// Operation Id: VirtualMachines_Get
        /// </summary>
        /// <param name="vmName"> The name of the virtual machine. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string vmName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmName, nameof(vmName));

            using var scope = _virtualMachineResourceVirtualMachinesClientDiagnostics.CreateScope("VirtualMachineCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(vmName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}
        /// Operation Id: VirtualMachines_Get
        /// </summary>
        /// <param name="vmName"> The name of the virtual machine. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmName"/> is null. </exception>
        public virtual Response<bool> Exists(string vmName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmName, nameof(vmName));

            using var scope = _virtualMachineResourceVirtualMachinesClientDiagnostics.CreateScope("VirtualMachineCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(vmName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}
        /// Operation Id: VirtualMachines_Get
        /// </summary>
        /// <param name="vmName"> The name of the virtual machine. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmName"/> is null. </exception>
        public virtual async Task<Response<VirtualMachineResource>> GetIfExistsAsync(string vmName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmName, nameof(vmName));

            using var scope = _virtualMachineResourceVirtualMachinesClientDiagnostics.CreateScope("VirtualMachineCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _virtualMachineResourceVirtualMachinesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, vmName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<VirtualMachineResource>(null, response.GetRawResponse());
                return Response.FromValue(new VirtualMachineResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}
        /// Operation Id: VirtualMachines_Get
        /// </summary>
        /// <param name="vmName"> The name of the virtual machine. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmName"/> is null. </exception>
        public virtual Response<VirtualMachineResource> GetIfExists(string vmName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(vmName, nameof(vmName));

            using var scope = _virtualMachineResourceVirtualMachinesClientDiagnostics.CreateScope("VirtualMachineCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _virtualMachineResourceVirtualMachinesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, vmName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<VirtualMachineResource>(null, response.GetRawResponse());
                return Response.FromValue(new VirtualMachineResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<VirtualMachineResource> IEnumerable<VirtualMachineResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VirtualMachineResource> IAsyncEnumerable<VirtualMachineResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
