// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace ADP.DataManagement.Ingestion.Uploads
{
    /// <summary> A measurement resource created as result of the upload. </summary>
    public partial class UploadResultMeasurement
    {
        /// <summary> Initializes a new instance of UploadResultMeasurement. </summary>
        /// <param name="measurementId"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="measurementId"/> is null. </exception>
        internal UploadResultMeasurement(string measurementId)
        {
            Argument.AssertNotNull(measurementId, nameof(measurementId));

            MeasurementId = measurementId;
        }

        /// <summary> Gets the measurement id. </summary>
        public string MeasurementId { get; }
    }
}
