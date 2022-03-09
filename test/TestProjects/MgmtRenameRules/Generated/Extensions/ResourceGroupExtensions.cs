// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.ResourceManager.Resources;

namespace MgmtRenameRules
{
    /// <summary> A class to add extension methods to ResourceGroup. </summary>
    public static partial class ResourceGroupExtensions
    {
        private static ResourceGroupExtensionClient GetExtensionClient(ResourceGroup resourceGroup)
        {
            return resourceGroup.GetCachedClient((client) =>
            {
                return new ResourceGroupExtensionClient(client, resourceGroup.Id);
            }
            );
        }

        /// <summary> Gets a collection of VirtualMachines in the VirtualMachine. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of VirtualMachines and their operations over a VirtualMachine. </returns>
        public static VirtualMachineCollection GetVirtualMachines(this ResourceGroup resourceGroup)
        {
            return GetExtensionClient(resourceGroup).GetVirtualMachines();
        }
        /// <summary>
        /// Retrieves information about the model view or the instance view of a virtual machine.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}
        /// Operation Id: VirtualMachines_Get
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="vmName"> The name of the virtual machine. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmName"/> is null. </exception>
        public async static Task<Response<VirtualMachine>> GetVirtualMachineAsync(this ResourceGroup resourceGroup, string vmName, CancellationToken cancellationToken = default)
        {
            return await resourceGroup.GetVirtualMachines().GetAsync(vmName, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Retrieves information about the model view or the instance view of a virtual machine.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachines/{vmName}
        /// Operation Id: VirtualMachines_Get
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="vmName"> The name of the virtual machine. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmName"/> is null. </exception>
        public static Response<VirtualMachine> GetVirtualMachine(this ResourceGroup resourceGroup, string vmName, CancellationToken cancellationToken = default)
        {
            return resourceGroup.GetVirtualMachines().Get(vmName, cancellationToken);
        }

        /// <summary> Gets a collection of Images in the Image. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of Images and their operations over a Image. </returns>
        public static ImageCollection GetImages(this ResourceGroup resourceGroup)
        {
            return GetExtensionClient(resourceGroup).GetImages();
        }
        /// <summary>
        /// Gets an image.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/images/{imageName}
        /// Operation Id: Images_Get
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="imageName"> The name of the image. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="imageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="imageName"/> is null. </exception>
        public async static Task<Response<Image>> GetImageAsync(this ResourceGroup resourceGroup, string imageName, string expand = null, CancellationToken cancellationToken = default)
        {
            return await resourceGroup.GetImages().GetAsync(imageName, expand, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Gets an image.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/images/{imageName}
        /// Operation Id: Images_Get
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="imageName"> The name of the image. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="imageName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="imageName"/> is null. </exception>
        public static Response<Image> GetImage(this ResourceGroup resourceGroup, string imageName, string expand = null, CancellationToken cancellationToken = default)
        {
            return resourceGroup.GetImages().Get(imageName, expand, cancellationToken);
        }

        /// <summary> Gets a collection of VirtualMachineScaleSets in the VirtualMachineScaleSet. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of VirtualMachineScaleSets and their operations over a VirtualMachineScaleSet. </returns>
        public static VirtualMachineScaleSetCollection GetVirtualMachineScaleSets(this ResourceGroup resourceGroup)
        {
            return GetExtensionClient(resourceGroup).GetVirtualMachineScaleSets();
        }
        /// <summary>
        /// Display information about a virtual machine scale set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}
        /// Operation Id: VirtualMachineScaleSets_Get
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="vmScaleSetName"> The name of the VM scale set. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmScaleSetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmScaleSetName"/> is null. </exception>
        public async static Task<Response<VirtualMachineScaleSet>> GetVirtualMachineScaleSetAsync(this ResourceGroup resourceGroup, string vmScaleSetName, CancellationToken cancellationToken = default)
        {
            return await resourceGroup.GetVirtualMachineScaleSets().GetAsync(vmScaleSetName, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Display information about a virtual machine scale set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/virtualMachineScaleSets/{vmScaleSetName}
        /// Operation Id: VirtualMachineScaleSets_Get
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="vmScaleSetName"> The name of the VM scale set. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="vmScaleSetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="vmScaleSetName"/> is null. </exception>
        public static Response<VirtualMachineScaleSet> GetVirtualMachineScaleSet(this ResourceGroup resourceGroup, string vmScaleSetName, CancellationToken cancellationToken = default)
        {
            return resourceGroup.GetVirtualMachineScaleSets().Get(vmScaleSetName, cancellationToken);
        }
    }
}
