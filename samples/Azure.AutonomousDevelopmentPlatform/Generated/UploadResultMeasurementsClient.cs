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

namespace AutonomousDevelopmentPlatform
{
    // Data plane generated client. The UploadResultMeasurements service client.
    /// <summary> The UploadResultMeasurements service client. </summary>
    public partial class UploadResultMeasurementsClient
    {
        private static readonly string[] AuthorizationScopes = new string[] { "https://adp.azure.com/.default" };
        private readonly TokenCredential _tokenCredential;
        private readonly HttpPipeline _pipeline;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of UploadResultMeasurementsClient for mocking. </summary>
        protected UploadResultMeasurementsClient()
        {
        }

        /// <summary> Initializes a new instance of UploadResultMeasurementsClient. </summary>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="credential"/> is null. </exception>
        public UploadResultMeasurementsClient(TokenCredential credential) : this(credential, new AutonomousDevelopmentPlatformClientOptions())
        {
        }

        /// <summary> Initializes a new instance of UploadResultMeasurementsClient. </summary>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="credential"/> is null. </exception>
        public UploadResultMeasurementsClient(TokenCredential credential, AutonomousDevelopmentPlatformClientOptions options)
        {
            Argument.AssertNotNull(credential, nameof(credential));
            options ??= new AutonomousDevelopmentPlatformClientOptions();

            ClientDiagnostics = new ClientDiagnostics(options, true);
            _tokenCredential = credential;
            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), new HttpPipelinePolicy[] { new BearerTokenAuthenticationPolicy(_tokenCredential, AuthorizationScopes) }, new ResponseClassifier());
            _apiVersion = options.Version;
        }

        /// <summary> List of the measurement identifiers that have been created by the upload. </summary>
        /// <param name="uploadId"> The upload resource identifier. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="uploadId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="uploadId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The <see cref="AsyncPageable{T}"/> from the service containing a list of <see cref="BinaryData"/> objects. Details of the body schema for each item in the collection are in the Remarks section below. </returns>
        /// <include file="Docs/UploadResultMeasurementsClient.xml" path="doc/members/member[@name='ListAsync(String,RequestContext)']/*" />
        public virtual AsyncPageable<BinaryData> ListAsync(string uploadId, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(uploadId, nameof(uploadId));

            return ListImplementationAsync("UploadResultMeasurementsClient.List", uploadId, context);
        }

        private AsyncPageable<BinaryData> ListImplementationAsync(string diagnosticsScopeName, string uploadId, RequestContext context)
        {
            return PageableHelpers.CreateAsyncPageable(CreateEnumerableAsync, ClientDiagnostics, diagnosticsScopeName);
            async IAsyncEnumerable<Page<BinaryData>> CreateEnumerableAsync(string nextLink, int? pageSizeHint, [EnumeratorCancellation] CancellationToken cancellationToken = default)
            {
                do
                {
                    var message = string.IsNullOrEmpty(nextLink)
                        ? CreateListRequest(uploadId, context)
                        : CreateListNextPageRequest(nextLink, uploadId, context);
                    var page = await LowLevelPageableHelpers.ProcessMessageAsync(_pipeline, message, context, "value", "nextLink", cancellationToken).ConfigureAwait(false);
                    nextLink = page.ContinuationToken;
                    yield return page;
                } while (!string.IsNullOrEmpty(nextLink));
            }
        }

        /// <summary> List of the measurement identifiers that have been created by the upload. </summary>
        /// <param name="uploadId"> The upload resource identifier. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="uploadId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="uploadId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The <see cref="Pageable{T}"/> from the service containing a list of <see cref="BinaryData"/> objects. Details of the body schema for each item in the collection are in the Remarks section below. </returns>
        /// <include file="Docs/UploadResultMeasurementsClient.xml" path="doc/members/member[@name='List(String,RequestContext)']/*" />
        public virtual Pageable<BinaryData> List(string uploadId, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(uploadId, nameof(uploadId));

            return ListImplementation("UploadResultMeasurementsClient.List", uploadId, context);
        }

        private Pageable<BinaryData> ListImplementation(string diagnosticsScopeName, string uploadId, RequestContext context)
        {
            return PageableHelpers.CreatePageable(CreateEnumerable, ClientDiagnostics, diagnosticsScopeName);
            IEnumerable<Page<BinaryData>> CreateEnumerable(string nextLink, int? pageSizeHint)
            {
                do
                {
                    var message = string.IsNullOrEmpty(nextLink)
                        ? CreateListRequest(uploadId, context)
                        : CreateListNextPageRequest(nextLink, uploadId, context);
                    var page = LowLevelPageableHelpers.ProcessMessage(_pipeline, message, context, "value", "nextLink");
                    nextLink = page.ContinuationToken;
                    yield return page;
                } while (!string.IsNullOrEmpty(nextLink));
            }
        }

        internal HttpMessage CreateListRequest(string uploadId, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendPath("/uploads/", false);
            uri.AppendPath(uploadId, true);
            uri.AppendPath("/measurements", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string uploadId, RequestContext context)
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

        private static RequestContext DefaultRequestContext = new RequestContext();
        internal static RequestContext FromCancellationToken(CancellationToken cancellationToken = default)
        {
            if (!cancellationToken.CanBeCanceled)
            {
                return DefaultRequestContext;
            }

            return new RequestContext() { CancellationToken = cancellationToken };
        }

        private static ResponseClassifier _responseClassifier200;
        private static ResponseClassifier ResponseClassifier200 => _responseClassifier200 ??= new StatusCodeClassifier(stackalloc ushort[] { 200 });
    }
}
