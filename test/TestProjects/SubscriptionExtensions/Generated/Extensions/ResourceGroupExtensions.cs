// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Resources;

namespace SubscriptionExtensions
{
    /// <summary> A class to add extension methods to ResourceGroup. </summary>
    public static partial class ResourceGroupExtensions
    {
        #region Oven
        /// <summary> Gets an object representing a OvenContainer along with the instance operations that can be performed on it. </summary>
        /// <param name="resourceGroup"> The <see cref="ResourceGroup" /> instance the method will execute against. </param>
        /// <returns> Returns a <see cref="OvenContainer" /> object. </returns>
        public static OvenContainer GetOvens(this ResourceGroup resourceGroup)
        {
            return new OvenContainer(resourceGroup);
        }
        #endregion
    }
}
