// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Models
{
    /// <summary> The `File` object represents a document that has been uploaded to OpenAI. </summary>
    public partial class OpenAIFile
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
        internal IDictionary<string, BinaryData> SerializedAdditionalRawData { get; set; }
        /// <summary> Initializes a new instance of <see cref="OpenAIFile"/>. </summary>
        /// <param name="id"> The file identifier, which can be referenced in the API endpoints. </param>
        /// <param name="bytes"> The size of the file in bytes. </param>
        /// <param name="createdAt"> The Unix timestamp (in seconds) for when the file was created. </param>
        /// <param name="filename"> The name of the file. </param>
        /// <param name="purpose"> The intended purpose of the file. Currently, only "fine-tune" is supported. </param>
        /// <param name="status">
        /// The current status of the file, which can be either `uploaded`, `processed`, `pending`,
        /// `error`, `deleting` or `deleted`.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/>, <paramref name="filename"/> or <paramref name="purpose"/> is null. </exception>
        internal OpenAIFile(string id, long bytes, DateTimeOffset createdAt, string filename, string purpose, OpenAIFileStatus status)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(filename, nameof(filename));
            Argument.AssertNotNull(purpose, nameof(purpose));

            Id = id;
            Bytes = bytes;
            CreatedAt = createdAt;
            Filename = filename;
            Purpose = purpose;
            Status = status;
        }

        /// <summary> Initializes a new instance of <see cref="OpenAIFile"/>. </summary>
        /// <param name="id"> The file identifier, which can be referenced in the API endpoints. </param>
        /// <param name="object"> The object type, which is always "file". </param>
        /// <param name="bytes"> The size of the file in bytes. </param>
        /// <param name="createdAt"> The Unix timestamp (in seconds) for when the file was created. </param>
        /// <param name="filename"> The name of the file. </param>
        /// <param name="purpose"> The intended purpose of the file. Currently, only "fine-tune" is supported. </param>
        /// <param name="status">
        /// The current status of the file, which can be either `uploaded`, `processed`, `pending`,
        /// `error`, `deleting` or `deleted`.
        /// </param>
        /// <param name="statusDetails">
        /// Additional details about the status of the file. If the file is in the `error` state, this will
        /// include a message describing the error.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal OpenAIFile(string id, OpenAIFileObject @object, long bytes, DateTimeOffset createdAt, string filename, string purpose, OpenAIFileStatus status, string statusDetails, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            Object = @object;
            Bytes = bytes;
            CreatedAt = createdAt;
            Filename = filename;
            Purpose = purpose;
            Status = status;
            StatusDetails = statusDetails;
            SerializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="OpenAIFile"/> for deserialization. </summary>
        internal OpenAIFile()
        {
        }

        /// <summary> The file identifier, which can be referenced in the API endpoints. </summary>
        public string Id { get; }
        /// <summary> The object type, which is always "file". </summary>
        public OpenAIFileObject Object { get; } = OpenAIFileObject.File;

        /// <summary> The size of the file in bytes. </summary>
        public long Bytes { get; }
        /// <summary> The Unix timestamp (in seconds) for when the file was created. </summary>
        public DateTimeOffset CreatedAt { get; }
        /// <summary> The name of the file. </summary>
        public string Filename { get; }
        /// <summary> The intended purpose of the file. Currently, only "fine-tune" is supported. </summary>
        public string Purpose { get; }
        /// <summary>
        /// The current status of the file, which can be either `uploaded`, `processed`, `pending`,
        /// `error`, `deleting` or `deleted`.
        /// </summary>
        public OpenAIFileStatus Status { get; }
        /// <summary>
        /// Additional details about the status of the file. If the file is in the `error` state, this will
        /// include a message describing the error.
        /// </summary>
        public string StatusDetails { get; }
    }
}
