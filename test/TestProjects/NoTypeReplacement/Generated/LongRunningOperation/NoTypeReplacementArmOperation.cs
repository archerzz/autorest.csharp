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

namespace NoTypeReplacement
{
#pragma warning disable SA1649 // File name should match first type name
    internal class NoTypeReplacementArmOperation : ArmOperation
#pragma warning restore SA1649 // File name should match first type name
    {
        private readonly OperationOrResponseInternals _operation;

        /// <summary> Initializes a new instance of NoTypeReplacementArmOperation for mocking. </summary>
        protected NoTypeReplacementArmOperation()
        {
        }

        internal NoTypeReplacementArmOperation(Response response)
        {
            _operation = new OperationOrResponseInternals(response);
            _operation.PollingStrategy = new ExponentialPollingStrategy();
        }

        internal NoTypeReplacementArmOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response, OperationFinalStateVia finalStateVia)
        {
            _operation = new OperationOrResponseInternals(clientDiagnostics, pipeline, request, response, finalStateVia, "NoTypeReplacementArmOperation");
            _operation.PollingStrategy = new ExponentialPollingStrategy();
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> WaitForCompletionResponseAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionResponseAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> WaitForCompletionResponseAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionResponseAsync(pollingInterval, cancellationToken);
    }
}
