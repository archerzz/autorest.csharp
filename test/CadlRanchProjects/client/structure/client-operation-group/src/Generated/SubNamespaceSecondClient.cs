// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Client.Structure.Service.ClientOperationGroup.Models;

namespace Client.Structure.Service.ClientOperationGroup
{
    // Data plane generated client.
    /// <summary> The SubNamespaceSecond service client. </summary>
    public partial class SubNamespaceSecondClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly ClientType _client;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of SubNamespaceSecondClient for mocking. </summary>
        protected SubNamespaceSecondClient()
        {
        }

        /// <summary> Initializes a new instance of SubNamespaceSecondClient. </summary>
        /// <param name="endpoint"> Need to be set as 'http://localhost:3000' in client. </param>
        /// <param name="client"> Need to be set as 'default', 'multi-client', 'renamed-operation', 'two-operation-group' in client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> is null. </exception>
        public SubNamespaceSecondClient(Uri endpoint, ClientType client) : this(endpoint, client, new ClientStructureServiceClientOperationGroupClientOptions())
        {
        }

        /// <summary> Initializes a new instance of SubNamespaceSecondClient. </summary>
        /// <param name="endpoint"> Need to be set as 'http://localhost:3000' in client. </param>
        /// <param name="client"> Need to be set as 'default', 'multi-client', 'renamed-operation', 'two-operation-group' in client. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> is null. </exception>
        public SubNamespaceSecondClient(Uri endpoint, ClientType client, ClientStructureServiceClientOperationGroupClientOptions options)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            options ??= new ClientStructureServiceClientOperationGroupClientOptions();

            ClientDiagnostics = new ClientDiagnostics(options, true);
            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), Array.Empty<HttpPipelinePolicy>(), new ResponseClassifier());
            _endpoint = endpoint;
            _client = client;
        }

        // The convenience method is omitted here because it has exactly the same parameter list as the corresponding protocol method
        /// <summary>
        /// [Protocol Method] Five.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/SubNamespaceSecondClient.xml" path="doc/members/member[@name='FiveAsync(RequestContext)']/*" />
        public virtual async Task<Response> FiveAsync(RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("SubNamespaceSecondClient.Five");
            scope.Start();
            try
            {
                using HttpMessage message = CreateFiveRequest(context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // The convenience method is omitted here because it has exactly the same parameter list as the corresponding protocol method
        /// <summary>
        /// [Protocol Method] Five.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/SubNamespaceSecondClient.xml" path="doc/members/member[@name='Five(RequestContext)']/*" />
        public virtual Response Five(RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("SubNamespaceSecondClient.Five");
            scope.Start();
            try
            {
                using HttpMessage message = CreateFiveRequest(context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        private Group5 _cachedGroup5;

        /// <summary> Initializes a new instance of Group5. </summary>
        public virtual Group5 GetGroup5Client()
        {
            return Volatile.Read(ref _cachedGroup5) ?? Interlocked.CompareExchange(ref _cachedGroup5, new Group5(ClientDiagnostics, _pipeline, _endpoint, _client), null) ?? _cachedGroup5;
        }

        internal HttpMessage CreateFiveRequest(RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier204);
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRaw("/client/structure/", false);
            uri.AppendRaw(_client.ToSerialString(), true);
            uri.AppendPath("/five", false);
            request.Uri = uri;
            return message;
        }

        private static ResponseClassifier _responseClassifier204;
        private static ResponseClassifier ResponseClassifier204 => _responseClassifier204 ??= new StatusCodeClassifier(stackalloc ushort[] { 204 });
    }
}
