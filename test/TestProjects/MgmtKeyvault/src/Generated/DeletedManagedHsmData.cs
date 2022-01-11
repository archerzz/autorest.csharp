// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;
using MgmtKeyvault.Models;

namespace MgmtKeyvault
{
    /// <summary> A class representing the DeletedManagedHsm data model. </summary>
    public partial class DeletedManagedHsmData : Azure.ResourceManager.Models.Resource
    {
        /// <summary> Initializes a new instance of DeletedManagedHsmData. </summary>
        internal DeletedManagedHsmData()
        {
        }

        /// <summary> Initializes a new instance of DeletedManagedHsmData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="properties"> Properties of the deleted managed HSM. </param>
        internal DeletedManagedHsmData(ResourceIdentifier id, string name, ResourceType type, DeletedManagedHsmProperties properties) : base(id, name, type)
        {
            Properties = properties;
        }

        /// <summary> Properties of the deleted managed HSM. </summary>
        public DeletedManagedHsmProperties Properties { get; }
    }
}
