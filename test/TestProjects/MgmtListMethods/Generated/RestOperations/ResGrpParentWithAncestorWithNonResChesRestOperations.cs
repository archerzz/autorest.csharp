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
using MgmtListMethods.Models;

namespace MgmtListMethods
{
    internal partial class ResGrpParentWithAncestorWithNonResChesRestOperations
    {
        private string subscriptionId;
        private Uri endpoint;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of ResGrpParentWithAncestorWithNonResChesRestOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> Subscription credentials which uniquely identify Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/> or <paramref name="apiVersion"/> is null. </exception>
        public ResGrpParentWithAncestorWithNonResChesRestOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null, string apiVersion = "2020-06-01")
        {
            this.subscriptionId = subscriptionId ?? throw new ArgumentNullException(nameof(subscriptionId));
            this.endpoint = endpoint ?? new Uri("https://management.azure.com");
            this.apiVersion = apiVersion ?? throw new ArgumentNullException(nameof(apiVersion));
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string resourceGroupName, string resGrpParentWithAncestorWithNonResChName, ResGrpParentWithAncestorWithNonResChData parameters)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.MgmtListMethods/resGrpParentWithAncestorWithNonResChes/", false);
            uri.AppendPath(resGrpParentWithAncestorWithNonResChName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(parameters);
            request.Content = content;
            return message;
        }

