// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace ADP.DataManagement.Ingestion.Uploads
{
    /// <summary> Special file resource. </summary>
    public partial class UploadSpecialFile
    {
        /// <summary> Initializes a new instance of UploadSpecialFile. </summary>
        /// <param name="clientFileName"></param>
        /// <param name="fileUploadUri"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientFileName"/> or <paramref name="fileUploadUri"/> is null. </exception>
        public UploadSpecialFile(string clientFileName, string fileUploadUri)
        {
            Argument.AssertNotNull(clientFileName, nameof(clientFileName));
            Argument.AssertNotNull(fileUploadUri, nameof(fileUploadUri));

            ClientFileName = clientFileName;
            FileUploadUri = fileUploadUri;
        }

        /// <summary> Gets or sets the client file name. </summary>
        public string ClientFileName { get; set; }
        /// <summary> Gets or sets the file upload uri. </summary>
        public string FileUploadUri { get; set; }
    }
}
