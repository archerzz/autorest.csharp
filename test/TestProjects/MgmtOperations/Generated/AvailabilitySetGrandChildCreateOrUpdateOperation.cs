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
using MgmtOperations.Models;

namespace MgmtOperations
{
    /// <summary> Create or update an availability set. </summary>
    public partial class AvailabilitySetGrandChildCreateOrUpdateOperation : Operation<AvailabilitySetGrandChild>
    {
        private readonly OperationOrResponseInternals<AvailabilitySetGrandChild> _operation;

        /// <summary> Initializes a new instance of AvailabilitySetGrandChildCreateOrUpdateOperation for mocking. </summary>
        protected AvailabilitySetGrandChildCreateOrUpdateOperation()
        {
        }

        internal AvailabilitySetGrandChildCreateOrUpdateOperation(OperationsBase operationsBase, Response<AvailabilitySetGrandChildData> response)
        {
            _operation = new OperationOrResponseInternals<AvailabilitySetGrandChild>(Response.FromValue(new AvailabilitySetGrandChild(operationsBase, response.Value), response.GetRawResponse()));
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override AvailabilitySetGrandChild Value => _operation.Value;

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
        public override ValueTask<Response<AvailabilitySetGrandChild>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<AvailabilitySetGrandChild>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);
    }
}
