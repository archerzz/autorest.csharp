// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace ConfidentLevelsInTsp.Models
{
    /// <summary> This is a derived model with unions. </summary>
    public partial class DerivedModelWithUnion : BaseModel
    {
        /// <summary> Initializes a new instance of DerivedModelWithUnion. </summary>
        /// <param name="name"> The name. </param>
        /// <param name="unionProperty"> The union property. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="unionProperty"/> is null. </exception>
        public DerivedModelWithUnion(string name, BinaryData unionProperty) : base(name)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(unionProperty, nameof(unionProperty));

            UnionProperty = unionProperty;
        }

        /// <summary> Initializes a new instance of DerivedModelWithUnion. </summary>
        /// <param name="name"> The name. </param>
        /// <param name="size"> The size. </param>
        /// <param name="unionProperty"> The union property. </param>
        internal DerivedModelWithUnion(string name, double? size, BinaryData unionProperty) : base(name, size)
        {
            UnionProperty = unionProperty;
        }

        /// <summary>
        /// The union property
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
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
        public BinaryData UnionProperty { get; }
    }
}
