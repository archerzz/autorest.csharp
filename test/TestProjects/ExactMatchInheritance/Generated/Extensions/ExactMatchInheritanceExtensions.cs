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
using ExactMatchInheritance.Models;

namespace ExactMatchInheritance
{
    /// <summary> A class to add extension methods to ExactMatchInheritance. </summary>
    public static partial class ExactMatchInheritanceExtensions
    {
        private static ResourceGroupExtensionClient GetExtensionClient(ResourceGroup resourceGroup)
        {
            return resourceGroup.GetCachedClient((client) =>
            {
                return new ResourceGroupExtensionClient(client, resourceGroup.Id);
            }
            );
        }

        /// <summary> Gets a collection of ExactMatchModel1Resources in the ExactMatchModel1Resource. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of ExactMatchModel1Resources and their operations over a ExactMatchModel1Resource. </returns>
        public static ExactMatchModel1Collection GetExactMatchModel1s(this ResourceGroup resourceGroup)
        {
            return GetExtensionClient(resourceGroup).GetExactMatchModel1s();
        }

        /// <summary>
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/exactMatchModel1s/{exactMatchModel1SName}
        /// Operation Id: ExactMatchModel1s_Get
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="exactMatchModel1SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="exactMatchModel1SName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="exactMatchModel1SName"/> is null. </exception>
        public static async Task<Response<ExactMatchModel1Resource>> GetExactMatchModel1Async(this ResourceGroup resourceGroup, string exactMatchModel1SName, CancellationToken cancellationToken = default)
        {
            return await resourceGroup.GetExactMatchModel1s().GetAsync(exactMatchModel1SName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/exactMatchModel1s/{exactMatchModel1SName}
        /// Operation Id: ExactMatchModel1s_Get
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="exactMatchModel1SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="exactMatchModel1SName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="exactMatchModel1SName"/> is null. </exception>
        public static Response<ExactMatchModel1Resource> GetExactMatchModel1(this ResourceGroup resourceGroup, string exactMatchModel1SName, CancellationToken cancellationToken = default)
        {
            return resourceGroup.GetExactMatchModel1s().Get(exactMatchModel1SName, cancellationToken);
        }

        /// <summary> Gets a collection of ExactMatchModel5Resources in the ExactMatchModel5Resource. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of ExactMatchModel5Resources and their operations over a ExactMatchModel5Resource. </returns>
        public static ExactMatchModel5Collection GetExactMatchModel5s(this ResourceGroup resourceGroup)
        {
            return GetExtensionClient(resourceGroup).GetExactMatchModel5s();
        }

        /// <summary>
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/exactMatchModel5s/{exactMatchModel5SName}
        /// Operation Id: ExactMatchModel5s_Get
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="exactMatchModel5SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="exactMatchModel5SName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="exactMatchModel5SName"/> is null. </exception>
        public static async Task<Response<ExactMatchModel5Resource>> GetExactMatchModel5Async(this ResourceGroup resourceGroup, string exactMatchModel5SName, CancellationToken cancellationToken = default)
        {
            return await resourceGroup.GetExactMatchModel5s().GetAsync(exactMatchModel5SName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/exactMatchModel5s/{exactMatchModel5SName}
        /// Operation Id: ExactMatchModel5s_Get
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="exactMatchModel5SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="exactMatchModel5SName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="exactMatchModel5SName"/> is null. </exception>
        public static Response<ExactMatchModel5Resource> GetExactMatchModel5(this ResourceGroup resourceGroup, string exactMatchModel5SName, CancellationToken cancellationToken = default)
        {
            return resourceGroup.GetExactMatchModel5s().Get(exactMatchModel5SName, cancellationToken);
        }

        /// <summary>
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/exactMatchModel2s/{exactMatchModel2sName}
        /// Operation Id: ExactMatchModel2s_Put
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="exactMatchModel2SName"> The String to use. </param>
        /// <param name="parameters"> The ExactMatchModel2 to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="exactMatchModel2SName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="exactMatchModel2SName"/> or <paramref name="parameters"/> is null. </exception>
        public static async Task<Response<ExactMatchModel2>> PutExactMatchModel2Async(this ResourceGroup resourceGroup, string exactMatchModel2SName, ExactMatchModel2 parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(exactMatchModel2SName, nameof(exactMatchModel2SName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            return await GetExtensionClient(resourceGroup).PutExactMatchModel2Async(exactMatchModel2SName, parameters, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/exactMatchModel2s/{exactMatchModel2sName}
        /// Operation Id: ExactMatchModel2s_Put
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="exactMatchModel2SName"> The String to use. </param>
        /// <param name="parameters"> The ExactMatchModel2 to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="exactMatchModel2SName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="exactMatchModel2SName"/> or <paramref name="parameters"/> is null. </exception>
        public static Response<ExactMatchModel2> PutExactMatchModel2(this ResourceGroup resourceGroup, string exactMatchModel2SName, ExactMatchModel2 parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(exactMatchModel2SName, nameof(exactMatchModel2SName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            return GetExtensionClient(resourceGroup).PutExactMatchModel2(exactMatchModel2SName, parameters, cancellationToken);
        }

        /// <summary>
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/exactMatchModel3s
        /// Operation Id: ExactMatchModel3s_List
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ExactMatchModel3" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ExactMatchModel3> GetExactMatchModel3sAsync(this ResourceGroup resourceGroup, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(resourceGroup).GetExactMatchModel3sAsync(cancellationToken);
        }

        /// <summary>
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/exactMatchModel3s
        /// Operation Id: ExactMatchModel3s_List
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ExactMatchModel3" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<ExactMatchModel3> GetExactMatchModel3s(this ResourceGroup resourceGroup, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(resourceGroup).GetExactMatchModel3s(cancellationToken);
        }

        /// <summary>
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/exactMatchModel3s/{exactMatchModel3sName}
        /// Operation Id: ExactMatchModel3s_Put
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="exactMatchModel3SName"> The String to use. </param>
        /// <param name="parameters"> The ExactMatchModel3 to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="exactMatchModel3SName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="exactMatchModel3SName"/> or <paramref name="parameters"/> is null. </exception>
        public static async Task<Response<ExactMatchModel3>> PutExactMatchModel3Async(this ResourceGroup resourceGroup, string exactMatchModel3SName, ExactMatchModel3 parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(exactMatchModel3SName, nameof(exactMatchModel3SName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            return await GetExtensionClient(resourceGroup).PutExactMatchModel3Async(exactMatchModel3SName, parameters, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/exactMatchModel3s/{exactMatchModel3sName}
        /// Operation Id: ExactMatchModel3s_Put
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="exactMatchModel3SName"> The String to use. </param>
        /// <param name="parameters"> The ExactMatchModel3 to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="exactMatchModel3SName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="exactMatchModel3SName"/> or <paramref name="parameters"/> is null. </exception>
        public static Response<ExactMatchModel3> PutExactMatchModel3(this ResourceGroup resourceGroup, string exactMatchModel3SName, ExactMatchModel3 parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(exactMatchModel3SName, nameof(exactMatchModel3SName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            return GetExtensionClient(resourceGroup).PutExactMatchModel3(exactMatchModel3SName, parameters, cancellationToken);
        }

        /// <summary>
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/exactMatchModel3s/{exactMatchModel3sName}
        /// Operation Id: ExactMatchModel3s_Get
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="exactMatchModel3SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="exactMatchModel3SName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="exactMatchModel3SName"/> is null. </exception>
        public static async Task<Response<ExactMatchModel3>> GetExactMatchModel3Async(this ResourceGroup resourceGroup, string exactMatchModel3SName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(exactMatchModel3SName, nameof(exactMatchModel3SName));

            return await GetExtensionClient(resourceGroup).GetExactMatchModel3Async(exactMatchModel3SName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/exactMatchModel3s/{exactMatchModel3sName}
        /// Operation Id: ExactMatchModel3s_Get
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="exactMatchModel3SName"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="exactMatchModel3SName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="exactMatchModel3SName"/> is null. </exception>
        public static Response<ExactMatchModel3> GetExactMatchModel3(this ResourceGroup resourceGroup, string exactMatchModel3SName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(exactMatchModel3SName, nameof(exactMatchModel3SName));

            return GetExtensionClient(resourceGroup).GetExactMatchModel3(exactMatchModel3SName, cancellationToken);
        }

        /// <summary>
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/exactMatchModel4s/{exactMatchModel4sName}
        /// Operation Id: ExactMatchModel4s_Put
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="exactMatchModel4SName"> The String to use. </param>
        /// <param name="parameters"> The ExactMatchModel4 to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="exactMatchModel4SName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="exactMatchModel4SName"/> or <paramref name="parameters"/> is null. </exception>
        public static async Task<Response<ExactMatchModel4>> PutExactMatchModel4Async(this ResourceGroup resourceGroup, string exactMatchModel4SName, ExactMatchModel4 parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(exactMatchModel4SName, nameof(exactMatchModel4SName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            return await GetExtensionClient(resourceGroup).PutExactMatchModel4Async(exactMatchModel4SName, parameters, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/exactMatchModel4s/{exactMatchModel4sName}
        /// Operation Id: ExactMatchModel4s_Put
        /// </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <param name="exactMatchModel4SName"> The String to use. </param>
        /// <param name="parameters"> The ExactMatchModel4 to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="exactMatchModel4SName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="exactMatchModel4SName"/> or <paramref name="parameters"/> is null. </exception>
        public static Response<ExactMatchModel4> PutExactMatchModel4(this ResourceGroup resourceGroup, string exactMatchModel4SName, ExactMatchModel4 parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(exactMatchModel4SName, nameof(exactMatchModel4SName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            return GetExtensionClient(resourceGroup).PutExactMatchModel4(exactMatchModel4SName, parameters, cancellationToken);
        }

        #region ExactMatchModel1Resource
        /// <summary> Gets an object representing a ExactMatchModel1Resource along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ExactMatchModel1Resource" /> object. </returns>
        public static ExactMatchModel1Resource GetExactMatchModel1Resource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ExactMatchModel1Resource.ValidateResourceId(id);
                return new ExactMatchModel1Resource(client, id);
            }
            );
        }
        #endregion

        #region ExactMatchModel5Resource
        /// <summary> Gets an object representing a ExactMatchModel5Resource along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ExactMatchModel5Resource" /> object. </returns>
        public static ExactMatchModel5Resource GetExactMatchModel5Resource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ExactMatchModel5Resource.ValidateResourceId(id);
                return new ExactMatchModel5Resource(client, id);
            }
            );
        }
        #endregion
    }
}
