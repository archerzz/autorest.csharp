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

namespace ResourceClients_LowLevel
{
    /// <summary> The ResourceGroup service client. </summary>
    public partial class ResourceGroup
    {
        private const string AuthorizationHeader = "Fake-Subscription-Key";
        private readonly AzureKeyCredential _keyCredential;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> Group identifier. </summary>
        public string GroupId { get; }

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of ResourceGroup for mocking. </summary>
        protected ResourceGroup()
        {
        }

        /// <summary> Initializes a new instance of ResourceGroup. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="keyCredential"> The key credential to copy. </param>
        /// <param name="groupId"> Group identifier. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal ResourceGroup(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, AzureKeyCredential keyCredential, string groupId, Uri endpoint)
        {
            ClientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _keyCredential = keyCredential;
            GroupId = groupId;
            _endpoint = endpoint;
        }

        /// <summary> Get a group. Method should stay in `Group` subclient. </summary>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <example>
        /// This sample shows how to call GetGroupAsync and parse the result.
        /// <code><![CDATA[
        /// var credential = new DefaultAzureCredential();
        /// var endpoint = new Uri("<https://my-account-name.azure.com>");
        /// var client = new ResourceServiceClient(endpoint, credential).GetResourceGroup("<groupId>");
        /// 
        /// Response response = await client.GetGroupAsync();
        /// 
        /// JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
        /// Console.WriteLine(result.ToString());
        /// ]]></code>
        /// </example>
        public virtual async Task<Response> GetGroupAsync(RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("ResourceGroup.GetGroup");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetGroupRequest(context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get a group. Method should stay in `Group` subclient. </summary>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <example>
        /// This sample shows how to call GetGroup and parse the result.
        /// <code><![CDATA[
        /// var credential = new DefaultAzureCredential();
        /// var endpoint = new Uri("<https://my-account-name.azure.com>");
        /// var client = new ResourceServiceClient(endpoint, credential).GetResourceGroup("<groupId>");
        /// 
        /// Response response = client.GetGroup();
        /// 
        /// JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
        /// Console.WriteLine(result.ToString());
        /// ]]></code>
        /// </example>
        public virtual Response GetGroup(RequestContext context = null)
        {
            using var scope = ClientDiagnostics.CreateScope("ResourceGroup.GetGroup");
            scope.Start();
            try
            {
                using HttpMessage message = CreateGetGroupRequest(context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get items in group. It is defined in `Item` subclient, but must be promoted to the `Group` subclient. </summary>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The <see cref="AsyncPageable{T}"/> from the service containing a list of <see cref="BinaryData"/> objects. </returns>
        /// <example>
        /// This sample shows how to call GetItemsAsync and parse the result.
        /// <code><![CDATA[
        /// var credential = new DefaultAzureCredential();
        /// var endpoint = new Uri("<https://my-account-name.azure.com>");
        /// var client = new ResourceServiceClient(endpoint, credential).GetResourceGroup("<groupId>");
        /// 
        /// await foreach (var data in client.GetItemsAsync())
        /// {
        ///     JsonElement result = JsonDocument.Parse(data.ToStream()).RootElement;
        ///     Console.WriteLine(result.ToString());
        /// }
        /// ]]></code>
        /// </example>
        public virtual AsyncPageable<BinaryData> GetItemsAsync(RequestContext context = null)
        {
            return GetItemsImplementationAsync("ResourceGroup.GetItems", context);
        }

        private AsyncPageable<BinaryData> GetItemsImplementationAsync(string diagnosticsScopeName, RequestContext context)
        {
            return PageableHelpers.CreateAsyncPageable(CreateEnumerableAsync, ClientDiagnostics, diagnosticsScopeName);
            async IAsyncEnumerable<Page<BinaryData>> CreateEnumerableAsync(string nextLink, int? pageSizeHint, [EnumeratorCancellation] CancellationToken cancellationToken = default)
            {
                do
                {
                    var message = string.IsNullOrEmpty(nextLink)
                        ? CreateGetItemsRequest(context)
                        : CreateGetItemsNextPageRequest(nextLink, context);
                    var page = await LowLevelPageableHelpers.ProcessMessageAsync(_pipeline, message, context, "value", "nextLink", cancellationToken).ConfigureAwait(false);
                    nextLink = page.ContinuationToken;
                    yield return page;
                } while (!string.IsNullOrEmpty(nextLink));
            }
        }

        /// <summary> Get items in group. It is defined in `Item` subclient, but must be promoted to the `Group` subclient. </summary>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The <see cref="Pageable{T}"/> from the service containing a list of <see cref="BinaryData"/> objects. </returns>
        /// <example>
        /// This sample shows how to call GetItems and parse the result.
        /// <code><![CDATA[
        /// var credential = new DefaultAzureCredential();
        /// var endpoint = new Uri("<https://my-account-name.azure.com>");
        /// var client = new ResourceServiceClient(endpoint, credential).GetResourceGroup("<groupId>");
        /// 
        /// foreach (var data in client.GetItems())
        /// {
        ///     JsonElement result = JsonDocument.Parse(data.ToStream()).RootElement;
        ///     Console.WriteLine(result.ToString());
        /// }
        /// ]]></code>
        /// </example>
        public virtual Pageable<BinaryData> GetItems(RequestContext context = null)
        {
            return GetItemsImplementation("ResourceGroup.GetItems", context);
        }

        private Pageable<BinaryData> GetItemsImplementation(string diagnosticsScopeName, RequestContext context)
        {
            return PageableHelpers.CreatePageable(CreateEnumerable, ClientDiagnostics, diagnosticsScopeName);
            IEnumerable<Page<BinaryData>> CreateEnumerable(string nextLink, int? pageSizeHint)
            {
                do
                {
                    var message = string.IsNullOrEmpty(nextLink)
                        ? CreateGetItemsRequest(context)
                        : CreateGetItemsNextPageRequest(nextLink, context);
                    var page = LowLevelPageableHelpers.ProcessMessage(_pipeline, message, context, "value", "nextLink");
                    nextLink = page.ContinuationToken;
                    yield return page;
                } while (!string.IsNullOrEmpty(nextLink));
            }
        }

        /// <summary> Initializes a new instance of Resource. </summary>
        /// <param name="itemId"> Item identifier. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="itemId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="itemId"/> is an empty string, and was expected to be non-empty. </exception>
        public virtual Resource GetResource(string itemId)
        {
            Argument.AssertNotNullOrEmpty(itemId, nameof(itemId));

            return new Resource(ClientDiagnostics, _pipeline, _keyCredential, GroupId, itemId, _endpoint);
        }

        internal HttpMessage CreateGetGroupRequest(RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/groups/", false);
            uri.AppendPath(GroupId, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateGetItemsRequest(RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/items/", false);
            uri.AppendPath(GroupId, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateGetItemsNextPageRequest(string nextLink, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        private static ResponseClassifier _responseClassifier200;
        private static ResponseClassifier ResponseClassifier200 => _responseClassifier200 ??= new StatusCodeClassifier(stackalloc ushort[] { 200 });
    }
}
