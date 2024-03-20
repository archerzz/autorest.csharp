// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace MgmtResourceName.Models
{
    /// <summary> The response from the List Storage Accounts operation. </summary>
    internal partial class DiskListResult
    {
        /// <summary> Initializes a new instance of <see cref="DiskListResult"/>. </summary>
        internal DiskListResult()
        {
            Value = new ChangeTrackingList<DiskData>();
        }

        /// <summary> Initializes a new instance of <see cref="DiskListResult"/>. </summary>
        /// <param name="value"> Gets the list of storage accounts and their properties. </param>
        /// <param name="nextLink"> Request URL that can be used to query next page of storage accounts. Returned when total number of requested storage accounts exceed maximum page size. </param>
        internal DiskListResult(IReadOnlyList<DiskData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Gets the list of storage accounts and their properties. </summary>
        public IReadOnlyList<DiskData> Value { get; }
        /// <summary> Request URL that can be used to query next page of storage accounts. Returned when total number of requested storage accounts exceed maximum page size. </summary>
        public string NextLink { get; }
    }
}
