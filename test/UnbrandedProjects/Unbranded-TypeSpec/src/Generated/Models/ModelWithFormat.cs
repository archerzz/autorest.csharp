// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace UnbrandedTypeSpec.Models
{
    /// <summary> The ModelWithFormat. </summary>
    public partial class ModelWithFormat
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

        /// <summary> Initializes a new instance of <see cref="ModelWithFormat"/>. </summary>
        /// <param name="sourceUrl"> url format. </param>
        /// <param name="guid"> uuid format. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceUrl"/> is null. </exception>
        public ModelWithFormat(Uri sourceUrl, Guid guid)
        {
            Argument.AssertNotNull(sourceUrl, nameof(sourceUrl));

            SourceUrl = sourceUrl;
            Guid = guid;
        }

        /// <summary> Initializes a new instance of <see cref="ModelWithFormat"/>. </summary>
        /// <param name="sourceUrl"> url format. </param>
        /// <param name="guid"> uuid format. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ModelWithFormat(Uri sourceUrl, Guid guid, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SourceUrl = sourceUrl;
            Guid = guid;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ModelWithFormat"/> for deserialization. </summary>
        internal ModelWithFormat()
        {
        }

        /// <summary> url format. </summary>
        public Uri SourceUrl { get; }
        /// <summary> uuid format. </summary>
        public Guid Guid { get; }
    }
}
