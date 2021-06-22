// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;

namespace SubscriptionExtensions
{
    /// <summary> Extension methods for convenient access on SubscriptionOperations in a client. </summary>
    public static partial class SubscriptionExtensions
    {
        #region Toaster
        /// <summary> Gets an object representing a ToasterContainer along with the instance operations that can be performed on it. </summary>
        /// <param name="subscription"> The <see cref="SubscriptionOperations" /> instance the method will execute against. </param>
        public static ToasterContainer GetToasterContainer(this SubscriptionOperations subscription)
        {
            return new ToasterContainer(subscription);
        }
        #endregion

        #region Oven
        private static OvensRestOperations GetOvensRestOperations(ClientDiagnostics clientDiagnostics, TokenCredential credential, ArmClientOptions clientOptions, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            return new OvensRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint);
        }

        /// <summary> Lists the Ovens for this Azure.ResourceManager.Core.SubscriptionOperations. </summary>
        /// <param name="subscription"> The <see cref="SubscriptionOperations" /> instance the method will execute against. </param>
        /// <param name="statusOnly"> statusOnly=true enables fetching run time status of all Virtual Machines in the subscription. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <return> A collection of resource operations that may take multiple service requests to iterate over. </return>
        public static AsyncPageable<Oven> ListOvenAsync(this SubscriptionOperations subscription, string statusOnly = null, CancellationToken cancellationToken = default)
        {
            return subscription.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                var restOperations = GetOvensRestOperations(clientDiagnostics, credential, options, pipeline, subscription.Id.SubscriptionId, baseUri);
                async Task<Page<Oven>> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("OvenOperations.ListAll");
                    scope.Start();
                    try
                    {
                        var response = await restOperations.ListAllAsync(statusOnly, cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value.Select(value => new Oven(subscription, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                async Task<Page<Oven>> NextPageFunc(string nextLink, int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("OvenOperations.ListAll");
                    scope.Start();
                    try
                    {
                        var response = await restOperations.ListAllNextPageAsync(nextLink, statusOnly, cancellationToken: cancellationToken).ConfigureAwait(false);
                        return Page.FromValues(response.Value.Value.Select(value => new Oven(subscription, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
            }
            );
        }

        /// <summary> Lists the Ovens for this Azure.ResourceManager.Core.SubscriptionOperations. </summary>
        /// <param name="subscription"> The <see cref="SubscriptionOperations" /> instance the method will execute against. </param>
        /// <param name="statusOnly"> statusOnly=true enables fetching run time status of all Virtual Machines in the subscription. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <return> A collection of resource operations that may take multiple service requests to iterate over. </return>
        public static Pageable<Oven> ListOven(this SubscriptionOperations subscription, string statusOnly = null, CancellationToken cancellationToken = default)
        {
            return subscription.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                var restOperations = GetOvensRestOperations(clientDiagnostics, credential, options, pipeline, subscription.Id.SubscriptionId, baseUri);
                Page<Oven> FirstPageFunc(int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("OvenOperations.ListAll");
                    scope.Start();
                    try
                    {
                        var response = restOperations.ListAll(statusOnly, cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value.Select(value => new Oven(subscription, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                Page<Oven> NextPageFunc(string nextLink, int? pageSizeHint)
                {
                    using var scope = clientDiagnostics.CreateScope("OvenOperations.ListAll");
                    scope.Start();
                    try
                    {
                        var response = restOperations.ListAllNextPage(nextLink, statusOnly, cancellationToken: cancellationToken);
                        return Page.FromValues(response.Value.Value.Select(value => new Oven(subscription, value)), response.Value.NextLink, response.GetRawResponse());
                    }
                    catch (Exception e)
                    {
                        scope.Failed(e);
                        throw;
                    }
                }
                return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
            }
            );
        }

        /// <summary> Filters the list of Ovens for a Azure.ResourceManager.Core.SubscriptionOperations represented as generic resources. </summary>
        /// <param name="subscription"> The <see cref="SubscriptionOperations" /> instance the method will execute against. </param>
        /// <param name="filter"> The string to filter the list. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <return> A collection of resource operations that may take multiple service requests to iterate over. </return>
        public static AsyncPageable<GenericResource> ListOvenByNameAsync(this SubscriptionOperations subscription, string filter, int? top, CancellationToken cancellationToken = default)
        {
            ResourceFilterCollection filters = new(OvenOperations.ResourceType);
            filters.SubstringFilter = filter;
            return ResourceListOperations.ListAtContextAsync(subscription, filters, top, cancellationToken);
        }

        /// <summary> Filters the list of Ovens for a Azure.ResourceManager.Core.SubscriptionOperations represented as generic resources. </summary>
        /// <param name="subscription"> The <see cref="SubscriptionOperations" /> instance the method will execute against. </param>
        /// <param name="filter"> The string to filter the list. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <return> A collection of resource operations that may take multiple service requests to iterate over. </return>
        public static Pageable<GenericResource> ListOvenByName(this SubscriptionOperations subscription, string filter, int? top, CancellationToken cancellationToken = default)
        {
            ResourceFilterCollection filters = new(OvenOperations.ResourceType);
            filters.SubstringFilter = filter;
            return ResourceListOperations.ListAtContext(subscription, filters, top, cancellationToken);
        }
        #endregion
    }
}