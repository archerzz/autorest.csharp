// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace MgmtDiscriminator.Models
{
    /// <summary> Defines the origin group override action for the delivery rule. </summary>
    public partial class OriginGroupOverrideAction : DeliveryRuleAction
    {
        /// <summary> Initializes a new instance of <see cref="OriginGroupOverrideAction"/>. </summary>
        /// <param name="parameters"> Defines the parameters for the action. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public OriginGroupOverrideAction(OriginGroupOverrideActionParameters parameters)
        {
            Argument.AssertNotNull(parameters, nameof(parameters));

            Parameters = parameters;
            Name = DeliveryRuleActionType.OriginGroupOverride;
        }

        /// <summary> Initializes a new instance of <see cref="OriginGroupOverrideAction"/>. </summary>
        /// <param name="name"> The name of the action for the delivery rule. </param>
        /// <param name="foo"> for test. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="parameters"> Defines the parameters for the action. </param>
        internal OriginGroupOverrideAction(DeliveryRuleActionType name, string foo, IDictionary<string, BinaryData> serializedAdditionalRawData, OriginGroupOverrideActionParameters parameters) : base(name, foo, serializedAdditionalRawData)
        {
            Parameters = parameters;
            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="OriginGroupOverrideAction"/> for deserialization. </summary>
        internal OriginGroupOverrideAction()
        {
        }

        /// <summary> Defines the parameters for the action. </summary>
        [WirePath("parameters")]
        public OriginGroupOverrideActionParameters Parameters { get; set; }
    }
}
