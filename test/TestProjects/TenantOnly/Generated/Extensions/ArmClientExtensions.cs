// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;

namespace TenantOnly
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public static partial class ArmClientExtensions
    {
        #region BillingAccountResource
        /// <summary> Gets an object representing a BillingAccountResource along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="BillingAccountResource" /> object. </returns>
        public static BillingAccountResource GetBillingAccountResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                BillingAccountResource.ValidateResourceId(id);
                return new BillingAccountResource(client, id);
            }
            );
        }
        #endregion

        #region AgreementResource
        /// <summary> Gets an object representing a AgreementResource along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AgreementResource" /> object. </returns>
        public static AgreementResource GetAgreementResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                AgreementResource.ValidateResourceId(id);
                return new AgreementResource(client, id);
            }
            );
        }
        #endregion
    }
}