        /// <summary> Create or update. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="resGrpParentWithAncestorWithNonResChName"> Name. </param>
        /// <param name="parameters"> Parameters supplied to the Create. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="resGrpParentWithAncestorWithNonResChName"/>, or <paramref name="parameters"/> is null. </exception>
        public async Task<Response<ResGrpParentWithAncestorWithNonResChData>> CreateOrUpdateAsync(string resourceGroupName, string resGrpParentWithAncestorWithNonResChName, ResGrpParentWithAncestorWithNonResChData parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resGrpParentWithAncestorWithNonResChName == null)
            {
                throw new ArgumentNullException(nameof(resGrpParentWithAncestorWithNonResChName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var message = CreateCreateOrUpdateRequest(resourceGroupName, resGrpParentWithAncestorWithNonResChName, parameters);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ResGrpParentWithAncestorWithNonResChData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ResGrpParentWithAncestorWithNonResChData.DeserializeResGrpParentWithAncestorWithNonResChData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Create or update. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="resGrpParentWithAncestorWithNonResChName"> Name. </param>
        /// <param name="parameters"> Parameters supplied to the Create. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/>, <paramref name="resGrpParentWithAncestorWithNonResChName"/>, or <paramref name="parameters"/> is null. </exception>
        public Response<ResGrpParentWithAncestorWithNonResChData> CreateOrUpdate(string resourceGroupName, string resGrpParentWithAncestorWithNonResChName, ResGrpParentWithAncestorWithNonResChData parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resGrpParentWithAncestorWithNonResChName == null)
            {
                throw new ArgumentNullException(nameof(resGrpParentWithAncestorWithNonResChName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var message = CreateCreateOrUpdateRequest(resourceGroupName, resGrpParentWithAncestorWithNonResChName, parameters);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ResGrpParentWithAncestorWithNonResChData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ResGrpParentWithAncestorWithNonResChData.DeserializeResGrpParentWithAncestorWithNonResChData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string resourceGroupName, string resGrpParentWithAncestorWithNonResChName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.MgmtListMethods/resGrpParentWithAncestorWithNonResChes/", false);
            uri.AppendPath(resGrpParentWithAncestorWithNonResChName, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Retrieves information. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="resGrpParentWithAncestorWithNonResChName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="resGrpParentWithAncestorWithNonResChName"/> is null. </exception>
        public async Task<Response<ResGrpParentWithAncestorWithNonResChData>> GetAsync(string resourceGroupName, string resGrpParentWithAncestorWithNonResChName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resGrpParentWithAncestorWithNonResChName == null)
            {
                throw new ArgumentNullException(nameof(resGrpParentWithAncestorWithNonResChName));
            }

            using var message = CreateGetRequest(resourceGroupName, resGrpParentWithAncestorWithNonResChName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ResGrpParentWithAncestorWithNonResChData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ResGrpParentWithAncestorWithNonResChData.DeserializeResGrpParentWithAncestorWithNonResChData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((ResGrpParentWithAncestorWithNonResChData)null, message.Response);
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Retrieves information. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="resGrpParentWithAncestorWithNonResChName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="resGrpParentWithAncestorWithNonResChName"/> is null. </exception>
        public Response<ResGrpParentWithAncestorWithNonResChData> Get(string resourceGroupName, string resGrpParentWithAncestorWithNonResChName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resGrpParentWithAncestorWithNonResChName == null)
            {
                throw new ArgumentNullException(nameof(resGrpParentWithAncestorWithNonResChName));
            }

            using var message = CreateGetRequest(resourceGroupName, resGrpParentWithAncestorWithNonResChName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ResGrpParentWithAncestorWithNonResChData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ResGrpParentWithAncestorWithNonResChData.DeserializeResGrpParentWithAncestorWithNonResChData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((ResGrpParentWithAncestorWithNonResChData)null, message.Response);
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetTestRequest(string resourceGroupName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.MgmtListMethods/resGrpParentWithAncestorWithNonResChes", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Lists all in a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> is null. </exception>
        public async Task<Response<ResGrpParentWithAncestorWithNonResChListResult>> GetTestAsync(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            using var message = CreateGetTestRequest(resourceGroupName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ResGrpParentWithAncestorWithNonResChListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ResGrpParentWithAncestorWithNonResChListResult.DeserializeResGrpParentWithAncestorWithNonResChListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Lists all in a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> is null. </exception>
        public Response<ResGrpParentWithAncestorWithNonResChListResult> GetTest(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            using var message = CreateGetTestRequest(resourceGroupName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ResGrpParentWithAncestorWithNonResChListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ResGrpParentWithAncestorWithNonResChListResult.DeserializeResGrpParentWithAncestorWithNonResChListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetNonResourceChildRequest(string resourceGroupName, string resGrpParentWithAncestorWithNonResChName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.MgmtListMethods/resGrpParentWithAncestorWithNonResChes/", false);
            uri.AppendPath(resGrpParentWithAncestorWithNonResChName, true);
            uri.AppendPath("/nonResourceChild", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Lists all. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="resGrpParentWithAncestorWithNonResChName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="resGrpParentWithAncestorWithNonResChName"/> is null. </exception>
        public async Task<Response<NonResourceChildListResult>> GetNonResourceChildAsync(string resourceGroupName, string resGrpParentWithAncestorWithNonResChName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resGrpParentWithAncestorWithNonResChName == null)
            {
                throw new ArgumentNullException(nameof(resGrpParentWithAncestorWithNonResChName));
            }

            using var message = CreateGetNonResourceChildRequest(resourceGroupName, resGrpParentWithAncestorWithNonResChName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        NonResourceChildListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = NonResourceChildListResult.DeserializeNonResourceChildListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Lists all. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="resGrpParentWithAncestorWithNonResChName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupName"/> or <paramref name="resGrpParentWithAncestorWithNonResChName"/> is null. </exception>
        public Response<NonResourceChildListResult> GetNonResourceChild(string resourceGroupName, string resGrpParentWithAncestorWithNonResChName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resGrpParentWithAncestorWithNonResChName == null)
            {
                throw new ArgumentNullException(nameof(resGrpParentWithAncestorWithNonResChName));
            }

            using var message = CreateGetNonResourceChildRequest(resourceGroupName, resGrpParentWithAncestorWithNonResChName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        NonResourceChildListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = NonResourceChildListResult.DeserializeNonResourceChildListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetAllBySubscriptionRequest(string expand)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/providers/Microsoft.MgmtListMethods/resGrpParentWithAncestorWithNonResChes", false);
            uri.AppendQuery("api-version", apiVersion, true);
            if (expand != null)
            {
                uri.AppendQuery("$expand", expand, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Lists all in a subscription. </summary>
        /// <param name="expand"> The expand expression to apply to the operation. Allowed values are &apos;instanceView&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async Task<Response<ResGrpParentWithAncestorWithNonResChListResult>> GetAllBySubscriptionAsync(string expand = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateGetAllBySubscriptionRequest(expand);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ResGrpParentWithAncestorWithNonResChListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ResGrpParentWithAncestorWithNonResChListResult.DeserializeResGrpParentWithAncestorWithNonResChListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Lists all in a subscription. </summary>
        /// <param name="expand"> The expand expression to apply to the operation. Allowed values are &apos;instanceView&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<ResGrpParentWithAncestorWithNonResChListResult> GetAllBySubscription(string expand = null, CancellationToken cancellationToken = default)
        {
            using var message = CreateGetAllBySubscriptionRequest(expand);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ResGrpParentWithAncestorWithNonResChListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ResGrpParentWithAncestorWithNonResChListResult.DeserializeResGrpParentWithAncestorWithNonResChListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetTestNextPageRequest(string nextLink, string resourceGroupName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Lists all in a resource group. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="resourceGroupName"/> is null. </exception>
        public async Task<Response<ResGrpParentWithAncestorWithNonResChListResult>> GetTestNextPageAsync(string nextLink, string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            using var message = CreateGetTestNextPageRequest(nextLink, resourceGroupName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ResGrpParentWithAncestorWithNonResChListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ResGrpParentWithAncestorWithNonResChListResult.DeserializeResGrpParentWithAncestorWithNonResChListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Lists all in a resource group. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="resourceGroupName"/> is null. </exception>
        public Response<ResGrpParentWithAncestorWithNonResChListResult> GetTestNextPage(string nextLink, string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            using var message = CreateGetTestNextPageRequest(nextLink, resourceGroupName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ResGrpParentWithAncestorWithNonResChListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ResGrpParentWithAncestorWithNonResChListResult.DeserializeResGrpParentWithAncestorWithNonResChListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetAllBySubscriptionNextPageRequest(string nextLink, string expand)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            return message;
        }

        /// <summary> Lists all in a subscription. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="expand"> The expand expression to apply to the operation. Allowed values are &apos;instanceView&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public async Task<Response<ResGrpParentWithAncestorWithNonResChListResult>> GetAllBySubscriptionNextPageAsync(string nextLink, string expand = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var message = CreateGetAllBySubscriptionNextPageRequest(nextLink, expand);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ResGrpParentWithAncestorWithNonResChListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ResGrpParentWithAncestorWithNonResChListResult.DeserializeResGrpParentWithAncestorWithNonResChListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
            }
        }

        /// <summary> Lists all in a subscription. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="expand"> The expand expression to apply to the operation. Allowed values are &apos;instanceView&apos;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> is null. </exception>
        public Response<ResGrpParentWithAncestorWithNonResChListResult> GetAllBySubscriptionNextPage(string nextLink, string expand = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            using var message = CreateGetAllBySubscriptionNextPageRequest(nextLink, expand);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ResGrpParentWithAncestorWithNonResChListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ResGrpParentWithAncestorWithNonResChListResult.DeserializeResGrpParentWithAncestorWithNonResChListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw _clientDiagnostics.CreateRequestFailedException(message.Response);
            }
        }
    }
}
