// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace MgmtMockTest.Models
{
    /// <summary> A list of private link resources. </summary>
    internal partial class MgmtMockTestPrivateLinkResourceListResult
    {
        /// <summary> Initializes a new instance of MgmtMockTestPrivateLinkResourceListResult. </summary>
        internal MgmtMockTestPrivateLinkResourceListResult()
        {
            Value = new ChangeTrackingList<MgmtMockTestPrivateLinkResource>();
        }

        /// <summary> Initializes a new instance of MgmtMockTestPrivateLinkResourceListResult. </summary>
        /// <param name="value"> Array of private link resources. </param>
        internal MgmtMockTestPrivateLinkResourceListResult(IReadOnlyList<MgmtMockTestPrivateLinkResource> value)
        {
            Value = value;
        }

        /// <summary> Array of private link resources. </summary>
        public IReadOnlyList<MgmtMockTestPrivateLinkResource> Value { get; }
    }
}