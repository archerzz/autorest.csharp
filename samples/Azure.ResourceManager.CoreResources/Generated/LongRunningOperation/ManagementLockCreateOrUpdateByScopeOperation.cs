// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Create or update a management lock by scope. </summary>
    public partial class ManagementLockCreateOrUpdateByScopeOperation : Operation<ManagementLockObject>
    {
        private readonly OperationOrResponseInternals<ManagementLockObject> _operation;

        /// <summary> Initializes a new instance of ManagementLockCreateOrUpdateByScopeOperation for mocking. </summary>
        protected ManagementLockCreateOrUpdateByScopeOperation()
        {
        }

        internal ManagementLockCreateOrUpdateByScopeOperation(ArmResource operationsBase, Response<ManagementLockObjectData> response)
        {
            _operation = new OperationOrResponseInternals<ManagementLockObject>(Response.FromValue(new ManagementLockObject(operationsBase, response.Value), response.GetRawResponse()));
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override ManagementLockObject Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<ManagementLockObject>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<ManagementLockObject>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);
    }
}