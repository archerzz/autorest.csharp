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

namespace MgmtListMethods
{
    /// <summary> A Class representing a ResGrpParentWithAncestorResource along with the instance operations that can be performed on it. </summary>
    public partial class ResGrpParentWithAncestorResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ResGrpParentWithAncestorResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string resGrpParentWithAncestorName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MgmtListMethods/resGrpParentWithAncestors/{resGrpParentWithAncestorName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _resGrpParentWithAncestorClientDiagnostics;
        private readonly ResGrpParentWithAncestorsRestOperations _resGrpParentWithAncestorRestClient;
        private readonly ResGrpParentWithAncestorData _data;

        /// <summary> Initializes a new instance of the <see cref="ResGrpParentWithAncestorResource"/> class for mocking. </summary>
        protected ResGrpParentWithAncestorResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ResGrpParentWithAncestorResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ResGrpParentWithAncestorResource(ArmClient client, ResGrpParentWithAncestorData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ResGrpParentWithAncestorResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ResGrpParentWithAncestorResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _resGrpParentWithAncestorClientDiagnostics = new ClientDiagnostics("MgmtListMethods", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string resGrpParentWithAncestorApiVersion);
            _resGrpParentWithAncestorRestClient = new ResGrpParentWithAncestorsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, resGrpParentWithAncestorApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.MgmtListMethods/resGrpParentWithAncestors";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ResGrpParentWithAncestorData Data
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MgmtListMethods/resGrpParentWithAncestors/{resGrpParentWithAncestorName}
        /// Operation Id: ResGrpParentWithAncestors_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ResGrpParentWithAncestorResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _resGrpParentWithAncestorClientDiagnostics.CreateScope("ResGrpParentWithAncestorResource.Get");
            scope.Start();
            try
            {
                var response = await _resGrpParentWithAncestorRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ResGrpParentWithAncestorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves information.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MgmtListMethods/resGrpParentWithAncestors/{resGrpParentWithAncestorName}
        /// Operation Id: ResGrpParentWithAncestors_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ResGrpParentWithAncestorResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _resGrpParentWithAncestorClientDiagnostics.CreateScope("ResGrpParentWithAncestorResource.Get");
            scope.Start();
            try
            {
                var response = _resGrpParentWithAncestorRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ResGrpParentWithAncestorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Add a tag to the current resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MgmtListMethods/resGrpParentWithAncestors/{resGrpParentWithAncestorName}
        /// Operation Id: ResGrpParentWithAncestors_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual async Task<Response<ResGrpParentWithAncestorResource>> AddTagAsync(string key, string value, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            using var scope = _resGrpParentWithAncestorClientDiagnostics.CreateScope("ResGrpParentWithAncestorResource.AddTag");
            scope.Start();
            try
            {
                var originalTags = await TagHelper.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.TagValues[key] = value;
                await TagHelper.CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _resGrpParentWithAncestorRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new ResGrpParentWithAncestorResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Add a tag to the current resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MgmtListMethods/resGrpParentWithAncestors/{resGrpParentWithAncestorName}
        /// Operation Id: ResGrpParentWithAncestors_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual Response<ResGrpParentWithAncestorResource> AddTag(string key, string value, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            using var scope = _resGrpParentWithAncestorClientDiagnostics.CreateScope("ResGrpParentWithAncestorResource.AddTag");
            scope.Start();
            try
            {
                var originalTags = TagHelper.Get(cancellationToken);
                originalTags.Value.Data.TagValues[key] = value;
                TagHelper.CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _resGrpParentWithAncestorRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                return Response.FromValue(new ResGrpParentWithAncestorResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MgmtListMethods/resGrpParentWithAncestors/{resGrpParentWithAncestorName}
        /// Operation Id: ResGrpParentWithAncestors_Get
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual async Task<Response<ResGrpParentWithAncestorResource>> SetTagsAsync(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tags, nameof(tags));

            using var scope = _resGrpParentWithAncestorClientDiagnostics.CreateScope("ResGrpParentWithAncestorResource.SetTags");
            scope.Start();
            try
            {
                await TagHelper.DeleteAsync(WaitUntil.Completed, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalTags = await TagHelper.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.TagValues.ReplaceWith(tags);
                await TagHelper.CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _resGrpParentWithAncestorRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new ResGrpParentWithAncestorResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MgmtListMethods/resGrpParentWithAncestors/{resGrpParentWithAncestorName}
        /// Operation Id: ResGrpParentWithAncestors_Get
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual Response<ResGrpParentWithAncestorResource> SetTags(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tags, nameof(tags));

            using var scope = _resGrpParentWithAncestorClientDiagnostics.CreateScope("ResGrpParentWithAncestorResource.SetTags");
            scope.Start();
            try
            {
                TagHelper.Delete(WaitUntil.Completed, cancellationToken: cancellationToken);
                var originalTags = TagHelper.Get(cancellationToken);
                originalTags.Value.Data.TagValues.ReplaceWith(tags);
                TagHelper.CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _resGrpParentWithAncestorRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                return Response.FromValue(new ResGrpParentWithAncestorResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MgmtListMethods/resGrpParentWithAncestors/{resGrpParentWithAncestorName}
        /// Operation Id: ResGrpParentWithAncestors_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual async Task<Response<ResGrpParentWithAncestorResource>> RemoveTagAsync(string key, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using var scope = _resGrpParentWithAncestorClientDiagnostics.CreateScope("ResGrpParentWithAncestorResource.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = await TagHelper.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.TagValues.Remove(key);
                await TagHelper.CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _resGrpParentWithAncestorRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new ResGrpParentWithAncestorResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MgmtListMethods/resGrpParentWithAncestors/{resGrpParentWithAncestorName}
        /// Operation Id: ResGrpParentWithAncestors_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual Response<ResGrpParentWithAncestorResource> RemoveTag(string key, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using var scope = _resGrpParentWithAncestorClientDiagnostics.CreateScope("ResGrpParentWithAncestorResource.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = TagHelper.Get(cancellationToken);
                originalTags.Value.Data.TagValues.Remove(key);
                TagHelper.CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _resGrpParentWithAncestorRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken);
                return Response.FromValue(new ResGrpParentWithAncestorResource(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
