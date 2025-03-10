// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace _Specs_.Azure.Example.Basic.Models
{
    /// <summary> The ActionRequest. </summary>
    public partial class ActionRequest
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ActionRequest"/>. </summary>
        /// <param name="stringProperty"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="stringProperty"/> is null. </exception>
        public ActionRequest(string stringProperty)
        {
            Argument.AssertNotNull(stringProperty, nameof(stringProperty));

            StringProperty = stringProperty;
            ArrayProperty = new ChangeTrackingList<string>();
            RecordProperty = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="ActionRequest"/>. </summary>
        /// <param name="stringProperty"></param>
        /// <param name="modelProperty"></param>
        /// <param name="arrayProperty"></param>
        /// <param name="recordProperty"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ActionRequest(string stringProperty, Model modelProperty, IList<string> arrayProperty, IDictionary<string, string> recordProperty, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            StringProperty = stringProperty;
            ModelProperty = modelProperty;
            ArrayProperty = arrayProperty;
            RecordProperty = recordProperty;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ActionRequest"/> for deserialization. </summary>
        internal ActionRequest()
        {
        }

        /// <summary> Gets the string property. </summary>
        public string StringProperty { get; }
        /// <summary> Gets or sets the model property. </summary>
        public Model ModelProperty { get; set; }
        /// <summary> Gets the array property. </summary>
        public IList<string> ArrayProperty { get; }
        /// <summary> Gets the record property. </summary>
        public IDictionary<string, string> RecordProperty { get; }
    }
}
