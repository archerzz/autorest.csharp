// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sample.Models
{
    /// <summary>
    /// Describes a virtual machines scale sets network configuration's DNS settings.
    /// Serialized Name: VirtualMachineScaleSetNetworkConfigurationDnsSettings
    /// </summary>
    internal partial class VirtualMachineScaleSetNetworkConfigurationDnsSettings
    {
        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetNetworkConfigurationDnsSettings"/>. </summary>
        public VirtualMachineScaleSetNetworkConfigurationDnsSettings()
        {
            DnsServers = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetNetworkConfigurationDnsSettings"/>. </summary>
        /// <param name="dnsServers">
        /// List of DNS servers IP addresses
        /// Serialized Name: VirtualMachineScaleSetNetworkConfigurationDnsSettings.dnsServers
        /// </param>
        internal VirtualMachineScaleSetNetworkConfigurationDnsSettings(IList<string> dnsServers)
        {
            DnsServers = dnsServers;
        }

        /// <summary>
        /// List of DNS servers IP addresses
        /// Serialized Name: VirtualMachineScaleSetNetworkConfigurationDnsSettings.dnsServers
        /// </summary>
        public IList<string> DnsServers { get; }
    }
}
