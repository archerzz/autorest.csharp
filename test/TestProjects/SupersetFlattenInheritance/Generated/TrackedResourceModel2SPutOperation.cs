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

namespace SupersetFlattenInheritance
{
    public partial class TrackedResourceModel2SPutOperation : Operation<TrackedResourceModel2>
    {
        private readonly OperationOrResponseInternals<TrackedResourceModel2> _operation;

        /// <summary> Initializes a new instance of TrackedResourceModel2SPutOperation for mocking. </summary>
        protected TrackedResourceModel2SPutOperation()
        {
        }

        internal TrackedResourceModel2SPutOperation(ResourceOperationsBase operationsBase, Response<TrackedResourceModel2Data> response)
        {
            _operation = new OperationOrResponseInternals<TrackedResourceModel2>(Response.FromValue(new TrackedResourceModel2(operationsBase, response.Value), response.GetRawResponse()));
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override TrackedResourceModel2 Value => _operation.Value;

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
        public override ValueTask<Response<TrackedResourceModel2>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<TrackedResourceModel2>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);
    }
}
