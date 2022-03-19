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

namespace SubscriptionExtensions
{
    /// <summary> A class to add extension methods to SubscriptionExtensions. </summary>
    public static partial class SubscriptionExtensionsExtensions
    {
        private static SubscriptionResourceExtensionClient GetExtensionClient(SubscriptionResource subscriptionResource)
        {
            return subscriptionResource.GetCachedClient((client) =>
            {
                return new SubscriptionResourceExtensionClient(client, subscriptionResource.Id);
            }
            );
        }

        /// <summary> Gets a collection of ToasterResources in the ToasterResource. </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of ToasterResources and their operations over a ToasterResource. </returns>
        public static ToasterCollection GetToasters(this SubscriptionResource subscriptionResource)
        {
            return GetExtensionClient(subscriptionResource).GetToasters();
        }

        /// <summary>
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/toasters/{toasterName}
        /// Operation Id: Toasters_Get
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="toasterName"> The name of the availability set. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="toasterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="toasterName"/> is null. </exception>
        public static async Task<Response<ToasterResource>> GetToasterAsync(this SubscriptionResource subscriptionResource, string toasterName, CancellationToken cancellationToken = default)
        {
            return await subscriptionResource.GetToasters().GetAsync(toasterName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Compute/toasters/{toasterName}
        /// Operation Id: Toasters_Get
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="toasterName"> The name of the availability set. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="toasterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="toasterName"/> is null. </exception>
        public static Response<ToasterResource> GetToaster(this SubscriptionResource subscriptionResource, string toasterName, CancellationToken cancellationToken = default)
        {
            return subscriptionResource.GetToasters().Get(toasterName, cancellationToken);
        }

        private static ResourceGroupExtensionClient GetExtensionClient(ResourceGroup resourceGroup)
        {
            return resourceGroup.GetCachedClient((client) =>
            {
                return new ResourceGroupExtensionClient(client, resourceGroup.Id);
            }
            );
        }

        /// <summary> Gets a collection of OvenResources in the OvenResource. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of OvenResources and their operations over a OvenResource. </returns>
        public static OvenCollection GetOvens(this ResourceGroup resourceGroup)
        {
            return GetExtensionClient(resourceGroup).GetOvens();
        }

        /// <summary>
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/ovens/{ovenName}
        /// Operation Id: Ovens_Get
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="ovenName"> The name of the virtual machine. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ovenName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ovenName"/> is null. </exception>
        public static async Task<Response<OvenResource>> GetOvenAsync(this ResourceGroup resourceGroup, string ovenName, CancellationToken cancellationToken = default)
        {
            return await resourceGroup.GetOvens().GetAsync(ovenName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/ovens/{ovenName}
        /// Operation Id: Ovens_Get
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="ovenName"> The name of the virtual machine. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ovenName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ovenName"/> is null. </exception>
        public static Response<OvenResource> GetOven(this ResourceGroup resourceGroup, string ovenName, CancellationToken cancellationToken = default)
        {
            return resourceGroup.GetOvens().Get(ovenName, cancellationToken);
        }

        #region ToasterResource
        /// <summary> Gets an object representing a ToasterResource along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ToasterResource" /> object. </returns>
        public static ToasterResource GetToasterResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ToasterResource.ValidateResourceId(id);
                return new ToasterResource(client, id);
            }
            );
        }
        #endregion

        #region OvenResource
        /// <summary> Gets an object representing a OvenResource along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="OvenResource" /> object. </returns>
        public static OvenResource GetOvenResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                OvenResource.ValidateResourceId(id);
                return new OvenResource(client, id);
            }
            );
        }
        #endregion
    }
}
