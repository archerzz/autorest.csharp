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
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using ExactMatchFlattenInheritance.Models;

namespace ExactMatchFlattenInheritance
{
    /// <summary> A class to add extension methods to ResourceGroup. </summary>
    internal partial class ResourceGroupExtensionClient : ArmResource
    {
        private ClientDiagnostics _azureResourceFlattenModel2sClientDiagnostics;
        private AzureResourceFlattenModel2SRestOperations _azureResourceFlattenModel2sRestClient;
        private ClientDiagnostics _azureResourceFlattenModel3sClientDiagnostics;
        private AzureResourceFlattenModel3SRestOperations _azureResourceFlattenModel3sRestClient;
        private ClientDiagnostics _azureResourceFlattenModel4sClientDiagnostics;
        private AzureResourceFlattenModel4SRestOperations _azureResourceFlattenModel4sRestClient;
        private ClientDiagnostics _azureResourceFlattenModel5sClientDiagnostics;
        private AzureResourceFlattenModel5SRestOperations _azureResourceFlattenModel5sRestClient;

        /// <summary> Initializes a new instance of the <see cref="ResourceGroupExtensionClient"/> class for mocking. </summary>
        protected ResourceGroupExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ResourceGroupExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ResourceGroupExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics AzureResourceFlattenModel2sClientDiagnostics => _azureResourceFlattenModel2sClientDiagnostics ??= new ClientDiagnostics("ExactMatchFlattenInheritance", ProviderConstants.DefaultProviderNamespace, DiagnosticOptions);
        private AzureResourceFlattenModel2SRestOperations AzureResourceFlattenModel2sRestClient => _azureResourceFlattenModel2sRestClient ??= new AzureResourceFlattenModel2SRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri);
        private ClientDiagnostics AzureResourceFlattenModel3sClientDiagnostics => _azureResourceFlattenModel3sClientDiagnostics ??= new ClientDiagnostics("ExactMatchFlattenInheritance", ProviderConstants.DefaultProviderNamespace, DiagnosticOptions);
        private AzureResourceFlattenModel3SRestOperations AzureResourceFlattenModel3sRestClient => _azureResourceFlattenModel3sRestClient ??= new AzureResourceFlattenModel3SRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri);
        private ClientDiagnostics AzureResourceFlattenModel4sClientDiagnostics => _azureResourceFlattenModel4sClientDiagnostics ??= new ClientDiagnostics("ExactMatchFlattenInheritance", ProviderConstants.DefaultProviderNamespace, DiagnosticOptions);
        private AzureResourceFlattenModel4SRestOperations AzureResourceFlattenModel4sRestClient => _azureResourceFlattenModel4sRestClient ??= new AzureResourceFlattenModel4SRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri);
        private ClientDiagnostics AzureResourceFlattenModel5sClientDiagnostics => _azureResourceFlattenModel5sClientDiagnostics ??= new ClientDiagnostics("ExactMatchFlattenInheritance", ProviderConstants.DefaultProviderNamespace, DiagnosticOptions);
        private AzureResourceFlattenModel5SRestOperations AzureResourceFlattenModel5sRestClient => _azureResourceFlattenModel5sRestClient ??= new AzureResourceFlattenModel5SRestOperations(Pipeline, DiagnosticOptions.ApplicationId, BaseUri);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of AzureResourceFlattenModel1Resources in the AzureResourceFlattenModel1Resource. </summary>
        /// <returns> An object representing collection of AzureResourceFlattenModel1Resources and their operations over a AzureResourceFlattenModel1Resource. </returns>
        public virtual AzureResourceFlattenModel1Collection GetAzureResourceFlattenModel1Resources()
        {
            return new AzureResourceFlattenModel1Collection(Client, Id);
        }

        /// <summary> Gets a collection of CustomModel2Resources in the CustomModel2Resource. </summary>
        /// <returns> An object representing collection of CustomModel2Resources and their operations over a CustomModel2Resource. </returns>
        public virtual CustomModel2Collection GetCustomModel2Resources()
        {
            return new CustomModel2Collection(Client, Id);
        }

        /// <summary> Gets a collection of CustomModel3Resources in the CustomModel3Resource. </summary>
        /// <returns> An object representing collection of CustomModel3Resources and their operations over a CustomModel3Resource. </returns>
        public virtual CustomModel3Collection GetCustomModel3Resources()
        {
            return new CustomModel3Collection(Client, Id);
        }

        /// <summary>
        /// Get an AzureResourceFlattenModel2.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/azureResourceFlattenModel2s
        /// Operation Id: AzureResourceFlattenModel2s_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AzureResourceFlattenModel2" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AzureResourceFlattenModel2> GetAzureResourceFlattenModel2sAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<AzureResourceFlattenModel2>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = AzureResourceFlattenModel2sClientDiagnostics.CreateScope("ResourceGroupExtensionClient.GetAzureResourceFlattenModel2s");
                scope.Start();
                try
                {
                    var response = await AzureResourceFlattenModel2sRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Get an AzureResourceFlattenModel2.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/azureResourceFlattenModel2s
        /// Operation Id: AzureResourceFlattenModel2s_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AzureResourceFlattenModel2" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AzureResourceFlattenModel2> GetAzureResourceFlattenModel2s(CancellationToken cancellationToken = default)
        {
            Page<AzureResourceFlattenModel2> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = AzureResourceFlattenModel2sClientDiagnostics.CreateScope("ResourceGroupExtensionClient.GetAzureResourceFlattenModel2s");
                scope.Start();
                try
                {
                    var response = AzureResourceFlattenModel2sRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
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
        /// Create or update an AzureResourceFlattenModel2.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/azureResourceFlattenModel2s/{name}
        /// Operation Id: AzureResourceFlattenModel2s_Put
        /// </summary>
        /// <param name="name"> The String to use. </param>
        /// <param name="parameters"> The AzureResourceFlattenModel2 to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AzureResourceFlattenModel2>> PutAzureResourceFlattenModel2Async(string name, AzureResourceFlattenModel2 parameters, CancellationToken cancellationToken = default)
        {
            using var scope = AzureResourceFlattenModel2sClientDiagnostics.CreateScope("ResourceGroupExtensionClient.PutAzureResourceFlattenModel2");
            scope.Start();
            try
            {
                var response = await AzureResourceFlattenModel2sRestClient.PutAsync(Id.SubscriptionId, Id.ResourceGroupName, name, parameters, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create or update an AzureResourceFlattenModel2.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/azureResourceFlattenModel2s/{name}
        /// Operation Id: AzureResourceFlattenModel2s_Put
        /// </summary>
        /// <param name="name"> The String to use. </param>
        /// <param name="parameters"> The AzureResourceFlattenModel2 to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AzureResourceFlattenModel2> PutAzureResourceFlattenModel2(string name, AzureResourceFlattenModel2 parameters, CancellationToken cancellationToken = default)
        {
            using var scope = AzureResourceFlattenModel2sClientDiagnostics.CreateScope("ResourceGroupExtensionClient.PutAzureResourceFlattenModel2");
            scope.Start();
            try
            {
                var response = AzureResourceFlattenModel2sRestClient.Put(Id.SubscriptionId, Id.ResourceGroupName, name, parameters, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get an AzureResourceFlattenModel2.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/azureResourceFlattenModel2s/{name}
        /// Operation Id: AzureResourceFlattenModel2s_Get
        /// </summary>
        /// <param name="name"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AzureResourceFlattenModel2>> GetAzureResourceFlattenModel2Async(string name, CancellationToken cancellationToken = default)
        {
            using var scope = AzureResourceFlattenModel2sClientDiagnostics.CreateScope("ResourceGroupExtensionClient.GetAzureResourceFlattenModel2");
            scope.Start();
            try
            {
                var response = await AzureResourceFlattenModel2sRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get an AzureResourceFlattenModel2.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/azureResourceFlattenModel2s/{name}
        /// Operation Id: AzureResourceFlattenModel2s_Get
        /// </summary>
        /// <param name="name"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AzureResourceFlattenModel2> GetAzureResourceFlattenModel2(string name, CancellationToken cancellationToken = default)
        {
            using var scope = AzureResourceFlattenModel2sClientDiagnostics.CreateScope("ResourceGroupExtensionClient.GetAzureResourceFlattenModel2");
            scope.Start();
            try
            {
                var response = AzureResourceFlattenModel2sRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get an AzureResourceFlattenModel3.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/azureResourceFlattenModel3s
        /// Operation Id: AzureResourceFlattenModel3s_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AzureResourceFlattenModel3" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AzureResourceFlattenModel3> GetAzureResourceFlattenModel3sAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<AzureResourceFlattenModel3>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = AzureResourceFlattenModel3sClientDiagnostics.CreateScope("ResourceGroupExtensionClient.GetAzureResourceFlattenModel3s");
                scope.Start();
                try
                {
                    var response = await AzureResourceFlattenModel3sRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Get an AzureResourceFlattenModel3.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/azureResourceFlattenModel3s
        /// Operation Id: AzureResourceFlattenModel3s_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AzureResourceFlattenModel3" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AzureResourceFlattenModel3> GetAzureResourceFlattenModel3s(CancellationToken cancellationToken = default)
        {
            Page<AzureResourceFlattenModel3> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = AzureResourceFlattenModel3sClientDiagnostics.CreateScope("ResourceGroupExtensionClient.GetAzureResourceFlattenModel3s");
                scope.Start();
                try
                {
                    var response = AzureResourceFlattenModel3sRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
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
        /// Create or update an AzureResourceFlattenModel3.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/azureResourceFlattenModel3s/{name}
        /// Operation Id: AzureResourceFlattenModel3s_Put
        /// </summary>
        /// <param name="name"> The String to use. </param>
        /// <param name="parameters"> The AzureResourceFlattenModel3 to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AzureResourceFlattenModel3>> PutAzureResourceFlattenModel3Async(string name, AzureResourceFlattenModel3 parameters, CancellationToken cancellationToken = default)
        {
            using var scope = AzureResourceFlattenModel3sClientDiagnostics.CreateScope("ResourceGroupExtensionClient.PutAzureResourceFlattenModel3");
            scope.Start();
            try
            {
                var response = await AzureResourceFlattenModel3sRestClient.PutAsync(Id.SubscriptionId, Id.ResourceGroupName, name, parameters, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create or update an AzureResourceFlattenModel3.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/azureResourceFlattenModel3s/{name}
        /// Operation Id: AzureResourceFlattenModel3s_Put
        /// </summary>
        /// <param name="name"> The String to use. </param>
        /// <param name="parameters"> The AzureResourceFlattenModel3 to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AzureResourceFlattenModel3> PutAzureResourceFlattenModel3(string name, AzureResourceFlattenModel3 parameters, CancellationToken cancellationToken = default)
        {
            using var scope = AzureResourceFlattenModel3sClientDiagnostics.CreateScope("ResourceGroupExtensionClient.PutAzureResourceFlattenModel3");
            scope.Start();
            try
            {
                var response = AzureResourceFlattenModel3sRestClient.Put(Id.SubscriptionId, Id.ResourceGroupName, name, parameters, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get an AzureResourceFlattenModel3.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/azureResourceFlattenModel3s/{name}
        /// Operation Id: AzureResourceFlattenModel3s_Get
        /// </summary>
        /// <param name="name"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AzureResourceFlattenModel3>> GetAzureResourceFlattenModel3Async(string name, CancellationToken cancellationToken = default)
        {
            using var scope = AzureResourceFlattenModel3sClientDiagnostics.CreateScope("ResourceGroupExtensionClient.GetAzureResourceFlattenModel3");
            scope.Start();
            try
            {
                var response = await AzureResourceFlattenModel3sRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get an AzureResourceFlattenModel3.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/azureResourceFlattenModel3s/{name}
        /// Operation Id: AzureResourceFlattenModel3s_Get
        /// </summary>
        /// <param name="name"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AzureResourceFlattenModel3> GetAzureResourceFlattenModel3(string name, CancellationToken cancellationToken = default)
        {
            using var scope = AzureResourceFlattenModel3sClientDiagnostics.CreateScope("ResourceGroupExtensionClient.GetAzureResourceFlattenModel3");
            scope.Start();
            try
            {
                var response = AzureResourceFlattenModel3sRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get an AzureResourceFlattenModel4.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/azureResourceFlattenModel4s
        /// Operation Id: AzureResourceFlattenModel4s_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AzureResourceFlattenModel4" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AzureResourceFlattenModel4> GetAzureResourceFlattenModel4sAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<AzureResourceFlattenModel4>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = AzureResourceFlattenModel4sClientDiagnostics.CreateScope("ResourceGroupExtensionClient.GetAzureResourceFlattenModel4s");
                scope.Start();
                try
                {
                    var response = await AzureResourceFlattenModel4sRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Get an AzureResourceFlattenModel4.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/azureResourceFlattenModel4s
        /// Operation Id: AzureResourceFlattenModel4s_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AzureResourceFlattenModel4" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AzureResourceFlattenModel4> GetAzureResourceFlattenModel4s(CancellationToken cancellationToken = default)
        {
            Page<AzureResourceFlattenModel4> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = AzureResourceFlattenModel4sClientDiagnostics.CreateScope("ResourceGroupExtensionClient.GetAzureResourceFlattenModel4s");
                scope.Start();
                try
                {
                    var response = AzureResourceFlattenModel4sRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
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
        /// Create or update an AzureResourceFlattenModel4.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/azureResourceFlattenModel4s/{name}
        /// Operation Id: AzureResourceFlattenModel4s_Put
        /// </summary>
        /// <param name="name"> The String to use. </param>
        /// <param name="parameters"> The AzureResourceFlattenModel4 to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AzureResourceFlattenModel4>> PutAzureResourceFlattenModel4Async(string name, AzureResourceFlattenModel4 parameters, CancellationToken cancellationToken = default)
        {
            using var scope = AzureResourceFlattenModel4sClientDiagnostics.CreateScope("ResourceGroupExtensionClient.PutAzureResourceFlattenModel4");
            scope.Start();
            try
            {
                var response = await AzureResourceFlattenModel4sRestClient.PutAsync(Id.SubscriptionId, Id.ResourceGroupName, name, parameters, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create or update an AzureResourceFlattenModel4.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/azureResourceFlattenModel4s/{name}
        /// Operation Id: AzureResourceFlattenModel4s_Put
        /// </summary>
        /// <param name="name"> The String to use. </param>
        /// <param name="parameters"> The AzureResourceFlattenModel4 to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AzureResourceFlattenModel4> PutAzureResourceFlattenModel4(string name, AzureResourceFlattenModel4 parameters, CancellationToken cancellationToken = default)
        {
            using var scope = AzureResourceFlattenModel4sClientDiagnostics.CreateScope("ResourceGroupExtensionClient.PutAzureResourceFlattenModel4");
            scope.Start();
            try
            {
                var response = AzureResourceFlattenModel4sRestClient.Put(Id.SubscriptionId, Id.ResourceGroupName, name, parameters, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get an AzureResourceFlattenModel4.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/azureResourceFlattenModel4s/{name}
        /// Operation Id: AzureResourceFlattenModel4s_Get
        /// </summary>
        /// <param name="name"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AzureResourceFlattenModel4>> GetAzureResourceFlattenModel4Async(string name, CancellationToken cancellationToken = default)
        {
            using var scope = AzureResourceFlattenModel4sClientDiagnostics.CreateScope("ResourceGroupExtensionClient.GetAzureResourceFlattenModel4");
            scope.Start();
            try
            {
                var response = await AzureResourceFlattenModel4sRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get an AzureResourceFlattenModel4.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/azureResourceFlattenModel4s/{name}
        /// Operation Id: AzureResourceFlattenModel4s_Get
        /// </summary>
        /// <param name="name"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AzureResourceFlattenModel4> GetAzureResourceFlattenModel4(string name, CancellationToken cancellationToken = default)
        {
            using var scope = AzureResourceFlattenModel4sClientDiagnostics.CreateScope("ResourceGroupExtensionClient.GetAzureResourceFlattenModel4");
            scope.Start();
            try
            {
                var response = AzureResourceFlattenModel4sRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get an AzureResourceFlattenModel5.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/azureResourceFlattenModel5s
        /// Operation Id: AzureResourceFlattenModel5s_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AzureResourceFlattenModel5" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AzureResourceFlattenModel5> GetAzureResourceFlattenModel5sAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<AzureResourceFlattenModel5>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = AzureResourceFlattenModel5sClientDiagnostics.CreateScope("ResourceGroupExtensionClient.GetAzureResourceFlattenModel5s");
                scope.Start();
                try
                {
                    var response = await AzureResourceFlattenModel5sRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Get an AzureResourceFlattenModel5.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/azureResourceFlattenModel5s
        /// Operation Id: AzureResourceFlattenModel5s_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AzureResourceFlattenModel5" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AzureResourceFlattenModel5> GetAzureResourceFlattenModel5s(CancellationToken cancellationToken = default)
        {
            Page<AzureResourceFlattenModel5> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = AzureResourceFlattenModel5sClientDiagnostics.CreateScope("ResourceGroupExtensionClient.GetAzureResourceFlattenModel5s");
                scope.Start();
                try
                {
                    var response = AzureResourceFlattenModel5sRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
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
        /// Create or update an AzureResourceFlattenModel5.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/azureResourceFlattenModel5s/{name}
        /// Operation Id: AzureResourceFlattenModel5s_Put
        /// </summary>
        /// <param name="name"> The String to use. </param>
        /// <param name="foo"> New property. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AzureResourceFlattenModel5>> PutAzureResourceFlattenModel5Async(string name, int? foo = null, CancellationToken cancellationToken = default)
        {
            using var scope = AzureResourceFlattenModel5sClientDiagnostics.CreateScope("ResourceGroupExtensionClient.PutAzureResourceFlattenModel5");
            scope.Start();
            try
            {
                var response = await AzureResourceFlattenModel5sRestClient.PutAsync(Id.SubscriptionId, Id.ResourceGroupName, name, foo, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create or update an AzureResourceFlattenModel5.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/azureResourceFlattenModel5s/{name}
        /// Operation Id: AzureResourceFlattenModel5s_Put
        /// </summary>
        /// <param name="name"> The String to use. </param>
        /// <param name="foo"> New property. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AzureResourceFlattenModel5> PutAzureResourceFlattenModel5(string name, int? foo = null, CancellationToken cancellationToken = default)
        {
            using var scope = AzureResourceFlattenModel5sClientDiagnostics.CreateScope("ResourceGroupExtensionClient.PutAzureResourceFlattenModel5");
            scope.Start();
            try
            {
                var response = AzureResourceFlattenModel5sRestClient.Put(Id.SubscriptionId, Id.ResourceGroupName, name, foo, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get an AzureResourceFlattenModel5.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/azureResourceFlattenModel5s/{name}
        /// Operation Id: AzureResourceFlattenModel5s_Get
        /// </summary>
        /// <param name="name"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<AzureResourceFlattenModel5>> GetAzureResourceFlattenModel5Async(string name, CancellationToken cancellationToken = default)
        {
            using var scope = AzureResourceFlattenModel5sClientDiagnostics.CreateScope("ResourceGroupExtensionClient.GetAzureResourceFlattenModel5");
            scope.Start();
            try
            {
                var response = await AzureResourceFlattenModel5sRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get an AzureResourceFlattenModel5.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/azureResourceFlattenModel5s/{name}
        /// Operation Id: AzureResourceFlattenModel5s_Get
        /// </summary>
        /// <param name="name"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<AzureResourceFlattenModel5> GetAzureResourceFlattenModel5(string name, CancellationToken cancellationToken = default)
        {
            using var scope = AzureResourceFlattenModel5sClientDiagnostics.CreateScope("ResourceGroupExtensionClient.GetAzureResourceFlattenModel5");
            scope.Start();
            try
            {
                var response = AzureResourceFlattenModel5sRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
