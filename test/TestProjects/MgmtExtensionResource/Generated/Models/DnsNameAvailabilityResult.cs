// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace MgmtExtensionResource.Models
{
    /// <summary> Response for the CheckDnsNameAvailability API service call. </summary>
    public partial class DnsNameAvailabilityResult
    {
        /// <summary> Initializes a new instance of <see cref="DnsNameAvailabilityResult"/>. </summary>
        internal DnsNameAvailabilityResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DnsNameAvailabilityResult"/>. </summary>
        /// <param name="available"> Domain availability (True/False). </param>
        internal DnsNameAvailabilityResult(bool? available)
        {
            Available = available;
        }

        /// <summary> Domain availability (True/False). </summary>
        public bool? Available { get; }
    }
}
