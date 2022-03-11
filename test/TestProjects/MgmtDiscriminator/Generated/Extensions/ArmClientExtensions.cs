// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;

namespace MgmtDiscriminator
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public static partial class ArmClientExtensions
    {
        #region DeliveryRuleResource
        /// <summary> Gets an object representing a DeliveryRuleResource along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DeliveryRuleResource" /> object. </returns>
        public static DeliveryRuleResource GetDeliveryRuleResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                DeliveryRuleResource.ValidateResourceId(id);
                return new DeliveryRuleResource(client, id);
            }
            );
        }
        #endregion
    }
}
