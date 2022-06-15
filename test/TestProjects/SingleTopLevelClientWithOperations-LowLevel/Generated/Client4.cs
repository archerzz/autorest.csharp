// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace SingleTopLevelClientWithOperations_LowLevel
{
    /// <summary> The Client4 service client. </summary>
    public partial class Client4
    {
        private const string AuthorizationHeader = "Fake-Subscription-Key";
        private readonly AzureKeyCredential _keyCredential;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The String to use. </summary>
        public string ClientParameter { get; }

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of Client4 for mocking. </summary>
        protected Client4()
        {
        }

        /// <summary> Initializes a new instance of Client4. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="keyCredential"> The key credential to copy. </param>
        /// <param name="clientParameter"> The String to use. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal Client4(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, AzureKeyCredential keyCredential, string clientParameter, Uri endpoint)
        {
            ClientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
            _keyCredential = keyCredential;
            ClientParameter = clientParameter;
            _endpoint = endpoint;
        }

        /// <summary> Operation has a parameter with `x-ms-resource-identifier: true`, hence `Client4` will be codegen&apos;ed as a resource client. </summary>
        /// <param name="filter"> The String to use. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="filter"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <example>
        /// This sample shows how to call PatchAsync with required parameters and parse the result.
        /// <code><![CDATA[
        /// var credential = new DefaultAzureCredential();
        /// var endpoint = new Uri("<https://my-account-name.azure.com>");
        /// var client = new TopLevelClientWithOperationClient(endpoint, credential).GetClient4("<clientParameter>");
        /// 
        /// Response response = await client.PatchAsync("<filter>");
        /// JsonElement result = JsonDocument.Parse(GetContentFromResponse(response)).RootElement;
        /// Console.WriteLine(result.ToString());
        /// ]]></code>
        /// </example>
        public virtual async Task<Response> PatchAsync(string filter, RequestContext context = null)
        {
            Argument.AssertNotNull(filter, nameof(filter));

            using var scope = ClientDiagnostics.CreateScope("Client4.Patch");
            scope.Start();
            try
            {
                using HttpMessage message = CreatePatchRequest(filter, context);
                return await _pipeline.ProcessMessageAsync(message, context).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Operation has a parameter with `x-ms-resource-identifier: true`, hence `Client4` will be codegen&apos;ed as a resource client. </summary>
        /// <param name="filter"> The String to use. </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="filter"/> is null. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        /// <example>
        /// This sample shows how to call Patch with required parameters and parse the result.
        /// <code><![CDATA[
        /// var credential = new DefaultAzureCredential();
        /// var endpoint = new Uri("<https://my-account-name.azure.com>");
        /// var client = new TopLevelClientWithOperationClient(endpoint, credential).GetClient4("<clientParameter>");
        /// 
        /// Response response = client.Patch("<filter>");
        /// JsonElement result = JsonDocument.Parse(GetContentFromResponse(response)).RootElement;
        /// Console.WriteLine(result.ToString());
        /// ]]></code>
        /// </example>
        public virtual Response Patch(string filter, RequestContext context = null)
        {
            Argument.AssertNotNull(filter, nameof(filter));

            using var scope = ClientDiagnostics.CreateScope("Client4.Patch");
            scope.Start();
            try
            {
                using HttpMessage message = CreatePatchRequest(filter, context);
                return _pipeline.ProcessMessage(message, context);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreatePatchRequest(string filter, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier200);
            var request = message.Request;
            request.Method = RequestMethod.Patch;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/client4", false);
            uri.AppendQuery("filter", filter, true);
            uri.AppendQuery("clientParameter", ClientParameter, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        private static ResponseClassifier _responseClassifier200;
        private static ResponseClassifier ResponseClassifier200 => _responseClassifier200 ??= new StatusCodeClassifier(stackalloc ushort[] { 200 });
    }
}
