// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace MgmtDiscriminator.Models
{
    /// <summary> Defines the request header action for the delivery rule. </summary>
    public partial class DeliveryRuleRequestHeaderAction : DeliveryRuleAction
    {
        /// <summary> Initializes a new instance of <see cref="DeliveryRuleRequestHeaderAction"/>. </summary>
        /// <param name="parameters"> Defines the parameters for the action. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public DeliveryRuleRequestHeaderAction(HeaderActionParameters parameters)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            Parameters = parameters;
            Name = DeliveryRuleActionType.ModifyRequestHeader;
        }

        /// <summary> Initializes a new instance of <see cref="DeliveryRuleRequestHeaderAction"/>. </summary>
        /// <param name="name"> The name of the action for the delivery rule. </param>
        /// <param name="foo"> for test. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="parameters"> Defines the parameters for the action. </param>
        internal DeliveryRuleRequestHeaderAction(DeliveryRuleActionType name, string foo, IDictionary<string, BinaryData> serializedAdditionalRawData, HeaderActionParameters parameters) : base(name, foo, serializedAdditionalRawData)
        {
            Parameters = parameters;
            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="DeliveryRuleRequestHeaderAction"/> for deserialization. </summary>
        internal DeliveryRuleRequestHeaderAction()
        {
        }

        /// <summary> Defines the parameters for the action. </summary>
        [WirePath("parameters")]
        public HeaderActionParameters Parameters { get; set; }
    }
}
