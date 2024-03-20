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

namespace MgmtMultipleParentResource.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class MockableMgmtMultipleParentResourceResourceGroupResource : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableMgmtMultipleParentResourceResourceGroupResource"/> class for mocking. </summary>
        protected MockableMgmtMultipleParentResourceResourceGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableMgmtMultipleParentResourceResourceGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableMgmtMultipleParentResourceResourceGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of AnotherParentResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of AnotherParentResources and their operations over a AnotherParentResource. </returns>
        public virtual AnotherParentCollection GetAnotherParents()
        {
            return GetCachedClient(client => new AnotherParentCollection(client, Id));
        }

        /// <summary>
        /// The operation to get the run command.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/anotherParents/{anotherName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AnotherParents_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AnotherParentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="anotherName"> The name of the virtual machine containing the run command. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="anotherName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="anotherName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<AnotherParentResource>> GetAnotherParentAsync(string anotherName, string expand = null, CancellationToken cancellationToken = default)
        {
            return await GetAnotherParents().GetAsync(anotherName, expand, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// The operation to get the run command.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/anotherParents/{anotherName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AnotherParents_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AnotherParentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="anotherName"> The name of the virtual machine containing the run command. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="anotherName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="anotherName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<AnotherParentResource> GetAnotherParent(string anotherName, string expand = null, CancellationToken cancellationToken = default)
        {
            return GetAnotherParents().Get(anotherName, expand, cancellationToken);
        }

        /// <summary> Gets a collection of TheParentResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of TheParentResources and their operations over a TheParentResource. </returns>
        public virtual TheParentCollection GetTheParents()
        {
            return GetCachedClient(client => new TheParentCollection(client, Id));
        }

        /// <summary>
        /// The operation to get the VMSS VM run command.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/theParents/{theParentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TheParents_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TheParentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="theParentName"> The name of the VM scale set. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="theParentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="theParentName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<TheParentResource>> GetTheParentAsync(string theParentName, string expand = null, CancellationToken cancellationToken = default)
        {
            return await GetTheParents().GetAsync(theParentName, expand, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// The operation to get the VMSS VM run command.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/theParents/{theParentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>TheParents_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2021-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="TheParentResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="theParentName"> The name of the VM scale set. </param>
        /// <param name="expand"> The expand expression to apply on the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="theParentName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="theParentName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<TheParentResource> GetTheParent(string theParentName, string expand = null, CancellationToken cancellationToken = default)
        {
            return GetTheParents().Get(theParentName, expand, cancellationToken);
        }
    }
}
