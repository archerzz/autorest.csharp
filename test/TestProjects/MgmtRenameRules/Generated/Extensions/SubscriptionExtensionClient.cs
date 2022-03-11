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
using MgmtRenameRules.Models;

namespace MgmtRenameRules
{
    /// <summary> A class to add extension methods to Subscription. </summary>
    internal partial class SubscriptionExtensionClient : ArmResource
    {
        private ClientDiagnostics _virtualMachineResourceVirtualMachinesClientDiagnostics;
        private VirtualMachinesRestOperations _virtualMachineResourceVirtualMachinesRestClient;
        private ClientDiagnostics _imageResourceImagesClientDiagnostics;
        private ImagesRestOperations _imageResourceImagesRestClient;
        private ClientDiagnostics _virtualMachineScaleSetResourceVirtualMachineScaleSetsClientDiagnostics;
        private VirtualMachineScaleSetsRestOperations _virtualMachineScaleSetResourceVirtualMachineScaleSetsRestClient;
        private ClientDiagnostics _logAnalyticsClientDiagnostics;
        private LogAnalyticsRestOperations _logAnalyticsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionExtensionClient"/> class for mocking. </summary>
        protected SubscriptionExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SubscriptionExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics VirtualMachineResourceVirtualMachinesClientDiagnostics => _virtualMachineResourceVirtualMachinesClientDiagnostics ??= new ClientDiagnostics("MgmtRenameRules", VirtualMachineResource.ResourceType.Namespace, DiagnosticOptions);
        private VirtualMachinesRestOperations VirtualMachineResourceVirtualMachinesRestClient => _virtualMachineResourceVirtualMachinesRestClient ??= new VirtualMachinesRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, GetApiVersionOrNull(VirtualMachineResource.ResourceType));
        private ClientDiagnostics ImageResourceImagesClientDiagnostics => _imageResourceImagesClientDiagnostics ??= new ClientDiagnostics("MgmtRenameRules", ImageResource.ResourceType.Namespace, DiagnosticOptions);
        private ImagesRestOperations ImageResourceImagesRestClient => _imageResourceImagesRestClient ??= new ImagesRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, GetApiVersionOrNull(ImageResource.ResourceType));
        private ClientDiagnostics VirtualMachineScaleSetResourceVirtualMachineScaleSetsClientDiagnostics => _virtualMachineScaleSetResourceVirtualMachineScaleSetsClientDiagnostics ??= new ClientDiagnostics("MgmtRenameRules", VirtualMachineScaleSetResource.ResourceType.Namespace, DiagnosticOptions);
        private VirtualMachineScaleSetsRestOperations VirtualMachineScaleSetResourceVirtualMachineScaleSetsRestClient => _virtualMachineScaleSetResourceVirtualMachineScaleSetsRestClient ??= new VirtualMachineScaleSetsRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, GetApiVersionOrNull(VirtualMachineScaleSetResource.ResourceType));
        private ClientDiagnostics LogAnalyticsClientDiagnostics => _logAnalyticsClientDiagnostics ??= new ClientDiagnostics("MgmtRenameRules", ProviderConstants.DefaultProviderNamespace, DiagnosticOptions);
        private LogAnalyticsRestOperations LogAnalyticsRestClient => _logAnalyticsRestClient ??= new LogAnalyticsRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets all the virtual machines under the specified subscription for the specified location.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/virtualMachines
        /// Operation Id: VirtualMachines_ListByLocation
        /// </summary>
        /// <param name="location"> The location for which virtual machines under the subscription are queried. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VirtualMachineResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VirtualMachineResource> GetVirtualMachineResourcesByLocationAsync(string location, CancellationToken cancellationToken = default)
        {
            async Task<Page<VirtualMachineResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = VirtualMachineResourceVirtualMachinesClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetVirtualMachineResourcesByLocation");
                scope.Start();
                try
                {
                    var response = await VirtualMachineResourceVirtualMachinesRestClient.ListByLocationAsync(Id.SubscriptionId, location, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualMachineResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VirtualMachineResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = VirtualMachineResourceVirtualMachinesClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetVirtualMachineResourcesByLocation");
                scope.Start();
                try
                {
                    var response = await VirtualMachineResourceVirtualMachinesRestClient.ListByLocationNextPageAsync(nextLink, Id.SubscriptionId, location, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualMachineResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Gets all the virtual machines under the specified subscription for the specified location.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/virtualMachines
        /// Operation Id: VirtualMachines_ListByLocation
        /// </summary>
        /// <param name="location"> The location for which virtual machines under the subscription are queried. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VirtualMachineResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VirtualMachineResource> GetVirtualMachineResourcesByLocation(string location, CancellationToken cancellationToken = default)
        {
            Page<VirtualMachineResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = VirtualMachineResourceVirtualMachinesClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetVirtualMachineResourcesByLocation");
                scope.Start();
                try
                {
                    var response = VirtualMachineResourceVirtualMachinesRestClient.ListByLocation(Id.SubscriptionId, location, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualMachineResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VirtualMachineResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = VirtualMachineResourceVirtualMachinesClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetVirtualMachineResourcesByLocation");
                scope.Start();
                try
                {
                    var response = VirtualMachineResourceVirtualMachinesRestClient.ListByLocationNextPage(nextLink, Id.SubscriptionId, location, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualMachineResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Lists all of the virtual machines in the specified subscription. Use the nextLink property in the response to get the next page of virtual machines.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/virtualMachines
        /// Operation Id: VirtualMachines_ListAll
        /// </summary>
        /// <param name="statusOnly"> statusOnly=true enables fetching run time status of all Virtual Machines in the subscription. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VirtualMachineResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VirtualMachineResource> GetVirtualMachineResourcesAsync(string statusOnly = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<VirtualMachineResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = VirtualMachineResourceVirtualMachinesClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetVirtualMachineResources");
                scope.Start();
                try
                {
                    var response = await VirtualMachineResourceVirtualMachinesRestClient.ListAllAsync(Id.SubscriptionId, statusOnly, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualMachineResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VirtualMachineResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = VirtualMachineResourceVirtualMachinesClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetVirtualMachineResources");
                scope.Start();
                try
                {
                    var response = await VirtualMachineResourceVirtualMachinesRestClient.ListAllNextPageAsync(nextLink, Id.SubscriptionId, statusOnly, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualMachineResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Lists all of the virtual machines in the specified subscription. Use the nextLink property in the response to get the next page of virtual machines.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/virtualMachines
        /// Operation Id: VirtualMachines_ListAll
        /// </summary>
        /// <param name="statusOnly"> statusOnly=true enables fetching run time status of all Virtual Machines in the subscription. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VirtualMachineResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VirtualMachineResource> GetVirtualMachineResources(string statusOnly = null, CancellationToken cancellationToken = default)
        {
            Page<VirtualMachineResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = VirtualMachineResourceVirtualMachinesClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetVirtualMachineResources");
                scope.Start();
                try
                {
                    var response = VirtualMachineResourceVirtualMachinesRestClient.ListAll(Id.SubscriptionId, statusOnly, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualMachineResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VirtualMachineResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = VirtualMachineResourceVirtualMachinesClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetVirtualMachineResources");
                scope.Start();
                try
                {
                    var response = VirtualMachineResourceVirtualMachinesRestClient.ListAllNextPage(nextLink, Id.SubscriptionId, statusOnly, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualMachineResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Gets the list of Images in the subscription. Use nextLink property in the response to get the next page of Images. Do this till nextLink is null to fetch all the Images.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/images
        /// Operation Id: Images_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ImageResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ImageResource> GetImageResourcesAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ImageResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = ImageResourceImagesClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetImageResources");
                scope.Start();
                try
                {
                    var response = await ImageResourceImagesRestClient.ListAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ImageResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ImageResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = ImageResourceImagesClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetImageResources");
                scope.Start();
                try
                {
                    var response = await ImageResourceImagesRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ImageResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Gets the list of Images in the subscription. Use nextLink property in the response to get the next page of Images. Do this till nextLink is null to fetch all the Images.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/images
        /// Operation Id: Images_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ImageResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ImageResource> GetImageResources(CancellationToken cancellationToken = default)
        {
            Page<ImageResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = ImageResourceImagesClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetImageResources");
                scope.Start();
                try
                {
                    var response = ImageResourceImagesRestClient.List(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ImageResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ImageResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = ImageResourceImagesClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetImageResources");
                scope.Start();
                try
                {
                    var response = ImageResourceImagesRestClient.ListNextPage(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ImageResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Gets a list of all VM Scale Sets in the subscription, regardless of the associated resource group. Use nextLink property in the response to get the next page of VM Scale Sets. Do this till nextLink is null to fetch all the VM Scale Sets.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/virtualMachineScaleSets
        /// Operation Id: VirtualMachineScaleSets_ListAll
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VirtualMachineScaleSetResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VirtualMachineScaleSetResource> GetVirtualMachineScaleSetResourcesAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<VirtualMachineScaleSetResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = VirtualMachineScaleSetResourceVirtualMachineScaleSetsClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetVirtualMachineScaleSetResources");
                scope.Start();
                try
                {
                    var response = await VirtualMachineScaleSetResourceVirtualMachineScaleSetsRestClient.ListAllAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualMachineScaleSetResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VirtualMachineScaleSetResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = VirtualMachineScaleSetResourceVirtualMachineScaleSetsClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetVirtualMachineScaleSetResources");
                scope.Start();
                try
                {
                    var response = await VirtualMachineScaleSetResourceVirtualMachineScaleSetsRestClient.ListAllNextPageAsync(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualMachineScaleSetResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Gets a list of all VM Scale Sets in the subscription, regardless of the associated resource group. Use nextLink property in the response to get the next page of VM Scale Sets. Do this till nextLink is null to fetch all the VM Scale Sets.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/virtualMachineScaleSets
        /// Operation Id: VirtualMachineScaleSets_ListAll
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VirtualMachineScaleSetResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VirtualMachineScaleSetResource> GetVirtualMachineScaleSetResources(CancellationToken cancellationToken = default)
        {
            Page<VirtualMachineScaleSetResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = VirtualMachineScaleSetResourceVirtualMachineScaleSetsClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetVirtualMachineScaleSetResources");
                scope.Start();
                try
                {
                    var response = VirtualMachineScaleSetResourceVirtualMachineScaleSetsRestClient.ListAll(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualMachineScaleSetResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VirtualMachineScaleSetResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = VirtualMachineScaleSetResourceVirtualMachineScaleSetsClientDiagnostics.CreateScope("SubscriptionExtensionClient.GetVirtualMachineScaleSetResources");
                scope.Start();
                try
                {
                    var response = VirtualMachineScaleSetResourceVirtualMachineScaleSetsRestClient.ListAllNextPage(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualMachineScaleSetResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Export logs that show Api requests made by this subscription in the given time window to show throttling activities.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/logAnalytics/apiAccess/getRequestRateByInterval
        /// Operation Id: LogAnalytics_ExportRequestRateByInterval
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="location"> The location upon which virtual-machine-sizes is queried. </param>
        /// <param name="parameters"> Parameters supplied to the LogAnalytics getRequestRateByInterval Api. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation<LogAnalytics>> ExportRequestRateByIntervalLogAnalyticAsync(WaitUntil waitUntil, string location, RequestRateByIntervalInput parameters, CancellationToken cancellationToken = default)
        {
            using var scope = LogAnalyticsClientDiagnostics.CreateScope("SubscriptionExtensionClient.ExportRequestRateByIntervalLogAnalytic");
            scope.Start();
            try
            {
                var response = await LogAnalyticsRestClient.ExportRequestRateByIntervalAsync(Id.SubscriptionId, location, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new MgmtRenameRulesArmOperation<LogAnalytics>(new LogAnalyticsOperationSource(), LogAnalyticsClientDiagnostics, Pipeline, LogAnalyticsRestClient.CreateExportRequestRateByIntervalRequest(Id.SubscriptionId, location, parameters).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Export logs that show Api requests made by this subscription in the given time window to show throttling activities.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/logAnalytics/apiAccess/getRequestRateByInterval
        /// Operation Id: LogAnalytics_ExportRequestRateByInterval
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="location"> The location upon which virtual-machine-sizes is queried. </param>
        /// <param name="parameters"> Parameters supplied to the LogAnalytics getRequestRateByInterval Api. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation<LogAnalytics> ExportRequestRateByIntervalLogAnalytic(WaitUntil waitUntil, string location, RequestRateByIntervalInput parameters, CancellationToken cancellationToken = default)
        {
            using var scope = LogAnalyticsClientDiagnostics.CreateScope("SubscriptionExtensionClient.ExportRequestRateByIntervalLogAnalytic");
            scope.Start();
            try
            {
                var response = LogAnalyticsRestClient.ExportRequestRateByInterval(Id.SubscriptionId, location, parameters, cancellationToken);
                var operation = new MgmtRenameRulesArmOperation<LogAnalytics>(new LogAnalyticsOperationSource(), LogAnalyticsClientDiagnostics, Pipeline, LogAnalyticsRestClient.CreateExportRequestRateByIntervalRequest(Id.SubscriptionId, location, parameters).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Export logs that show total throttled Api requests for this subscription in the given time window.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/logAnalytics/apiAccess/getThrottledRequests
        /// Operation Id: LogAnalytics_ExportThrottledRequests
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="location"> The location upon which virtual-machine-sizes is queried. </param>
        /// <param name="parameters"> Parameters supplied to the LogAnalytics getThrottledRequests Api. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation<LogAnalytics>> ExportThrottledRequestsLogAnalyticAsync(WaitUntil waitUntil, string location, ThrottledRequestsInput parameters, CancellationToken cancellationToken = default)
        {
            using var scope = LogAnalyticsClientDiagnostics.CreateScope("SubscriptionExtensionClient.ExportThrottledRequestsLogAnalytic");
            scope.Start();
            try
            {
                var response = await LogAnalyticsRestClient.ExportThrottledRequestsAsync(Id.SubscriptionId, location, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new MgmtRenameRulesArmOperation<LogAnalytics>(new LogAnalyticsOperationSource(), LogAnalyticsClientDiagnostics, Pipeline, LogAnalyticsRestClient.CreateExportThrottledRequestsRequest(Id.SubscriptionId, location, parameters).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Export logs that show total throttled Api requests for this subscription in the given time window.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/logAnalytics/apiAccess/getThrottledRequests
        /// Operation Id: LogAnalytics_ExportThrottledRequests
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="location"> The location upon which virtual-machine-sizes is queried. </param>
        /// <param name="parameters"> Parameters supplied to the LogAnalytics getThrottledRequests Api. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation<LogAnalytics> ExportThrottledRequestsLogAnalytic(WaitUntil waitUntil, string location, ThrottledRequestsInput parameters, CancellationToken cancellationToken = default)
        {
            using var scope = LogAnalyticsClientDiagnostics.CreateScope("SubscriptionExtensionClient.ExportThrottledRequestsLogAnalytic");
            scope.Start();
            try
            {
                var response = LogAnalyticsRestClient.ExportThrottledRequests(Id.SubscriptionId, location, parameters, cancellationToken);
                var operation = new MgmtRenameRulesArmOperation<LogAnalytics>(new LogAnalyticsOperationSource(), LogAnalyticsClientDiagnostics, Pipeline, LogAnalyticsRestClient.CreateExportThrottledRequestsRequest(Id.SubscriptionId, location, parameters).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
    }
}
