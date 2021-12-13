// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager;

namespace MgmtSingleton
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public static partial class ArmClientExtensions
    {
        #region SingletonResource
        /// <summary> Gets an object representing a SingletonResource along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SingletonResource" /> object. </returns>
        public static SingletonResource GetSingletonResource(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new SingletonResource(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region SingletonResource2
        /// <summary> Gets an object representing a SingletonResource2 along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SingletonResource2" /> object. </returns>
        public static SingletonResource2 GetSingletonResource2(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new SingletonResource2(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region ParentResource
        /// <summary> Gets an object representing a ParentResource along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ParentResource" /> object. </returns>
        public static ParentResource GetParentResource(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new ParentResource(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region SubscriptionParentSingleton
        /// <summary> Gets an object representing a SubscriptionParentSingleton along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SubscriptionParentSingleton" /> object. </returns>
        public static SubscriptionParentSingleton GetSubscriptionParentSingleton(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new SubscriptionParentSingleton(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region TenantParentSingleton
        /// <summary> Gets an object representing a TenantParentSingleton along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="TenantParentSingleton" /> object. </returns>
        public static TenantParentSingleton GetTenantParentSingleton(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new TenantParentSingleton(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region SingletonConfig
        /// <summary> Gets an object representing a SingletonConfig along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SingletonConfig" /> object. </returns>
        public static SingletonConfig GetSingletonConfig(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new SingletonConfig(clientOptions, credential, uri, pipeline, id));
        }
        #endregion
    }
}
