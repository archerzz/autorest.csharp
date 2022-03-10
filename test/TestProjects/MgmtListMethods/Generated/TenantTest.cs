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
using Azure.ResourceManager.Core;

namespace MgmtListMethods
{
    /// <summary> A Class representing a TenantTest along with the instance operations that can be performed on it. </summary>
    public partial class TenantTest : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="TenantTest"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string tenantTestName)
        {
            var resourceId = $"/providers/Microsoft.Tenant/tenantTests/{tenantTestName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _tenantTestClientDiagnostics;
        private readonly TenantTestsRestOperations _tenantTestRestClient;
        private readonly TenantTestData _data;

        /// <summary> Initializes a new instance of the <see cref="TenantTest"/> class for mocking. </summary>
        protected TenantTest()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "TenantTest"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal TenantTest(ArmClient client, TenantTestData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="TenantTest"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal TenantTest(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _tenantTestClientDiagnostics = new ClientDiagnostics("MgmtListMethods", ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(ResourceType, out string tenantTestApiVersion);
            _tenantTestRestClient = new TenantTestsRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri, tenantTestApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Tenant/tenantTests";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual TenantTestData Data
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

        /// <summary> Gets a collection of TenantParentWithNonResChWithLocs in the TenantParentWithNonResChWithLoc. </summary>
        /// <returns> An object representing collection of TenantParentWithNonResChWithLocs and their operations over a TenantParentWithNonResChWithLoc. </returns>
        public virtual TenantParentWithNonResChWithLocCollection GetTenantParentWithNonResChWithLocs()
        {
            return GetCachedClient((Client) => new TenantParentWithNonResChWithLocCollection(Client, Id));
        }

        /// <summary>
        /// Retrieves information.
        /// Request Path: /providers/Microsoft.Tenant/tenantTests/{tenantTestName}/tenantParentWithNonResChWithLocs/{tenantParentWithNonResChWithLocName}
        /// Operation Id: TenantParentWithNonResChWithLocs_Get
        /// </summary>
        /// <param name="tenantParentWithNonResChWithLocName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tenantParentWithNonResChWithLocName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantParentWithNonResChWithLocName"/> is null. </exception>
        public virtual async Task<Response<TenantParentWithNonResChWithLoc>> GetTenantParentWithNonResChWithLocAsync(string tenantParentWithNonResChWithLocName, CancellationToken cancellationToken = default)
        {
            return await GetTenantParentWithNonResChWithLocs().GetAsync(tenantParentWithNonResChWithLocName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Retrieves information.
        /// Request Path: /providers/Microsoft.Tenant/tenantTests/{tenantTestName}/tenantParentWithNonResChWithLocs/{tenantParentWithNonResChWithLocName}
        /// Operation Id: TenantParentWithNonResChWithLocs_Get
        /// </summary>
        /// <param name="tenantParentWithNonResChWithLocName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tenantParentWithNonResChWithLocName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantParentWithNonResChWithLocName"/> is null. </exception>
        public virtual Response<TenantParentWithNonResChWithLoc> GetTenantParentWithNonResChWithLoc(string tenantParentWithNonResChWithLocName, CancellationToken cancellationToken = default)
        {
            return GetTenantParentWithNonResChWithLocs().Get(tenantParentWithNonResChWithLocName, cancellationToken);
        }

        /// <summary> Gets a collection of TenantParentWithNonResChes in the TenantParentWithNonResCh. </summary>
        /// <returns> An object representing collection of TenantParentWithNonResChes and their operations over a TenantParentWithNonResCh. </returns>
        public virtual TenantParentWithNonResChCollection GetTenantParentWithNonResChes()
        {
            return GetCachedClient((Client) => new TenantParentWithNonResChCollection(Client, Id));
        }

        /// <summary>
        /// Retrieves information.
        /// Request Path: /providers/Microsoft.Tenant/tenantTests/{tenantTestName}/tenantParentWithNonResChes/{tenantParentWithNonResChName}
        /// Operation Id: TenantParentWithNonResChes_Get
        /// </summary>
        /// <param name="tenantParentWithNonResChName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tenantParentWithNonResChName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantParentWithNonResChName"/> is null. </exception>
        public virtual async Task<Response<TenantParentWithNonResCh>> GetTenantParentWithNonResChAsync(string tenantParentWithNonResChName, CancellationToken cancellationToken = default)
        {
            return await GetTenantParentWithNonResChes().GetAsync(tenantParentWithNonResChName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Retrieves information.
        /// Request Path: /providers/Microsoft.Tenant/tenantTests/{tenantTestName}/tenantParentWithNonResChes/{tenantParentWithNonResChName}
        /// Operation Id: TenantParentWithNonResChes_Get
        /// </summary>
        /// <param name="tenantParentWithNonResChName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tenantParentWithNonResChName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantParentWithNonResChName"/> is null. </exception>
        public virtual Response<TenantParentWithNonResCh> GetTenantParentWithNonResCh(string tenantParentWithNonResChName, CancellationToken cancellationToken = default)
        {
            return GetTenantParentWithNonResChes().Get(tenantParentWithNonResChName, cancellationToken);
        }

        /// <summary> Gets a collection of TenantParentWithLocs in the TenantParentWithLoc. </summary>
        /// <returns> An object representing collection of TenantParentWithLocs and their operations over a TenantParentWithLoc. </returns>
        public virtual TenantParentWithLocCollection GetTenantParentWithLocs()
        {
            return GetCachedClient((Client) => new TenantParentWithLocCollection(Client, Id));
        }

        /// <summary>
        /// Retrieves information.
        /// Request Path: /providers/Microsoft.Tenant/tenantTests/{tenantTestName}/tenantParentWithLocs/{tenantParentWithLocName}
        /// Operation Id: TenantParentWithLocs_Get
        /// </summary>
        /// <param name="tenantParentWithLocName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tenantParentWithLocName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantParentWithLocName"/> is null. </exception>
        public virtual async Task<Response<TenantParentWithLoc>> GetTenantParentWithLocAsync(string tenantParentWithLocName, CancellationToken cancellationToken = default)
        {
            return await GetTenantParentWithLocs().GetAsync(tenantParentWithLocName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Retrieves information.
        /// Request Path: /providers/Microsoft.Tenant/tenantTests/{tenantTestName}/tenantParentWithLocs/{tenantParentWithLocName}
        /// Operation Id: TenantParentWithLocs_Get
        /// </summary>
        /// <param name="tenantParentWithLocName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tenantParentWithLocName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantParentWithLocName"/> is null. </exception>
        public virtual Response<TenantParentWithLoc> GetTenantParentWithLoc(string tenantParentWithLocName, CancellationToken cancellationToken = default)
        {
            return GetTenantParentWithLocs().Get(tenantParentWithLocName, cancellationToken);
        }

        /// <summary> Gets a collection of TenantParents in the TenantParent. </summary>
        /// <returns> An object representing collection of TenantParents and their operations over a TenantParent. </returns>
        public virtual TenantParentCollection GetTenantParents()
        {
            return GetCachedClient((Client) => new TenantParentCollection(Client, Id));
        }

        /// <summary>
        /// Retrieves information.
        /// Request Path: /providers/Microsoft.Tenant/tenantTests/{tenantTestName}/tenantParents/{tenantParentName}
        /// Operation Id: TenantParents_Get
        /// </summary>
        /// <param name="tenantParentName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tenantParentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantParentName"/> is null. </exception>
        public virtual async Task<Response<TenantParent>> GetTenantParentAsync(string tenantParentName, CancellationToken cancellationToken = default)
        {
            return await GetTenantParents().GetAsync(tenantParentName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Retrieves information.
        /// Request Path: /providers/Microsoft.Tenant/tenantTests/{tenantTestName}/tenantParents/{tenantParentName}
        /// Operation Id: TenantParents_Get
        /// </summary>
        /// <param name="tenantParentName"> Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="tenantParentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantParentName"/> is null. </exception>
        public virtual Response<TenantParent> GetTenantParent(string tenantParentName, CancellationToken cancellationToken = default)
        {
            return GetTenantParents().Get(tenantParentName, cancellationToken);
        }

        /// <summary>
        /// Gets a billing account by its ID.
        /// Request Path: /providers/Microsoft.Tenant/tenantTests/{tenantTestName}
        /// Operation Id: TenantTests_Get
        /// </summary>
        /// <param name="expand"> May be used to expand the soldTo, invoice sections and billing profiles. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<TenantTest>> GetAsync(string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _tenantTestClientDiagnostics.CreateScope("TenantTest.Get");
            scope.Start();
            try
            {
                var response = await _tenantTestRestClient.GetAsync(Id.Name, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TenantTest(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a billing account by its ID.
        /// Request Path: /providers/Microsoft.Tenant/tenantTests/{tenantTestName}
        /// Operation Id: TenantTests_Get
        /// </summary>
        /// <param name="expand"> May be used to expand the soldTo, invoice sections and billing profiles. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<TenantTest> Get(string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _tenantTestClientDiagnostics.CreateScope("TenantTest.Get");
            scope.Start();
            try
            {
                var response = _tenantTestRestClient.Get(Id.Name, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new TenantTest(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Add a tag to the current resource.
        /// Request Path: /providers/Microsoft.Tenant/tenantTests/{tenantTestName}
        /// Operation Id: TenantTests_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual async Task<Response<TenantTest>> AddTagAsync(string key, string value, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            using var scope = _tenantTestClientDiagnostics.CreateScope("TenantTest.AddTag");
            scope.Start();
            try
            {
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.TagValues[key] = value;
                await TagResource.CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _tenantTestRestClient.GetAsync(Id.Name, null, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new TenantTest(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Add a tag to the current resource.
        /// Request Path: /providers/Microsoft.Tenant/tenantTests/{tenantTestName}
        /// Operation Id: TenantTests_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="value"> The value for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public virtual Response<TenantTest> AddTag(string key, string value, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            using var scope = _tenantTestClientDiagnostics.CreateScope("TenantTest.AddTag");
            scope.Start();
            try
            {
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.TagValues[key] = value;
                TagResource.CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _tenantTestRestClient.Get(Id.Name, null, cancellationToken);
                return Response.FromValue(new TenantTest(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// Request Path: /providers/Microsoft.Tenant/tenantTests/{tenantTestName}
        /// Operation Id: TenantTests_Get
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual async Task<Response<TenantTest>> SetTagsAsync(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tags, nameof(tags));

            using var scope = _tenantTestClientDiagnostics.CreateScope("TenantTest.SetTags");
            scope.Start();
            try
            {
                await TagResource.DeleteAsync(WaitUntil.Completed, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.TagValues.ReplaceWith(tags);
                await TagResource.CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _tenantTestRestClient.GetAsync(Id.Name, null, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new TenantTest(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Replace the tags on the resource with the given set.
        /// Request Path: /providers/Microsoft.Tenant/tenantTests/{tenantTestName}
        /// Operation Id: TenantTests_Get
        /// </summary>
        /// <param name="tags"> The set of tags to use as replacement. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tags"/> is null. </exception>
        public virtual Response<TenantTest> SetTags(IDictionary<string, string> tags, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tags, nameof(tags));

            using var scope = _tenantTestClientDiagnostics.CreateScope("TenantTest.SetTags");
            scope.Start();
            try
            {
                TagResource.Delete(WaitUntil.Completed, cancellationToken: cancellationToken);
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.TagValues.ReplaceWith(tags);
                TagResource.CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _tenantTestRestClient.Get(Id.Name, null, cancellationToken);
                return Response.FromValue(new TenantTest(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// Request Path: /providers/Microsoft.Tenant/tenantTests/{tenantTestName}
        /// Operation Id: TenantTests_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual async Task<Response<TenantTest>> RemoveTagAsync(string key, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using var scope = _tenantTestClientDiagnostics.CreateScope("TenantTest.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = await TagResource.GetAsync(cancellationToken).ConfigureAwait(false);
                originalTags.Value.Data.TagValues.Remove(key);
                await TagResource.CreateOrUpdateAsync(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken).ConfigureAwait(false);
                var originalResponse = await _tenantTestRestClient.GetAsync(Id.Name, null, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new TenantTest(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Removes a tag by key from the resource.
        /// Request Path: /providers/Microsoft.Tenant/tenantTests/{tenantTestName}
        /// Operation Id: TenantTests_Get
        /// </summary>
        /// <param name="key"> The key for the tag. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public virtual Response<TenantTest> RemoveTag(string key, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(key, nameof(key));

            using var scope = _tenantTestClientDiagnostics.CreateScope("TenantTest.RemoveTag");
            scope.Start();
            try
            {
                var originalTags = TagResource.Get(cancellationToken);
                originalTags.Value.Data.TagValues.Remove(key);
                TagResource.CreateOrUpdate(WaitUntil.Completed, originalTags.Value.Data, cancellationToken: cancellationToken);
                var originalResponse = _tenantTestRestClient.Get(Id.Name, null, cancellationToken);
                return Response.FromValue(new TenantTest(Client, originalResponse.Value), originalResponse.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
