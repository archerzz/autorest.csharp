// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;

namespace MgmtExpandResourceTypes
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public static partial class ArmClientExtensions
    {
        #region RecordSetAResource
        /// <summary> Gets an object representing a RecordSetAResource along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="RecordSetAResource" /> object. </returns>
        public static RecordSetAResource GetRecordSetAResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                RecordSetAResource.ValidateResourceId(id);
                return new RecordSetAResource(client, id);
            }
            );
        }
        #endregion

        #region RecordSetAaaaResource
        /// <summary> Gets an object representing a RecordSetAaaaResource along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="RecordSetAaaaResource" /> object. </returns>
        public static RecordSetAaaaResource GetRecordSetAaaaResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                RecordSetAaaaResource.ValidateResourceId(id);
                return new RecordSetAaaaResource(client, id);
            }
            );
        }
        #endregion

        #region RecordSetCaaResource
        /// <summary> Gets an object representing a RecordSetCaaResource along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="RecordSetCaaResource" /> object. </returns>
        public static RecordSetCaaResource GetRecordSetCaaResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                RecordSetCaaResource.ValidateResourceId(id);
                return new RecordSetCaaResource(client, id);
            }
            );
        }
        #endregion

        #region RecordSetCNameResource
        /// <summary> Gets an object representing a RecordSetCNameResource along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="RecordSetCNameResource" /> object. </returns>
        public static RecordSetCNameResource GetRecordSetCNameResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                RecordSetCNameResource.ValidateResourceId(id);
                return new RecordSetCNameResource(client, id);
            }
            );
        }
        #endregion

        #region RecordSetMxResource
        /// <summary> Gets an object representing a RecordSetMxResource along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="RecordSetMxResource" /> object. </returns>
        public static RecordSetMxResource GetRecordSetMxResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                RecordSetMxResource.ValidateResourceId(id);
                return new RecordSetMxResource(client, id);
            }
            );
        }
        #endregion

        #region RecordSetNsResource
        /// <summary> Gets an object representing a RecordSetNsResource along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="RecordSetNsResource" /> object. </returns>
        public static RecordSetNsResource GetRecordSetNsResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                RecordSetNsResource.ValidateResourceId(id);
                return new RecordSetNsResource(client, id);
            }
            );
        }
        #endregion

        #region RecordSetPtrResource
        /// <summary> Gets an object representing a RecordSetPtrResource along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="RecordSetPtrResource" /> object. </returns>
        public static RecordSetPtrResource GetRecordSetPtrResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                RecordSetPtrResource.ValidateResourceId(id);
                return new RecordSetPtrResource(client, id);
            }
            );
        }
        #endregion

        #region RecordSetSoaResource
        /// <summary> Gets an object representing a RecordSetSoaResource along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="RecordSetSoaResource" /> object. </returns>
        public static RecordSetSoaResource GetRecordSetSoaResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                RecordSetSoaResource.ValidateResourceId(id);
                return new RecordSetSoaResource(client, id);
            }
            );
        }
        #endregion

        #region RecordSetSrvResource
        /// <summary> Gets an object representing a RecordSetSrvResource along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="RecordSetSrvResource" /> object. </returns>
        public static RecordSetSrvResource GetRecordSetSrvResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                RecordSetSrvResource.ValidateResourceId(id);
                return new RecordSetSrvResource(client, id);
            }
            );
        }
        #endregion

        #region RecordSetTxtResource
        /// <summary> Gets an object representing a RecordSetTxtResource along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="RecordSetTxtResource" /> object. </returns>
        public static RecordSetTxtResource GetRecordSetTxtResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                RecordSetTxtResource.ValidateResourceId(id);
                return new RecordSetTxtResource(client, id);
            }
            );
        }
        #endregion

        #region ZoneResource
        /// <summary> Gets an object representing a ZoneResource along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ZoneResource" /> object. </returns>
        public static ZoneResource GetZoneResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetClient(() =>
            {
                ZoneResource.ValidateResourceId(id);
                return new ZoneResource(client, id);
            }
            );
        }
        #endregion
    }
}
