// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;
using MgmtRenameRules.Models;

namespace MgmtRenameRules
{
    /// <summary> A class to add extension methods to MgmtRenameRules. </summary>
    public static partial class MgmtRenameRulesExtensions
    {
        private static SubscriptionResourceExtensionClient GetExtensionClient(SubscriptionResource subscriptionResource)
        {
            return subscriptionResource.GetCachedClient((client) =>
            {
                return new SubscriptionResourceExtensionClient(client, subscriptionResource.Id);
            }
            );
        }

        /// <summary>
        /// Gets all the virtual machines under the specified subscription for the specified location.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/virtualMachines
        /// Operation Id: VirtualMachines_ListByLocation
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location for which virtual machines under the subscription are queried. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        /// <returns> An async collection of <see cref="VirtualMachineResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<VirtualMachineResource> GetVirtualMachinesByLocationAsync(this SubscriptionResource subscriptionResource, string location, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));

            return GetExtensionClient(subscriptionResource).GetVirtualMachinesByLocationAsync(location, cancellationToken);
        }

        /// <summary>
        /// Gets all the virtual machines under the specified subscription for the specified location.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/virtualMachines
        /// Operation Id: VirtualMachines_ListByLocation
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location for which virtual machines under the subscription are queried. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> is null. </exception>
        /// <returns> A collection of <see cref="VirtualMachineResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<VirtualMachineResource> GetVirtualMachinesByLocation(this SubscriptionResource subscriptionResource, string location, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));

