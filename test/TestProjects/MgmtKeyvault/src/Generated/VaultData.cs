// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Models;
using MgmtKeyvault.Models;

namespace MgmtKeyvault
{
    /// <summary> A class representing the Vault data model. </summary>
    public partial class VaultData : Azure.ResourceManager.Models.Resource
    {
        /// <summary> Initializes a new instance of VaultData. </summary>
        /// <param name="properties"> Properties of the vault. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        internal VaultData(VaultProperties properties)
        {
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            Tags = new ChangeTrackingDictionary<string, string>();
            Properties = properties;
        }

        /// <summary> Initializes a new instance of VaultData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="location"> Azure location of the key vault resource. </param>
        /// <param name="tags"> Tags assigned to the key vault resource. </param>
        /// <param name="systemData"> System metadata for the key vault. </param>
        /// <param name="properties"> Properties of the vault. </param>
        internal VaultData(ResourceIdentifier id, string name, ResourceType type, string location, IReadOnlyDictionary<string, string> tags, Models.SystemData systemData, VaultProperties properties) : base(id, name, type)
        {
            Location = location;
            Tags = tags;
            SystemData = systemData;
            Properties = properties;
        }

        /// <summary> Azure location of the key vault resource. </summary>
        public string Location { get; }
        /// <summary> Tags assigned to the key vault resource. </summary>
        public IReadOnlyDictionary<string, string> Tags { get; }
        /// <summary> System metadata for the key vault. </summary>
        public Models.SystemData SystemData { get; }
        /// <summary> Properties of the vault. </summary>
        public VaultProperties Properties { get; }
    }
}
