// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.ResourceManager.Resources;

namespace XmlDeserialization
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

        /// <summary> Gets a collection of XmlInstances in the XmlInstance. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of XmlInstances and their operations over a XmlInstance. </returns>
        public static XmlInstanceCollection GetXmlInstances(this ResourceGroup resourceGroup)
        {
            return GetExtensionClient(resourceGroup).GetXmlInstances();
        }
        /// <summary>
        /// Gets the details of the Xml specified by its identifier.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.XmlDeserialization/xmls/{xmlName}
        /// Operation Id: XmlDeserialization_Get
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="xmlName"> The name of the API Management service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="xmlName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="xmlName"/> is null. </exception>
        public async static Task<Response<XmlInstance>> GetXmlInstanceAsync(this ResourceGroup resourceGroup, string xmlName, CancellationToken cancellationToken = default)
        {
            return await resourceGroup.GetXmlInstances().GetAsync(xmlName, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Gets the details of the Xml specified by its identifier.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.XmlDeserialization/xmls/{xmlName}
        /// Operation Id: XmlDeserialization_Get
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="xmlName"> The name of the API Management service. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="xmlName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="xmlName"/> is null. </exception>
        public static Response<XmlInstance> GetXmlInstance(this ResourceGroup resourceGroup, string xmlName, CancellationToken cancellationToken = default)
        {
            return resourceGroup.GetXmlInstances().Get(xmlName, cancellationToken);
        }
    }
}
