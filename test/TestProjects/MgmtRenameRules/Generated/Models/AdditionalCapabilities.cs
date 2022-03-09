// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace MgmtRenameRules.Models
{
    /// <summary> Enables or disables a capability on the virtual machine or virtual machine scale set. </summary>
    internal partial class AdditionalCapabilities
    {
        /// <summary> Initializes a new instance of AdditionalCapabilities. </summary>
        public AdditionalCapabilities()
        {
        }

        /// <summary> Initializes a new instance of AdditionalCapabilities. </summary>
        /// <param name="ultraSSDEnabled"> The flag that enables or disables a capability to have one or more managed data disks with UltraSSD_LRS storage account type on the VM or VMSS. Managed disks with storage account type UltraSSD_LRS can be added to a virtual machine or virtual machine scale set only if this property is enabled. </param>
        internal AdditionalCapabilities(bool? ultraSSDEnabled)
        {
            UltraSSDEnabled = ultraSSDEnabled;
        }

        /// <summary> The flag that enables or disables a capability to have one or more managed data disks with UltraSSD_LRS storage account type on the VM or VMSS. Managed disks with storage account type UltraSSD_LRS can be added to a virtual machine or virtual machine scale set only if this property is enabled. </summary>
        public bool? UltraSSDEnabled { get; set; }
    }
}