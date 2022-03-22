// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using MgmtListMethods.Models;

namespace MgmtListMethods
{
    /// <summary> A Class representing a FakeParentWithAncestorWithNonResChWithLocResource along with the instance operations that can be performed on it. </summary>
    public partial class FakeParentWithAncestorWithNonResChWithLocResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="FakeParentWithAncestorWithNonResChWithLocResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string fakeName, string fakeParentWithAncestorWithNonResChWithLocName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}/fakeParentWithAncestorWithNonResChWithLocs/{fakeParentWithAncestorWithNonResChWithLocName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _fakeParentWithAncestorWithNonResChWithLocClientDiagnostics;
        private readonly FakeParentWithAncestorWithNonResChWithLocsRestOperations _fakeParentWithAncestorWithNonResChWithLocRestClient;
        private readonly FakeParentWithAncestorWithNonResChWithLocData _data;

        /// <summary> Initializes a new instance of the <see cref="FakeParentWithAncestorWithNonResChWithLocResource"/> class for mocking. </summary>
        protected FakeParentWithAncestorWithNonResChWithLocResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "FakeParentWithAncestorWithNonResChWithLocResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal FakeParentWithAncestorWithNonResChWithLocResource(ArmClient client, FakeParentWithAncestorWithNonResChWithLocData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="FakeParentWithAncestorWithNonResChWithLocResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal FakeParentWithAncestorWithNonResChWithLocResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _fakeParentWithAncestorWithNonResChWithLocClientDiagnostics = new ClientDiagnostics("MgmtListMethods", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string fakeParentWithAncestorWithNonResChWithLocApiVersion);
            _fakeParentWithAncestorWithNonResChWithLocRestClient = new FakeParentWithAncestorWithNonResChWithLocsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, fakeParentWithAncestorWithNonResChWithLocApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Fake/fakes/fakeParentWithAncestorWithNonResChWithLocs";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual FakeParentWithAncestorWithNonResChWithLocData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Retrieves information.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}/fakeParentWithAncestorWithNonResChWithLocs/{fakeParentWithAncestorWithNonResChWithLocName}
        /// Operation Id: FakeParentWithAncestorWithNonResChWithLocs_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<FakeParentWithAncestorWithNonResChWithLocResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _fakeParentWithAncestorWithNonResChWithLocClientDiagnostics.CreateScope("FakeParentWithAncestorWithNonResChWithLocResource.Get");
            scope.Start();
            try
            {
                var response = await _fakeParentWithAncestorWithNonResChWithLocRestClient.GetAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FakeParentWithAncestorWithNonResChWithLocResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves information.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}/fakeParentWithAncestorWithNonResChWithLocs/{fakeParentWithAncestorWithNonResChWithLocName}
        /// Operation Id: FakeParentWithAncestorWithNonResChWithLocs_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<FakeParentWithAncestorWithNonResChWithLocResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _fakeParentWithAncestorWithNonResChWithLocClientDiagnostics.CreateScope("FakeParentWithAncestorWithNonResChWithLocResource.Get");
            scope.Start();
            try
            {
                var response = _fakeParentWithAncestorWithNonResChWithLocRestClient.Get(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FakeParentWithAncestorWithNonResChWithLocResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}/fakeParentWithAncestorWithNonResChWithLocs/{fakeParentWithAncestorWithNonResChWithLocName}/nonResourceChild
        /// Operation Id: FakeParentWithAncestorWithNonResChWithLocs_ListNonResourceChild
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NonResourceChild" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NonResourceChild> GetNonResourceChildAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<NonResourceChild>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _fakeParentWithAncestorWithNonResChWithLocClientDiagnostics.CreateScope("FakeParentWithAncestorWithNonResChWithLocResource.GetNonResourceChild");
                scope.Start();
                try
                {
                    var response = await _fakeParentWithAncestorWithNonResChWithLocRestClient.ListNonResourceChildAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Lists all.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}/fakeParentWithAncestorWithNonResChWithLocs/{fakeParentWithAncestorWithNonResChWithLocName}/nonResourceChild
        /// Operation Id: FakeParentWithAncestorWithNonResChWithLocs_ListNonResourceChild
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NonResourceChild" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NonResourceChild> GetNonResourceChild(CancellationToken cancellationToken = default)
        {
            Page<NonResourceChild> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _fakeParentWithAncestorWithNonResChWithLocClientDiagnostics.CreateScope("FakeParentWithAncestorWithNonResChWithLocResource.GetNonResourceChild");
                scope.Start();
                try
                {
                    var response = _fakeParentWithAncestorWithNonResChWithLocRestClient.ListNonResourceChild(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Add a tag to the current resource.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}/fakeParentWithAncestorWithNonResChWithLocs/{fakeParentWithAncestorWithNonResChWithLocName}
        /// Operation Id: FakeParentWithAncestorWithNonResChWithLocs_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual async Task<Response<FakeParentWithAncestorWithNonResChWithLocResource>> AddTagAsync(string key, string value, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            using var scope = _fakeParentWithAncestorWithNonResChWithLocClientDiagnostics.CreateScope("FakeParentWithAncestorWithNonResChWithLocResource.AddTag");
            scope.Start();
            try
            {
                var originalTags = await TagHelper.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.TagValues[key] = value;
                await TagHelper.CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _fakeParentWithAncestorWithNonResChWithLocRestClient.GetAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new FakeParentWithAncestorWithNonResChWithLocResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Add a tag to the current resource.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}/fakeParentWithAncestorWithNonResChWithLocs/{fakeParentWithAncestorWithNonResChWithLocName}
        /// Operation Id: FakeParentWithAncestorWithNonResChWithLocs_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual Response<FakeParentWithAncestorWithNonResChWithLocResource> AddTag(string key, string value, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            using var scope = _fakeParentWithAncestorWithNonResChWithLocClientDiagnostics.CreateScope("FakeParentWithAncestorWithNonResChWithLocResource.AddTag");
            scope.Start();
            try
            {
                var originalTags = TagHelper.Get(cancellationToken);
                originalTags.Value.Data.TagValues[key] = value;
                TagHelper.CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _fakeParentWithAncestorWithNonResChWithLocRestClient.Get(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken);
                return Response.FromValue(new FakeParentWithAncestorWithNonResChWithLocResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}/fakeParentWithAncestorWithNonResChWithLocs/{fakeParentWithAncestorWithNonResChWithLocName}
        /// Operation Id: FakeParentWithAncestorWithNonResChWithLocs_Get
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual async Task<Response<FakeParentWithAncestorWithNonResChWithLocResource>> SetTagsAsync(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tags, nameof(tags));

            using var scope = _fakeParentWithAncestorWithNonResChWithLocClientDiagnostics.CreateScope("FakeParentWithAncestorWithNonResChWithLocResource.SetTags");
            scope.Start();
            try
            {
                await TagHelper.DeleteAsync(WaitUntil.Completed, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalTags = await TagHelper.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.TagValues.ReplaceWith(tags);
                await TagHelper.CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _fakeParentWithAncestorWithNonResChWithLocRestClient.GetAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new FakeParentWithAncestorWithNonResChWithLocResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}/fakeParentWithAncestorWithNonResChWithLocs/{fakeParentWithAncestorWithNonResChWithLocName}
        /// Operation Id: FakeParentWithAncestorWithNonResChWithLocs_Get
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual Response<FakeParentWithAncestorWithNonResChWithLocResource> SetTags(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tags, nameof(tags));

            using var scope = _fakeParentWithAncestorWithNonResChWithLocClientDiagnostics.CreateScope("FakeParentWithAncestorWithNonResChWithLocResource.SetTags");
            scope.Start();
            try
            {
                TagHelper.Delete(WaitUntil.Completed, cancellationToken: cancellationToken);
                var originalTags = TagHelper.Get(cancellationToken);
                originalTags.Value.Data.TagValues.ReplaceWith(tags);
                TagHelper.CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _fakeParentWithAncestorWithNonResChWithLocRestClient.Get(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken);
                return Response.FromValue(new FakeParentWithAncestorWithNonResChWithLocResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}/fakeParentWithAncestorWithNonResChWithLocs/{fakeParentWithAncestorWithNonResChWithLocName}
        /// Operation Id: FakeParentWithAncestorWithNonResChWithLocs_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual async Task<Response<FakeParentWithAncestorWithNonResChWithLocResource>> RemoveTagAsync(string key, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using var scope = _fakeParentWithAncestorWithNonResChWithLocClientDiagnostics.CreateScope("FakeParentWithAncestorWithNonResChWithLocResource.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = await TagHelper.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.TagValues.Remove(key);
                await TagHelper.CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _fakeParentWithAncestorWithNonResChWithLocRestClient.GetAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new FakeParentWithAncestorWithNonResChWithLocResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Fake/fakes/{fakeName}/fakeParentWithAncestorWithNonResChWithLocs/{fakeParentWithAncestorWithNonResChWithLocName}
        /// Operation Id: FakeParentWithAncestorWithNonResChWithLocs_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual Response<FakeParentWithAncestorWithNonResChWithLocResource> RemoveTag(string key, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using var scope = _fakeParentWithAncestorWithNonResChWithLocClientDiagnostics.CreateScope("FakeParentWithAncestorWithNonResChWithLocResource.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = TagHelper.Get(cancellationToken);
                originalTags.Value.Data.TagValues.Remove(key);
                TagHelper.CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _fakeParentWithAncestorWithNonResChWithLocRestClient.Get(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken);
                return Response.FromValue(new FakeParentWithAncestorWithNonResChWithLocResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
