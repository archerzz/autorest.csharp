// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace ADP
{
    // Data plane generated client. The UploadSpecialFiles service client.
    /// <summary> The UploadSpecialFiles service client. </summary>
    public partial class UploadSpecialFilesClient
    {
        private static readonly string[] AuthorizationScopes = new string[] { "https://adp.azure.com/.default" };
        private readonly TokenCredential _tokenCredential;
        private readonly HttpPipeline _pipeline;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of UploadSpecialFilesClient for mocking. </summary>
        protected UploadSpecialFilesClient()
        {
        }

        /// <summary> Initializes a new instance of UploadSpecialFilesClient. </summary>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="credential"/> is null. </exception>
        public UploadSpecialFilesClient(TokenCredential credential) : this(credential, new ADPClientOptions())
        {
        }

        /// <summary> Initializes a new instance of UploadSpecialFilesClient. </summary>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="credential"/> is null. </exception>
        public UploadSpecialFilesClient(TokenCredential credential, ADPClientOptions options)
        {
            Argument.AssertNotNull(credential, nameof(credential));
            options ??= new ADPClientOptions();

            ClientDiagnostics = new ClientDiagnostics(options, true);
            _tokenCredential = credential;
            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), new HttpPipelinePolicy[] { new BearerTokenAuthenticationPolicy(_tokenCredential, AuthorizationScopes) }, new ResponseClassifier());
            _apiVersion = options.Version;
        }

        /// <summary> List special files for the upload. </summary>
        /// <param name="uploadId"> The upload resource identifier. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="uploadId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="uploadId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The <see cref="AsyncPageable{T}"/> from the service containing a list of <see cref="BinaryData"/> objects. Details of the body schema for each item in the collection are in the Remarks section below. </returns>
        /// <include file="Docs/UploadSpecialFilesClient.xml" path="doc/members/member[@name='ListAsync(String,RequestContext)']/*" />
        public virtual AsyncPageable<BinaryData> ListAsync(string uploadId, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(uploadId, nameof(uploadId));

            return ListImplementationAsync("UploadSpecialFilesClient.List", uploadId, context);
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

        /// <summary> List special files for the upload. </summary>
        /// <param name="uploadId"> The upload resource identifier. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="uploadId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="uploadId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The <see cref="Pageable{T}"/> from the service containing a list of <see cref="BinaryData"/> objects. Details of the body schema for each item in the collection are in the Remarks section below. </returns>
        /// <include file="Docs/UploadSpecialFilesClient.xml" path="doc/members/member[@name='List(String,RequestContext)']/*" />
        public virtual Pageable<BinaryData> List(string uploadId, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(uploadId, nameof(uploadId));

            return ListImplementation("UploadSpecialFilesClient.List", uploadId, context);
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

        /// <summary> Initiates the process of generating SAS signed URIs for uploading special files for the upload. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="uploadId"> The upload resource identifier. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="uploadId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="uploadId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The <see cref="Operation{T}"/> from the service that will contain a <see cref="BinaryData"/> object once the asynchronous operation on the service has completed. Details of the body schema for the operation's final value are in the Remarks section below. </returns>
        /// <include file="Docs/UploadSpecialFilesClient.xml" path="doc/members/member[@name='GenerateAsync(WaitUntil,String,RequestContext)']/*" />
        public virtual async Task<Operation<BinaryData>> GenerateAsync(WaitUntil waitUntil, string uploadId, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(uploadId, nameof(uploadId));

            using var scope = ClientDiagnostics.CreateScope("UploadSpecialFilesClient.Generate");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGenerateRequest(uploadId, context);
                return await ProtocolOperationHelpers.ProcessMessageAsync(_pipeline, message, ClientDiagnostics, "UploadSpecialFilesClient.Generate", OperationFinalStateVia.Location, context, waitUntil).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Initiates the process of generating SAS signed URIs for uploading special files for the upload. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="uploadId"> The upload resource identifier. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="uploadId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="uploadId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The <see cref="Operation{T}"/> from the service that will contain a <see cref="BinaryData"/> object once the asynchronous operation on the service has completed. Details of the body schema for the operation's final value are in the Remarks section below. </returns>
        /// <include file="Docs/UploadSpecialFilesClient.xml" path="doc/members/member[@name='Generate(WaitUntil,String,RequestContext)']/*" />
        public virtual Operation<BinaryData> Generate(WaitUntil waitUntil, string uploadId, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(uploadId, nameof(uploadId));

            using var scope = ClientDiagnostics.CreateScope("UploadSpecialFilesClient.Generate");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGenerateRequest(uploadId, context);
                return ProtocolOperationHelpers.ProcessMessage(_pipeline, message, ClientDiagnostics, "UploadSpecialFilesClient.Generate", OperationFinalStateVia.Location, context, waitUntil);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
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
            uri.AppendPath("/specialFilesUploadInfo", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateGenerateRequest(string uploadId, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier202);
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendPath("/uploads/", false);
            uri.AppendPath(uploadId, true);
            uri.AppendPath("/specialFilesUploadInfo:generate", false);
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

        private static ResponseClassifier _responseClassifier200;
        private static ResponseClassifier ResponseClassifier200 => _responseClassifier200 ??= new StatusCodeClassifier(stackalloc ushort[] { 200 });
        private static ResponseClassifier _responseClassifier202;
        private static ResponseClassifier ResponseClassifier202 => _responseClassifier202 ??= new StatusCodeClassifier(stackalloc ushort[] { 202 });
    }
}
