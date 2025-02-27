// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.IO;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using NameConflicts.Models;

namespace NameConflicts
{
    internal partial class AutoRestParameterFlatteningRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of AutoRestParameterFlatteningRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/> or <paramref name="pipeline"/> is null. </exception>
        public AutoRestParameterFlatteningRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint = null)
        {
            ClientDiagnostics = clientDiagnostics ?? throw new ArgumentNullException(nameof(clientDiagnostics));
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("http://localhost:3000");
        }

        internal Azure.Core.HttpMessage CreateOperationRequest(string request, string message, string scope, string uri, string pipeline, string clientDiagnostics, Class @class)
        {
            var message0 = _pipeline.CreateMessage();
            var request0 = message0.Request;
            request0.Method = RequestMethod.Patch;
            var uri0 = new RawRequestUriBuilder();
            uri0.Reset(_endpoint);
            uri0.AppendPath("/originalOperation", false);
            uri0.AppendQuery("request", request, true);
            uri0.AppendQuery("message", message, true);
            uri0.AppendQuery("scope", scope, true);
            uri0.AppendQuery("uri", uri, true);
            uri0.AppendQuery("pipeline", pipeline, true);
            uri0.AppendQuery("clientDiagnostics", clientDiagnostics, true);
            request0.Uri = uri0;
            request0.Headers.Add("Accept", "application/json");
            request0.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(@class);
            request0.Content = content;
            return message0;
        }

        /// <param name="request"> The <see cref="string"/> to use. </param>
        /// <param name="message"> The <see cref="string"/> to use. </param>
        /// <param name="scope"> The <see cref="string"/> to use. </param>
        /// <param name="uri"> The <see cref="string"/> to use. </param>
        /// <param name="pipeline"> The <see cref="string"/> to use. </param>
        /// <param name="clientDiagnostics"> The <see cref="string"/> to use. </param>
        /// <param name="class"> The <see cref="Class"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="request"/>, <paramref name="message"/>, <paramref name="scope"/>, <paramref name="uri"/>, <paramref name="pipeline"/>, <paramref name="clientDiagnostics"/> or <paramref name="class"/> is null. </exception>
        public async Task<Response<Struct>> OperationAsync(string request, string message, string scope, string uri, string pipeline, string clientDiagnostics, Class @class, CancellationToken cancellationToken = default)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }
            if (message == null)
            {
                throw new ArgumentNullException(nameof(message));
            }
            if (scope == null)
            {
                throw new ArgumentNullException(nameof(scope));
            }
            if (uri == null)
            {
                throw new ArgumentNullException(nameof(uri));
            }
            if (pipeline == null)
            {
                throw new ArgumentNullException(nameof(pipeline));
            }
            if (clientDiagnostics == null)
            {
                throw new ArgumentNullException(nameof(clientDiagnostics));
            }
            if (@class == null)
            {
                throw new ArgumentNullException(nameof(@class));
            }

            using var message0 = CreateOperationRequest(request, message, scope, uri, pipeline, clientDiagnostics, @class);
            await _pipeline.SendAsync(message0, cancellationToken).ConfigureAwait(false);
            switch (message0.Response.Status)
            {
                case 200:
                    {
                        Struct value = default;
                        using var document = await JsonDocument.ParseAsync(message0.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = Struct.DeserializeStruct(document.RootElement);
                        return Azure.Response.FromValue(value, message0.Response);
                    }
                default:
                    throw new RequestFailedException(message0.Response);
            }
        }

        /// <param name="request"> The <see cref="string"/> to use. </param>
        /// <param name="message"> The <see cref="string"/> to use. </param>
        /// <param name="scope"> The <see cref="string"/> to use. </param>
        /// <param name="uri"> The <see cref="string"/> to use. </param>
        /// <param name="pipeline"> The <see cref="string"/> to use. </param>
        /// <param name="clientDiagnostics"> The <see cref="string"/> to use. </param>
        /// <param name="class"> The <see cref="Class"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="request"/>, <paramref name="message"/>, <paramref name="scope"/>, <paramref name="uri"/>, <paramref name="pipeline"/>, <paramref name="clientDiagnostics"/> or <paramref name="class"/> is null. </exception>
        public Response<Struct> Operation(string request, string message, string scope, string uri, string pipeline, string clientDiagnostics, Class @class, CancellationToken cancellationToken = default)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }
            if (message == null)
            {
                throw new ArgumentNullException(nameof(message));
            }
            if (scope == null)
            {
                throw new ArgumentNullException(nameof(scope));
            }
            if (uri == null)
            {
                throw new ArgumentNullException(nameof(uri));
            }
            if (pipeline == null)
            {
                throw new ArgumentNullException(nameof(pipeline));
            }
            if (clientDiagnostics == null)
            {
                throw new ArgumentNullException(nameof(clientDiagnostics));
            }
            if (@class == null)
            {
                throw new ArgumentNullException(nameof(@class));
            }

            using var message0 = CreateOperationRequest(request, message, scope, uri, pipeline, clientDiagnostics, @class);
            _pipeline.Send(message0, cancellationToken);
            switch (message0.Response.Status)
            {
                case 200:
                    {
                        Struct value = default;
                        using var document = JsonDocument.Parse(message0.Response.ContentStream);
                        value = Struct.DeserializeStruct(document.RootElement);
                        return Azure.Response.FromValue(value, message0.Response);
                    }
                default:
                    throw new RequestFailedException(message0.Response);
            }
        }

        internal Azure.Core.HttpMessage CreateAnalyzeBodyRequest(Stream stringBody)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/conflictingLROOverloads", false);
            request.Uri = uri;
            if (stringBody != null)
            {
                request.Headers.Add("Content-Type", "application/pdf");
                request.Content = RequestContent.Create(stringBody);
            }
            return message;
        }

        /// <summary> Analyze body, that could be different media types. </summary>
        /// <param name="stringBody"> The <see cref="Stream"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Azure.Response> AnalyzeBodyAsync(Stream stringBody = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateAnalyzeBodyRequest(stringBody);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Analyze body, that could be different media types. </summary>
        /// <param name="stringBody"> The <see cref="Stream"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Azure.Response AnalyzeBody(Stream stringBody = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateAnalyzeBodyRequest(stringBody);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal Azure.Core.HttpMessage CreateAnalyzeBodyRequest(string stringBody)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/conflictingLROOverloads", false);
            request.Uri = uri;
            if (stringBody != null)
            {
                request.Headers.Add("Content-Type", "application/json");
                request.Content = RequestContent.Create(stringBody);
            }
            return message;
        }

        /// <summary> Analyze body, that could be different media types. </summary>
        /// <param name="stringBody"> The <see cref="string"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Azure.Response> AnalyzeBodyAsync(string stringBody = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateAnalyzeBodyRequest(stringBody);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Analyze body, that could be different media types. </summary>
        /// <param name="stringBody"> The <see cref="string"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Azure.Response AnalyzeBody(string stringBody = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateAnalyzeBodyRequest(stringBody);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal Azure.Core.HttpMessage CreateHttpMessageRequest(Models.HttpMessage httpMessage)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/HttpMessage", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            if (httpMessage != null)
            {
                request.Headers.Add("Content-Type", "application/json");
                var content = new Utf8JsonRequestContent();
                content.JsonWriter.WriteObjectValue(httpMessage);
                request.Content = content;
            }
            return message;
        }

        /// <param name="httpMessage"> The <see cref="Models.HttpMessage"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<Models.HttpMessage>> HttpMessageAsync(Models.HttpMessage httpMessage = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateHttpMessageRequest(httpMessage);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        Models.HttpMessage value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = Models.HttpMessage.DeserializeHttpMessage(document.RootElement);
                        return Azure.Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <param name="httpMessage"> The <see cref="Models.HttpMessage"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<Models.HttpMessage> HttpMessage(Models.HttpMessage httpMessage = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateHttpMessageRequest(httpMessage);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        Models.HttpMessage value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = Models.HttpMessage.DeserializeHttpMessage(document.RootElement);
                        return Azure.Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal Azure.Core.HttpMessage CreateRequestRequest(Models.Request request)
        {
            var message = _pipeline.CreateMessage();
            var request0 = message.Request;
            request0.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/Request", false);
            request0.Uri = uri;
            request0.Headers.Add("Accept", "application/json");
            if (request != null)
            {
                request0.Headers.Add("Content-Type", "application/json");
                var content = new Utf8JsonRequestContent();
                content.JsonWriter.WriteObjectValue(request);
                request0.Content = content;
            }
            return message;
        }

        /// <param name="request"> The <see cref="Models.Request"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<Models.Request>> RequestAsync(Models.Request request = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateRequestRequest(request);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        Models.Request value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = Models.Request.DeserializeRequest(document.RootElement);
                        return Azure.Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <param name="request"> The <see cref="Models.Request"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<Models.Request> Request(Models.Request request = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateRequestRequest(request);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        Models.Request value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = Models.Request.DeserializeRequest(document.RootElement);
                        return Azure.Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal Azure.Core.HttpMessage CreateResponseRequest(Models.Response response)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/Response", false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            if (response != null)
            {
                request.Headers.Add("Content-Type", "application/json");
                var content = new Utf8JsonRequestContent();
                content.JsonWriter.WriteObjectValue(response);
                request.Content = content;
            }
            return message;
        }

        /// <param name="response"> The <see cref="Models.Response"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<Models.Response>> ResponseAsync(Models.Response response = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateResponseRequest(response);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        Models.Response value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = Models.Response.DeserializeResponse(document.RootElement);
                        return Azure.Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <param name="response"> The <see cref="Models.Response"/> to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<Models.Response> Response(Models.Response response = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateResponseRequest(response);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        Models.Response value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = Models.Response.DeserializeResponse(document.RootElement);
                        return Azure.Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
