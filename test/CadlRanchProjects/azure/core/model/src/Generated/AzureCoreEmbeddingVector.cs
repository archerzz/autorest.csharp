// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using _Specs_.Azure.Core.Model.Models;

namespace _Specs_.Azure.Core.Model
{
    // Data plane generated sub-client.
    /// <summary> The AzureCoreEmbeddingVector sub-client. </summary>
    public partial class AzureCoreEmbeddingVector
    {
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of AzureCoreEmbeddingVector for mocking. </summary>
        protected AzureCoreEmbeddingVector()
        {
        }

        /// <summary> Initializes a new instance of AzureCoreEmbeddingVector. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> The <see cref="Uri"/> to use. </param>
        internal AzureCoreEmbeddingVector(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint)
        {
            ClientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _endpoint = endpoint;
        }

        /// <summary> get an embedding vector. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <include file="Docs/AzureCoreEmbeddingVector.xml" path="doc/members/member[@name='GetAzureCoreEmbeddingVectorAsync(CancellationToken)']/*" />
        public virtual async Task<Response<ReadOnlyMemory<int>>> GetAzureCoreEmbeddingVectorAsync(CancellationToken cancellationToken = default)
        {
            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = await GetAzureCoreEmbeddingVectorAsync(context).ConfigureAwait(false);
            ReadOnlyMemory<int> value = default;
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            int index = 0;
            int[] array = new int[document.RootElement.GetArrayLength()];
            foreach (var item in document.RootElement.EnumerateArray())
            {
                array[index] = item.GetInt32();
                index++;
            }
            value = new ReadOnlyMemory<int>(array);
            return Response.FromValue(value, response);
        }

        /// <summary> get an embedding vector. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <include file="Docs/AzureCoreEmbeddingVector.xml" path="doc/members/member[@name='GetAzureCoreEmbeddingVector(CancellationToken)']/*" />
        public virtual Response<ReadOnlyMemory<int>> GetAzureCoreEmbeddingVector(CancellationToken cancellationToken = default)
        {
            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = GetAzureCoreEmbeddingVector(context);
            ReadOnlyMemory<int> value = default;
            using var document = JsonDocument.Parse(response.ContentStream);
            int index = 0;
            int[] array = new int[document.RootElement.GetArrayLength()];
            foreach (var item in document.RootElement.EnumerateArray())
            {
                array[index] = item.GetInt32();
                index++;
            }
            value = new ReadOnlyMemory<int>(array);
            return Response.FromValue(value, response);
        }

