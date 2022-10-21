// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace ADP
{
    // Data plane generated client. The DiscoveryResultUploads service client.
    /// <summary> The DiscoveryResultUploads service client. </summary>
    public partial class DiscoveryResultUploadsClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of DiscoveryResultUploadsClient. </summary>
        public DiscoveryResultUploadsClient() : this(new ADPClientOptions())
        {
        }

        /// <summary> Initializes a new instance of DiscoveryResultUploadsClient. </summary>
        /// <param name="options"> The options for configuring the client. </param>
        public DiscoveryResultUploadsClient(ADPClientOptions options)
        {
            options ??= new ADPClientOptions();

            ClientDiagnostics = new ClientDiagnostics(options, true);
            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), Array.Empty<HttpPipelinePolicy>(), new ResponseClassifier());
            _apiVersion = options.Version;
        }

        /// <summary> List upload detail for the discovery resource. </summary>
        /// <param name="discoveryId"> The discovery identifier. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="discoveryId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="discoveryId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The <see cref="AsyncPageable{T}"/> from the service containing a list of <see cref="BinaryData"/> objects. Details of the body schema for each item in the collection are in the Remarks section below. </returns>
        /// <example>
        /// This sample shows how to call ListAsync with required parameters and parse the result.
        /// <code><![CDATA[
        /// var client = new DiscoveryResultUploadsClient();
        /// 
        /// await foreach (var data in client.ListAsync("<discoveryId>"))
        /// {
        ///     JsonElement result = JsonDocument.Parse(data.ToStream()).RootElement;
        ///     Console.WriteLine(result.GetProperty("uploadId").ToString());
        ///     Console.WriteLine(result.GetProperty("manifestDownloadUri").ToString());
        ///     Console.WriteLine(result.GetProperty("resourceEndpoint").ToString());
        /// }
        /// ]]></code>
        /// </example>
        /// <remarks>
        /// Below is the JSON schema for one item in the pageable response.
        /// 
        /// Response Body:
        /// 
        /// Schema for <c>Array</c>:
        /// <code>{
        ///   uploadId: string, # Required.
        ///   manifestDownloadUri: string, # Required.
        ///   resourceEndpoint: string, # Required.
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual AsyncPageable<BinaryData> ListAsync(string discoveryId, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(discoveryId, nameof(discoveryId));

            return ListImplementationAsync("DiscoveryResultUploadsClient.List", discoveryId, context);
        }

        private AsyncPageable<BinaryData> ListImplementationAsync(string diagnosticsScopeName, string discoveryId, RequestContext context)
        {
            return PageableHelpers.CreateAsyncPageable(CreateEnumerableAsync, ClientDiagnostics, diagnosticsScopeName);
            async IAsyncEnumerable<Page<BinaryData>> CreateEnumerableAsync(string nextLink, int? pageSizeHint, [EnumeratorCancellation] CancellationToken cancellationToken = default)
            {
                do
                {
                    var message = string.IsNullOrEmpty(nextLink)
                        ? CreateListRequest(discoveryId, context)
                        : CreateListNextPageRequest(nextLink, discoveryId, context);
                    var page = await LowLevelPageableHelpers.ProcessMessageAsync(_pipeline, message, context, "value", "nextLink", cancellationToken).ConfigureAwait(false);
                    nextLink = page.ContinuationToken;
                    yield return page;
                } while (!string.IsNullOrEmpty(nextLink));
            }
        }

        /// <summary> List upload detail for the discovery resource. </summary>
        /// <param name="discoveryId"> The discovery identifier. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="discoveryId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="discoveryId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The <see cref="Pageable{T}"/> from the service containing a list of <see cref="BinaryData"/> objects. Details of the body schema for each item in the collection are in the Remarks section below. </returns>
        /// <example>
        /// This sample shows how to call List with required parameters and parse the result.
        /// <code><![CDATA[
        /// var client = new DiscoveryResultUploadsClient();
        /// 
        /// foreach (var data in client.List("<discoveryId>"))
        /// {
        ///     JsonElement result = JsonDocument.Parse(data.ToStream()).RootElement;
        ///     Console.WriteLine(result.GetProperty("uploadId").ToString());
        ///     Console.WriteLine(result.GetProperty("manifestDownloadUri").ToString());
        ///     Console.WriteLine(result.GetProperty("resourceEndpoint").ToString());
        /// }
        /// ]]></code>
        /// </example>
        /// <remarks>
        /// Below is the JSON schema for one item in the pageable response.
        /// 
        /// Response Body:
        /// 
        /// Schema for <c>Array</c>:
        /// <code>{
        ///   uploadId: string, # Required.
        ///   manifestDownloadUri: string, # Required.
        ///   resourceEndpoint: string, # Required.
        /// }
        /// </code>
        /// 
        /// </remarks>
        public virtual Pageable<BinaryData> List(string discoveryId, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(discoveryId, nameof(discoveryId));

            return ListImplementation("DiscoveryResultUploadsClient.List", discoveryId, context);
        }

        private Pageable<BinaryData> ListImplementation(string diagnosticsScopeName, string discoveryId, RequestContext context)
        {
            return PageableHelpers.CreatePageable(CreateEnumerable, ClientDiagnostics, diagnosticsScopeName);
            IEnumerable<Page<BinaryData>> CreateEnumerable(string nextLink, int? pageSizeHint)
            {
                do
                {
                    var message = string.IsNullOrEmpty(nextLink)
                        ? CreateListRequest(discoveryId, context)
                        : CreateListNextPageRequest(nextLink, discoveryId, context);
                    var page = LowLevelPageableHelpers.ProcessMessage(_pipeline, message, context, "value", "nextLink");
                    nextLink = page.ContinuationToken;
                    yield return page;
                } while (!string.IsNullOrEmpty(nextLink));
            }
        }

        internal HttpMessage CreateListRequest(string discoveryId, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendPath("/discoveries/", false);
            uri.AppendPath(discoveryId, true);
            uri.AppendPath("/uploads", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string discoveryId, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        private static ResponseClassifier _responseClassifier200;
        private static ResponseClassifier ResponseClassifier200 => _responseClassifier200 ??= new StatusCodeClassifier(stackalloc ushort[] { 200 });
    }
}
