// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace ModelShapes.Models
{
    /// <summary> The InputModel. </summary>
    public partial class InputModel
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

        /// <summary> Initializes a new instance of <see cref="InputModel"/>. </summary>
        /// <param name="requiredString"></param>
        /// <param name="requiredInt"></param>
        /// <param name="requiredStringList"></param>
        /// <param name="requiredIntList"></param>
        /// <param name="requiredNullableString"></param>
        /// <param name="requiredNullableInt"></param>
        /// <param name="requiredNullableStringList"></param>
        /// <param name="requiredNullableIntList"></param>
        /// <param name="vectorReadOnlyRequired"> The vector representation of a search query. </param>
        /// <param name="vectorRequired"> The vector representation of a search query. </param>
        /// <param name="vectorReadOnlyRequiredNullable"> The vector representation of a search query. </param>
        /// <param name="vectorRequiredNullable"> The vector representation of a search query. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="requiredString"/>, <paramref name="requiredStringList"/> or <paramref name="requiredIntList"/> is null. </exception>
        public InputModel(string requiredString, int requiredInt, IEnumerable<string> requiredStringList, IEnumerable<int> requiredIntList, string requiredNullableString, int? requiredNullableInt, IEnumerable<string> requiredNullableStringList, IEnumerable<int> requiredNullableIntList, ReadOnlyMemory<float> vectorReadOnlyRequired, ReadOnlyMemory<float> vectorRequired, ReadOnlyMemory<float>? vectorReadOnlyRequiredNullable, ReadOnlyMemory<float>? vectorRequiredNullable)
        {
            if (requiredString == null)
            {
                throw new ArgumentNullException(nameof(requiredString));
            }
            if (requiredStringList == null)
            {
                throw new ArgumentNullException(nameof(requiredStringList));
            }
            if (requiredIntList == null)
            {
                throw new ArgumentNullException(nameof(requiredIntList));
            }

            RequiredString = requiredString;
            RequiredInt = requiredInt;
            RequiredStringList = requiredStringList.ToList();
            RequiredIntList = requiredIntList.ToList();
            NonRequiredStringList = new ChangeTrackingList<string>();
            NonRequiredIntList = new ChangeTrackingList<int>();
            RequiredNullableString = requiredNullableString;
            RequiredNullableInt = requiredNullableInt;
            RequiredNullableStringList = requiredNullableStringList?.ToList();
            RequiredNullableIntList = requiredNullableIntList?.ToList();
            NonRequiredNullableStringList = new ChangeTrackingList<string>();
            NonRequiredNullableIntList = new ChangeTrackingList<int>();
            Vector = ReadOnlyMemory<float>.Empty;
            VectorReadOnly = ReadOnlyMemory<float>.Empty;
            VectorReadOnlyRequired = vectorReadOnlyRequired;
            VectorRequired = vectorRequired;
            VectorReadOnlyRequiredNullable = vectorReadOnlyRequiredNullable;
            VectorRequiredNullable = vectorRequiredNullable;
        }

        /// <summary> Initializes a new instance of <see cref="InputModel"/>. </summary>
        /// <param name="requiredString"></param>
        /// <param name="requiredInt"></param>
        /// <param name="requiredStringList"></param>
        /// <param name="requiredIntList"></param>
        /// <param name="nonRequiredString"></param>
        /// <param name="nonRequiredInt"></param>
        /// <param name="nonRequiredStringList"></param>
        /// <param name="nonRequiredIntList"></param>
        /// <param name="requiredNullableString"></param>
        /// <param name="requiredNullableInt"></param>
        /// <param name="requiredNullableStringList"></param>
        /// <param name="requiredNullableIntList"></param>
        /// <param name="nonRequiredNullableString"></param>
        /// <param name="nonRequiredNullableInt"></param>
        /// <param name="nonRequiredNullableStringList"></param>
        /// <param name="nonRequiredNullableIntList"></param>
        /// <param name="vector"> The vector representation of a search query. </param>
        /// <param name="vectorReadOnly"> The vector representation of a search query. </param>
        /// <param name="vectorReadOnlyRequired"> The vector representation of a search query. </param>
        /// <param name="vectorRequired"> The vector representation of a search query. </param>
        /// <param name="vectorNullable"> The vector representation of a search query. </param>
        /// <param name="vectorReadOnlyNullable"> The vector representation of a search query. </param>
        /// <param name="vectorReadOnlyRequiredNullable"> The vector representation of a search query. </param>
        /// <param name="vectorRequiredNullable"> The vector representation of a search query. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal InputModel(string requiredString, int requiredInt, IList<string> requiredStringList, IList<int> requiredIntList, string nonRequiredString, int? nonRequiredInt, IList<string> nonRequiredStringList, IList<int> nonRequiredIntList, string requiredNullableString, int? requiredNullableInt, IList<string> requiredNullableStringList, IList<int> requiredNullableIntList, string nonRequiredNullableString, int? nonRequiredNullableInt, IList<string> nonRequiredNullableStringList, IList<int> nonRequiredNullableIntList, ReadOnlyMemory<float> vector, ReadOnlyMemory<float> vectorReadOnly, ReadOnlyMemory<float> vectorReadOnlyRequired, ReadOnlyMemory<float> vectorRequired, ReadOnlyMemory<float>? vectorNullable, ReadOnlyMemory<float>? vectorReadOnlyNullable, ReadOnlyMemory<float>? vectorReadOnlyRequiredNullable, ReadOnlyMemory<float>? vectorRequiredNullable, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            RequiredString = requiredString;
            RequiredInt = requiredInt;
            RequiredStringList = requiredStringList;
            RequiredIntList = requiredIntList;
            NonRequiredString = nonRequiredString;
            NonRequiredInt = nonRequiredInt;
            NonRequiredStringList = nonRequiredStringList;
            NonRequiredIntList = nonRequiredIntList;
            RequiredNullableString = requiredNullableString;
            RequiredNullableInt = requiredNullableInt;
            RequiredNullableStringList = requiredNullableStringList;
            RequiredNullableIntList = requiredNullableIntList;
            NonRequiredNullableString = nonRequiredNullableString;
            NonRequiredNullableInt = nonRequiredNullableInt;
            NonRequiredNullableStringList = nonRequiredNullableStringList;
            NonRequiredNullableIntList = nonRequiredNullableIntList;
            Vector = vector;
            VectorReadOnly = vectorReadOnly;
            VectorReadOnlyRequired = vectorReadOnlyRequired;
            VectorRequired = vectorRequired;
            VectorNullable = vectorNullable;
            VectorReadOnlyNullable = vectorReadOnlyNullable;
            VectorReadOnlyRequiredNullable = vectorReadOnlyRequiredNullable;
            VectorRequiredNullable = vectorRequiredNullable;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="InputModel"/> for deserialization. </summary>
        internal InputModel()
        {
        }

        /// <summary> Gets the required string. </summary>
        public string RequiredString { get; }
        /// <summary> Gets the required int. </summary>
        public int RequiredInt { get; }
        /// <summary> Gets the required string list. </summary>
        public IList<string> RequiredStringList { get; }
        /// <summary> Gets the required int list. </summary>
        public IList<int> RequiredIntList { get; }
        /// <summary> Gets or sets the non required string. </summary>
        public string NonRequiredString { get; set; }
        /// <summary> Gets or sets the non required int. </summary>
        public int? NonRequiredInt { get; set; }
        /// <summary> Gets the non required string list. </summary>
        public IList<string> NonRequiredStringList { get; }
        /// <summary> Gets the non required int list. </summary>
        public IList<int> NonRequiredIntList { get; }
        /// <summary> Gets the required nullable string. </summary>
        public string RequiredNullableString { get; }
        /// <summary> Gets the required nullable int. </summary>
        public int? RequiredNullableInt { get; }
        /// <summary> Gets or sets the required nullable string list. </summary>
        public IList<string> RequiredNullableStringList { get; set; }
        /// <summary> Gets or sets the required nullable int list. </summary>
        public IList<int> RequiredNullableIntList { get; set; }
        /// <summary> Gets or sets the non required nullable string. </summary>
        public string NonRequiredNullableString { get; set; }
        /// <summary> Gets or sets the non required nullable int. </summary>
        public int? NonRequiredNullableInt { get; set; }
        /// <summary> Gets or sets the non required nullable string list. </summary>
        public IList<string> NonRequiredNullableStringList { get; set; }
        /// <summary> Gets or sets the non required nullable int list. </summary>
        public IList<int> NonRequiredNullableIntList { get; set; }
        /// <summary> The vector representation of a search query. </summary>
        public ReadOnlyMemory<float> Vector { get; set; }
        /// <summary> The vector representation of a search query. </summary>
        public ReadOnlyMemory<float> VectorReadOnly { get; }
        /// <summary> The vector representation of a search query. </summary>
        public ReadOnlyMemory<float> VectorReadOnlyRequired { get; }
        /// <summary> The vector representation of a search query. </summary>
        public ReadOnlyMemory<float> VectorRequired { get; }
        /// <summary> The vector representation of a search query. </summary>
        public ReadOnlyMemory<float>? VectorNullable { get; set; }
        /// <summary> The vector representation of a search query. </summary>
        public ReadOnlyMemory<float>? VectorReadOnlyNullable { get; }
        /// <summary> The vector representation of a search query. </summary>
        public ReadOnlyMemory<float>? VectorReadOnlyRequiredNullable { get; }
        /// <summary> The vector representation of a search query. </summary>
        public ReadOnlyMemory<float>? VectorRequiredNullable { get; }
    }
}