        /// <summary>
        /// [Protocol Method] get an embedding vector
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="GetAzureCoreEmbeddingVectorAsync(CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/AzureCoreEmbeddingVector.xml" path="doc/members/member[@name='GetAzureCoreEmbeddingVectorAsync(RequestContext)']/*" />
        public virtual async Task<Response> GetAzureCoreEmbeddingVectorAsync(RequestContext context)
        {
            using var scope = ClientDiagnostics.CreateScope("AzureCoreEmbeddingVector.GetAzureCoreEmbeddingVector");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetAzureCoreEmbeddingVectorRequest(context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] get an embedding vector
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="GetAzureCoreEmbeddingVector(CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/AzureCoreEmbeddingVector.xml" path="doc/members/member[@name='GetAzureCoreEmbeddingVector(RequestContext)']/*" />
        public virtual Response GetAzureCoreEmbeddingVector(RequestContext context)
        {
            using var scope = ClientDiagnostics.CreateScope("AzureCoreEmbeddingVector.GetAzureCoreEmbeddingVector");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetAzureCoreEmbeddingVectorRequest(context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> put an embedding vector. </summary>
        /// <param name="body"> _. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <include file="Docs/AzureCoreEmbeddingVector.xml" path="doc/members/member[@name='PutAsync(ReadOnlyMemory{int},CancellationToken)']/*" />
        public virtual async Task<Response> PutAsync(ReadOnlyMemory<int> body, CancellationToken cancellationToken = default)
        {
            using RequestContent content = RequestContentHelper.FromEnumerable(body.Span);
            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = await PutAsync(content, context).ConfigureAwait(false);
            return response;
        }

        /// <summary> put an embedding vector. </summary>
        /// <param name="body"> _. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <include file="Docs/AzureCoreEmbeddingVector.xml" path="doc/members/member[@name='Put(ReadOnlyMemory{int},CancellationToken)']/*" />
        public virtual Response Put(ReadOnlyMemory<int> body, CancellationToken cancellationToken = default)
        {
            using RequestContent content = RequestContentHelper.FromEnumerable(body.Span);
            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = Put(content, context);
            return response;
        }

        /// <summary>
        /// [Protocol Method] put an embedding vector
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="PutAsync(ReadOnlyMemory{int},CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/AzureCoreEmbeddingVector.xml" path="doc/members/member[@name='PutAsync(RequestContent,RequestContext)']/*" />
        public virtual async Task<Response> PutAsync(RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("AzureCoreEmbeddingVector.Put");
            scope.Start();
            try
            {
                using HttpMessage message = CreatePutRequest(content, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] put an embedding vector
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="Put(ReadOnlyMemory{int},CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/AzureCoreEmbeddingVector.xml" path="doc/members/member[@name='Put(RequestContent,RequestContext)']/*" />
        public virtual Response Put(RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("AzureCoreEmbeddingVector.Put");
            scope.Start();
            try
            {
                using HttpMessage message = CreatePutRequest(content, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> post a model which has an embeddingVector property. </summary>
        /// <param name="body"> _. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="body"/> is null. </exception>
        /// <include file="Docs/AzureCoreEmbeddingVector.xml" path="doc/members/member[@name='PostAsync(AzureEmbeddingModel,CancellationToken)']/*" />
        public virtual async Task<Response<AzureEmbeddingModel>> PostAsync(AzureEmbeddingModel body, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(body, nameof(body));

            using RequestContent content = body.ToRequestContent();
            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = await PostAsync(content, context).ConfigureAwait(false);
            return Response.FromValue(AzureEmbeddingModel.FromResponse(response), response);
        }

        /// <summary> post a model which has an embeddingVector property. </summary>
        /// <param name="body"> _. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="body"/> is null. </exception>
        /// <include file="Docs/AzureCoreEmbeddingVector.xml" path="doc/members/member[@name='Post(AzureEmbeddingModel,CancellationToken)']/*" />
        public virtual Response<AzureEmbeddingModel> Post(AzureEmbeddingModel body, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(body, nameof(body));

            using RequestContent content = body.ToRequestContent();
            RequestContext context = FromCancellationToken(cancellationToken);
            Response response = Post(content, context);
            return Response.FromValue(AzureEmbeddingModel.FromResponse(response), response);
        }

        /// <summary>
        /// [Protocol Method] post a model which has an embeddingVector property
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="PostAsync(AzureEmbeddingModel,CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/AzureCoreEmbeddingVector.xml" path="doc/members/member[@name='PostAsync(RequestContent,RequestContext)']/*" />
        public virtual async Task<Response> PostAsync(RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("AzureCoreEmbeddingVector.Post");
            scope.Start();
            try
            {
                using HttpMessage message = CreatePostRequest(content, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] post a model which has an embeddingVector property
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="Post(AzureEmbeddingModel,CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <include file="Docs/AzureCoreEmbeddingVector.xml" path="doc/members/member[@name='Post(RequestContent,RequestContext)']/*" />
        public virtual Response Post(RequestContent content, RequestContext context = null)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("AzureCoreEmbeddingVector.Post");
            scope.Start();
            try
            {
                using HttpMessage message = CreatePostRequest(content, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateGetAzureCoreEmbeddingVectorRequest(RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/azure/core/model/embeddingVector", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreatePutRequest(RequestContent content, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier204);
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/azure/core/model/embeddingVector", false);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
            return message;
        }

        internal HttpMessage CreatePostRequest(RequestContent content, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/azure/core/model/embeddingVector", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            request.Content = content;
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
        private static ResponseClassifier _responseClassifier204;
        private static ResponseClassifier ResponseClassifier204 => _responseClassifier204 ??= new StatusCodeClassifier(stackalloc ushort[] { 204 });
    }
}