// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace AzureSample.ResourceManager.Storage.Models
{
    /// <summary> The SignedIdentifier. </summary>
    public partial class SignedIdentifier
    {
        /// <summary> Initializes a new instance of <see cref="SignedIdentifier"/>. </summary>
        public SignedIdentifier()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SignedIdentifier"/>. </summary>
        /// <param name="id"> An unique identifier of the stored access policy. </param>
        /// <param name="accessPolicy"> Access policy. </param>
        internal SignedIdentifier(string id, AccessPolicy accessPolicy)
        {
            Id = id;
            AccessPolicy = accessPolicy;
        }

        /// <summary> An unique identifier of the stored access policy. </summary>
        public string Id { get; set; }
        /// <summary> Access policy. </summary>
        public AccessPolicy AccessPolicy { get; set; }
    }
}