            return GetExtensionClient(subscriptionResource).GetVirtualMachinesByLocation(location, cancellationToken);
        }

        /// <summary>
        /// Lists all of the virtual machines in the specified subscription. Use the nextLink property in the response to get the next page of virtual machines.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/virtualMachines
        /// Operation Id: VirtualMachines_ListAll
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="statusOnly"> statusOnly=true enables fetching run time status of all Virtual Machines in the subscription. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VirtualMachineResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<VirtualMachineResource> GetVirtualMachinesAsync(this SubscriptionResource subscriptionResource, string statusOnly = null, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetVirtualMachinesAsync(statusOnly, cancellationToken);
        }

        /// <summary>
        /// Lists all of the virtual machines in the specified subscription. Use the nextLink property in the response to get the next page of virtual machines.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/virtualMachines
        /// Operation Id: VirtualMachines_ListAll
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="statusOnly"> statusOnly=true enables fetching run time status of all Virtual Machines in the subscription. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VirtualMachineResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<VirtualMachineResource> GetVirtualMachines(this SubscriptionResource subscriptionResource, string statusOnly = null, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetVirtualMachines(statusOnly, cancellationToken);
        }

        /// <summary>
        /// Gets the list of Images in the subscription. Use nextLink property in the response to get the next page of Images. Do this till nextLink is null to fetch all the Images.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/images
        /// Operation Id: Images_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ImageResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ImageResource> GetImagesAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetImagesAsync(cancellationToken);
        }

        /// <summary>
        /// Gets the list of Images in the subscription. Use nextLink property in the response to get the next page of Images. Do this till nextLink is null to fetch all the Images.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/images
        /// Operation Id: Images_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ImageResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<ImageResource> GetImages(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetImages(cancellationToken);
        }

        /// <summary>
        /// Gets a list of all VM Scale Sets in the subscription, regardless of the associated resource group. Use nextLink property in the response to get the next page of VM Scale Sets. Do this till nextLink is null to fetch all the VM Scale Sets.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/virtualMachineScaleSets
        /// Operation Id: VirtualMachineScaleSets_ListAll
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VirtualMachineScaleSetResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<VirtualMachineScaleSetResource> GetVirtualMachineScaleSetsAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetVirtualMachineScaleSetsAsync(cancellationToken);
        }

        /// <summary>
        /// Gets a list of all VM Scale Sets in the subscription, regardless of the associated resource group. Use nextLink property in the response to get the next page of VM Scale Sets. Do this till nextLink is null to fetch all the VM Scale Sets.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/virtualMachineScaleSets
        /// Operation Id: VirtualMachineScaleSets_ListAll
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VirtualMachineScaleSetResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<VirtualMachineScaleSetResource> GetVirtualMachineScaleSets(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetVirtualMachineScaleSets(cancellationToken);
        }

        /// <summary>
        /// Export logs that show Api requests made by this subscription in the given time window to show throttling activities.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/logAnalytics/apiAccess/getRequestRateByInterval
        /// Operation Id: LogAnalytics_ExportRequestRateByInterval
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="location"> The location upon which virtual-machine-sizes is queried. </param>
        /// <param name="parameters"> Parameters supplied to the LogAnalytics getRequestRateByInterval Api. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="parameters"/> is null. </exception>
        public static async Task<ArmOperation<LogAnalytics>> ExportRequestRateByIntervalLogAnalyticAsync(this SubscriptionResource subscriptionResource, WaitUntil waitUntil, string location, RequestRateByIntervalInput parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));
            Argument.AssertNotNull(parameters, nameof(parameters));

            return await GetExtensionClient(subscriptionResource).ExportRequestRateByIntervalLogAnalyticAsync(waitUntil, location, parameters, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Export logs that show Api requests made by this subscription in the given time window to show throttling activities.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/logAnalytics/apiAccess/getRequestRateByInterval
        /// Operation Id: LogAnalytics_ExportRequestRateByInterval
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="location"> The location upon which virtual-machine-sizes is queried. </param>
        /// <param name="parameters"> Parameters supplied to the LogAnalytics getRequestRateByInterval Api. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="parameters"/> is null. </exception>
        public static ArmOperation<LogAnalytics> ExportRequestRateByIntervalLogAnalytic(this SubscriptionResource subscriptionResource, WaitUntil waitUntil, string location, RequestRateByIntervalInput parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));
            Argument.AssertNotNull(parameters, nameof(parameters));

            return GetExtensionClient(subscriptionResource).ExportRequestRateByIntervalLogAnalytic(waitUntil, location, parameters, cancellationToken);
        }

        /// <summary>
        /// Export logs that show total throttled Api requests for this subscription in the given time window.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/logAnalytics/apiAccess/getThrottledRequests
        /// Operation Id: LogAnalytics_ExportThrottledRequests
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="location"> The location upon which virtual-machine-sizes is queried. </param>
        /// <param name="parameters"> Parameters supplied to the LogAnalytics getThrottledRequests Api. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="parameters"/> is null. </exception>
        public static async Task<ArmOperation<LogAnalytics>> ExportThrottledRequestsLogAnalyticAsync(this SubscriptionResource subscriptionResource, WaitUntil waitUntil, string location, ThrottledRequestsInput parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));
            Argument.AssertNotNull(parameters, nameof(parameters));

            return await GetExtensionClient(subscriptionResource).ExportThrottledRequestsLogAnalyticAsync(waitUntil, location, parameters, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Export logs that show total throttled Api requests for this subscription in the given time window.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/locations/{location}/logAnalytics/apiAccess/getThrottledRequests
        /// Operation Id: LogAnalytics_ExportThrottledRequests
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="location"> The location upon which virtual-machine-sizes is queried. </param>
        /// <param name="parameters"> Parameters supplied to the LogAnalytics getThrottledRequests Api. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="parameters"/> is null. </exception>
        public static ArmOperation<LogAnalytics> ExportThrottledRequestsLogAnalytic(this SubscriptionResource subscriptionResource, WaitUntil waitUntil, string location, ThrottledRequestsInput parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));
            Argument.AssertNotNull(parameters, nameof(parameters));

            return GetExtensionClient(subscriptionResource).ExportThrottledRequestsLogAnalytic(waitUntil, location, parameters, cancellationToken);
        }

        private static ResourceGroupResourceExtensionClient GetExtensionClient(ResourceGroupResource resourceGroupResource)
        {
            return resourceGroupResource.GetCachedClient((client) =>
            {
                return new ResourceGroupResourceExtensionClient(client, resourceGroupResource.Id);
            }
            );
        }

        /// <summary> Gets a collection of VirtualMachineResources in the VirtualMachineResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of VirtualMachineResources and their operations over a VirtualMachineResource. </returns>
        public static VirtualMachineCollection GetVirtualMachines(this ResourceGroupResource resourceGroupResource)
        {
            return GetExtensionClient(resourceGroupResource).GetVirtualMachines();
        }

        /// <summary>
        /// Retrieves information about the model view or the instance view of a virtual machine.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}
        /// Operation Id: VirtualMachines_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="vmName"> The name of the virtual machine. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmName"/> is null. </exception>
        public static async Task<Response<VirtualMachineResource>> GetVirtualMachineAsync(this ResourceGroupResource resourceGroupResource, string vmName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetVirtualMachines().GetAsync(vmName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Retrieves information about the model view or the instance view of a virtual machine.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}
        /// Operation Id: VirtualMachines_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="vmName"> The name of the virtual machine. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmName"/> is null. </exception>
        public static Response<VirtualMachineResource> GetVirtualMachine(this ResourceGroupResource resourceGroupResource, string vmName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetVirtualMachines().Get(vmName, cancellationToken);
        }

        /// <summary> Gets a collection of ImageResources in the ImageResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of ImageResources and their operations over a ImageResource. </returns>
        public static ImageCollection GetImages(this ResourceGroupResource resourceGroupResource)
        {
            return GetExtensionClient(resourceGroupResource).GetImages();
        }

        /// <summary>
        /// Gets an image.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/images/{imageName}
        /// Operation Id: Images_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="imageName"> The name of the image. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="imageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="imageName"/> is null. </exception>
        public static async Task<Response<ImageResource>> GetImageAsync(this ResourceGroupResource resourceGroupResource, string imageName, string expand = null, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetImages().GetAsync(imageName, expand, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets an image.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/images/{imageName}
        /// Operation Id: Images_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="imageName"> The name of the image. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="imageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="imageName"/> is null. </exception>
        public static Response<ImageResource> GetImage(this ResourceGroupResource resourceGroupResource, string imageName, string expand = null, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetImages().Get(imageName, expand, cancellationToken);
        }

        /// <summary> Gets a collection of VirtualMachineScaleSetResources in the VirtualMachineScaleSetResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of VirtualMachineScaleSetResources and their operations over a VirtualMachineScaleSetResource. </returns>
        public static VirtualMachineScaleSetCollection GetVirtualMachineScaleSets(this ResourceGroupResource resourceGroupResource)
        {
            return GetExtensionClient(resourceGroupResource).GetVirtualMachineScaleSets();
        }

        /// <summary>
        /// Display information about a virtual machine scale set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}
        /// Operation Id: VirtualMachineScaleSets_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="vmScaleSetName"> The name of the VM scale set. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmScaleSetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmScaleSetName"/> is null. </exception>
        public static async Task<Response<VirtualMachineScaleSetResource>> GetVirtualMachineScaleSetAsync(this ResourceGroupResource resourceGroupResource, string vmScaleSetName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetVirtualMachineScaleSets().GetAsync(vmScaleSetName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Display information about a virtual machine scale set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}
        /// Operation Id: VirtualMachineScaleSets_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="vmScaleSetName"> The name of the VM scale set. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmScaleSetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmScaleSetName"/> is null. </exception>
        public static Response<VirtualMachineScaleSetResource> GetVirtualMachineScaleSet(this ResourceGroupResource resourceGroupResource, string vmScaleSetName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetVirtualMachineScaleSets().Get(vmScaleSetName, cancellationToken);
        }

        #region VirtualMachineResource
        /// <summary> Gets an object representing a VirtualMachineResource along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VirtualMachineResource" /> object. </returns>
        public static VirtualMachineResource GetVirtualMachineResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                VirtualMachineResource.ValidateResourceId(id);
                return new VirtualMachineResource(client, id);
            }
            );
        }
        #endregion

        #region ImageResource
        /// <summary> Gets an object representing a ImageResource along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ImageResource" /> object. </returns>
        public static ImageResource GetImageResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ImageResource.ValidateResourceId(id);
                return new ImageResource(client, id);
            }
            );
        }
        #endregion

        #region VirtualMachineScaleSetResource
        /// <summary> Gets an object representing a VirtualMachineScaleSetResource along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VirtualMachineScaleSetResource" /> object. </returns>
        public static VirtualMachineScaleSetResource GetVirtualMachineScaleSetResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                VirtualMachineScaleSetResource.ValidateResourceId(id);
                return new VirtualMachineScaleSetResource(client, id);
            }
            );
        }
        #endregion

        #region VirtualMachineScaleSetExtensionResource
        /// <summary> Gets an object representing a VirtualMachineScaleSetExtensionResource along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VirtualMachineScaleSetExtensionResource" /> object. </returns>
        public static VirtualMachineScaleSetExtensionResource GetVirtualMachineScaleSetExtensionResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                VirtualMachineScaleSetExtensionResource.ValidateResourceId(id);
                return new VirtualMachineScaleSetExtensionResource(client, id);
            }
            );
        }
        #endregion

        #region VirtualMachineScaleSetRollingUpgradeResource
        /// <summary> Gets an object representing a VirtualMachineScaleSetRollingUpgradeResource along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VirtualMachineScaleSetRollingUpgradeResource" /> object. </returns>
        public static VirtualMachineScaleSetRollingUpgradeResource GetVirtualMachineScaleSetRollingUpgradeResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                VirtualMachineScaleSetRollingUpgradeResource.ValidateResourceId(id);
                return new VirtualMachineScaleSetRollingUpgradeResource(client, id);
            }
            );
        }
        #endregion

        #region VirtualMachineScaleSetVmResource
        /// <summary> Gets an object representing a VirtualMachineScaleSetVmResource along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="VirtualMachineScaleSetVmResource" /> object. </returns>
        public static VirtualMachineScaleSetVmResource GetVirtualMachineScaleSetVmResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                VirtualMachineScaleSetVmResource.ValidateResourceId(id);
                return new VirtualMachineScaleSetVmResource(client, id);
            }
            );
        }
        #endregion
    }
}
