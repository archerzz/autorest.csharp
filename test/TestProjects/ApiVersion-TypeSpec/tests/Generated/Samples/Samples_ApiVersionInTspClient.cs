// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading.Tasks;
using ApiVersionInTsp.Models;
using Azure;
using Azure.Identity;
using NUnit.Framework;

namespace ApiVersionInTsp.Samples
{
    public partial class Samples_ApiVersionInTspClient
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_ApiVersionInTsp_GetBatchDetectionResult_ShortVersion()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ApiVersionInTspClient client = new ApiVersionInTspClient(endpoint, credential);

            Response response = client.GetBatchDetectionResult(Guid.Parse("73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a"), null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("resultId").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_ApiVersionInTsp_GetBatchDetectionResult_ShortVersion_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ApiVersionInTspClient client = new ApiVersionInTspClient(endpoint, credential);

            Response response = await client.GetBatchDetectionResultAsync(Guid.Parse("73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a"), null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("resultId").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_ApiVersionInTsp_GetBatchDetectionResult_ShortVersion_Convenience()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ApiVersionInTspClient client = new ApiVersionInTspClient(endpoint, credential);

            Response<DetectionResult> response = client.GetBatchDetectionResult(Guid.Parse("73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a"));
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_ApiVersionInTsp_GetBatchDetectionResult_ShortVersion_Convenience_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ApiVersionInTspClient client = new ApiVersionInTspClient(endpoint, credential);

            Response<DetectionResult> response = await client.GetBatchDetectionResultAsync(Guid.Parse("73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a"));
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_ApiVersionInTsp_GetBatchDetectionResult_AllParameters()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ApiVersionInTspClient client = new ApiVersionInTspClient(endpoint, credential);

            Response response = client.GetBatchDetectionResult(Guid.Parse("73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a"), null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("resultId").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_ApiVersionInTsp_GetBatchDetectionResult_AllParameters_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ApiVersionInTspClient client = new ApiVersionInTspClient(endpoint, credential);

            Response response = await client.GetBatchDetectionResultAsync(Guid.Parse("73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a"), null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("resultId").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_ApiVersionInTsp_GetBatchDetectionResult_AllParameters_Convenience()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ApiVersionInTspClient client = new ApiVersionInTspClient(endpoint, credential);

            Response<DetectionResult> response = client.GetBatchDetectionResult(Guid.Parse("73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a"));
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_ApiVersionInTsp_GetBatchDetectionResult_AllParameters_Convenience_Async()
        {
            Uri endpoint = new Uri("<https://my-service.azure.com>");
            AzureKeyCredential credential = new AzureKeyCredential("<key>");
            ApiVersionInTspClient client = new ApiVersionInTspClient(endpoint, credential);

            Response<DetectionResult> response = await client.GetBatchDetectionResultAsync(Guid.Parse("73f411fe-4f43-4b4b-9cbd-6828d8f4cf9a"));
        }
    }
}
