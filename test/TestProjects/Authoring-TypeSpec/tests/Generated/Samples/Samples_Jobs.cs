// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading.Tasks;
using AuthoringTypeSpec.Models;
using Azure;
using Azure.Identity;
using NUnit.Framework;

namespace AuthoringTypeSpec.Samples
{
    public partial class Samples_Jobs
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_DeploymentJob_GetDeploymentStatus_ShortVersion()
        {
            Uri endpoint = new Uri("<endpoint>");
            Jobs client = new AuthoringTypeSpecClient(endpoint).GetJobsClient(apiVersion: "2022-05-15-preview");

            Response response = client.GetDeploymentStatus("<projectName>", "<deploymentName>", "<jobId>");

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("jobId").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("lastUpdatedDateTime").ToString());
            Console.WriteLine(result.GetProperty("expirationDateTime").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("warnings")[0].GetProperty("code").ToString());
            Console.WriteLine(result.GetProperty("warnings")[0].GetProperty("message").ToString());
            Console.WriteLine(result.GetProperty("errors").GetProperty("code").ToString());
            Console.WriteLine(result.GetProperty("errors").GetProperty("message").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_DeploymentJob_GetDeploymentStatus_ShortVersion_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            Jobs client = new AuthoringTypeSpecClient(endpoint).GetJobsClient(apiVersion: "2022-05-15-preview");

            Response response = await client.GetDeploymentStatusAsync("<projectName>", "<deploymentName>", "<jobId>");

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("jobId").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("lastUpdatedDateTime").ToString());
            Console.WriteLine(result.GetProperty("expirationDateTime").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("warnings")[0].GetProperty("code").ToString());
            Console.WriteLine(result.GetProperty("warnings")[0].GetProperty("message").ToString());
            Console.WriteLine(result.GetProperty("errors").GetProperty("code").ToString());
            Console.WriteLine(result.GetProperty("errors").GetProperty("message").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_DeploymentJob_GetDeploymentStatus_ShortVersion_Convenience()
        {
            Uri endpoint = new Uri("<endpoint>");
            Jobs client = new AuthoringTypeSpecClient(endpoint).GetJobsClient(apiVersion: "2022-05-15-preview");

            Response<DeploymentJob> response = client.GetDeploymentStatusValue("<projectName>", "<deploymentName>", "<jobId>");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_DeploymentJob_GetDeploymentStatus_ShortVersion_Convenience_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            Jobs client = new AuthoringTypeSpecClient(endpoint).GetJobsClient(apiVersion: "2022-05-15-preview");

            Response<DeploymentJob> response = await client.GetDeploymentStatusValueAsync("<projectName>", "<deploymentName>", "<jobId>");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_DeploymentJob_GetDeploymentStatus_AllParameters()
        {
            Uri endpoint = new Uri("<endpoint>");
            Jobs client = new AuthoringTypeSpecClient(endpoint).GetJobsClient(apiVersion: "2022-05-15-preview");

            Response response = client.GetDeploymentStatus("<projectName>", "<deploymentName>", "<jobId>");

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("jobId").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("lastUpdatedDateTime").ToString());
            Console.WriteLine(result.GetProperty("expirationDateTime").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("warnings")[0].GetProperty("code").ToString());
            Console.WriteLine(result.GetProperty("warnings")[0].GetProperty("message").ToString());
            Console.WriteLine(result.GetProperty("errors").GetProperty("code").ToString());
            Console.WriteLine(result.GetProperty("errors").GetProperty("message").ToString());
            Console.WriteLine(result.GetProperty("errors").GetProperty("target").ToString());
            Console.WriteLine(result.GetProperty("errors").GetProperty("innererror").GetProperty("code").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_DeploymentJob_GetDeploymentStatus_AllParameters_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            Jobs client = new AuthoringTypeSpecClient(endpoint).GetJobsClient(apiVersion: "2022-05-15-preview");

            Response response = await client.GetDeploymentStatusAsync("<projectName>", "<deploymentName>", "<jobId>");

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("jobId").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("lastUpdatedDateTime").ToString());
            Console.WriteLine(result.GetProperty("expirationDateTime").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("warnings")[0].GetProperty("code").ToString());
            Console.WriteLine(result.GetProperty("warnings")[0].GetProperty("message").ToString());
            Console.WriteLine(result.GetProperty("errors").GetProperty("code").ToString());
            Console.WriteLine(result.GetProperty("errors").GetProperty("message").ToString());
            Console.WriteLine(result.GetProperty("errors").GetProperty("target").ToString());
            Console.WriteLine(result.GetProperty("errors").GetProperty("innererror").GetProperty("code").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_DeploymentJob_GetDeploymentStatus_AllParameters_Convenience()
        {
            Uri endpoint = new Uri("<endpoint>");
            Jobs client = new AuthoringTypeSpecClient(endpoint).GetJobsClient(apiVersion: "2022-05-15-preview");

            Response<DeploymentJob> response = client.GetDeploymentStatusValue("<projectName>", "<deploymentName>", "<jobId>");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_DeploymentJob_GetDeploymentStatus_AllParameters_Convenience_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            Jobs client = new AuthoringTypeSpecClient(endpoint).GetJobsClient(apiVersion: "2022-05-15-preview");

            Response<DeploymentJob> response = await client.GetDeploymentStatusValueAsync("<projectName>", "<deploymentName>", "<jobId>");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_SwapDeploymentsJob_GetSwapDeploymentsStatus_ShortVersion()
        {
            Uri endpoint = new Uri("<endpoint>");
            Jobs client = new AuthoringTypeSpecClient(endpoint).GetJobsClient(apiVersion: "2022-05-15-preview");

            Response response = client.GetSwapDeploymentsStatus("<projectName>", "<deploymentName>", "<jobId>");

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("jobId").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("lastUpdatedDateTime").ToString());
            Console.WriteLine(result.GetProperty("expirationDateTime").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("warnings")[0].GetProperty("code").ToString());
            Console.WriteLine(result.GetProperty("warnings")[0].GetProperty("message").ToString());
            Console.WriteLine(result.GetProperty("errors").GetProperty("code").ToString());
            Console.WriteLine(result.GetProperty("errors").GetProperty("message").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_SwapDeploymentsJob_GetSwapDeploymentsStatus_ShortVersion_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            Jobs client = new AuthoringTypeSpecClient(endpoint).GetJobsClient(apiVersion: "2022-05-15-preview");

            Response response = await client.GetSwapDeploymentsStatusAsync("<projectName>", "<deploymentName>", "<jobId>");

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("jobId").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("lastUpdatedDateTime").ToString());
            Console.WriteLine(result.GetProperty("expirationDateTime").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("warnings")[0].GetProperty("code").ToString());
            Console.WriteLine(result.GetProperty("warnings")[0].GetProperty("message").ToString());
            Console.WriteLine(result.GetProperty("errors").GetProperty("code").ToString());
            Console.WriteLine(result.GetProperty("errors").GetProperty("message").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_SwapDeploymentsJob_GetSwapDeploymentsStatus_ShortVersion_Convenience()
        {
            Uri endpoint = new Uri("<endpoint>");
            Jobs client = new AuthoringTypeSpecClient(endpoint).GetJobsClient(apiVersion: "2022-05-15-preview");

            Response<SwapDeploymentsJob> response = client.GetSwapDeploymentsStatusValue("<projectName>", "<deploymentName>", "<jobId>");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_SwapDeploymentsJob_GetSwapDeploymentsStatus_ShortVersion_Convenience_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            Jobs client = new AuthoringTypeSpecClient(endpoint).GetJobsClient(apiVersion: "2022-05-15-preview");

            Response<SwapDeploymentsJob> response = await client.GetSwapDeploymentsStatusValueAsync("<projectName>", "<deploymentName>", "<jobId>");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_SwapDeploymentsJob_GetSwapDeploymentsStatus_AllParameters()
        {
            Uri endpoint = new Uri("<endpoint>");
            Jobs client = new AuthoringTypeSpecClient(endpoint).GetJobsClient(apiVersion: "2022-05-15-preview");

            Response response = client.GetSwapDeploymentsStatus("<projectName>", "<deploymentName>", "<jobId>");

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("jobId").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("lastUpdatedDateTime").ToString());
            Console.WriteLine(result.GetProperty("expirationDateTime").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("warnings")[0].GetProperty("code").ToString());
            Console.WriteLine(result.GetProperty("warnings")[0].GetProperty("message").ToString());
            Console.WriteLine(result.GetProperty("errors").GetProperty("code").ToString());
            Console.WriteLine(result.GetProperty("errors").GetProperty("message").ToString());
            Console.WriteLine(result.GetProperty("errors").GetProperty("target").ToString());
            Console.WriteLine(result.GetProperty("errors").GetProperty("innererror").GetProperty("code").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_SwapDeploymentsJob_GetSwapDeploymentsStatus_AllParameters_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            Jobs client = new AuthoringTypeSpecClient(endpoint).GetJobsClient(apiVersion: "2022-05-15-preview");

            Response response = await client.GetSwapDeploymentsStatusAsync("<projectName>", "<deploymentName>", "<jobId>");

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("jobId").ToString());
            Console.WriteLine(result.GetProperty("createdDateTime").ToString());
            Console.WriteLine(result.GetProperty("lastUpdatedDateTime").ToString());
            Console.WriteLine(result.GetProperty("expirationDateTime").ToString());
            Console.WriteLine(result.GetProperty("status").ToString());
            Console.WriteLine(result.GetProperty("warnings")[0].GetProperty("code").ToString());
            Console.WriteLine(result.GetProperty("warnings")[0].GetProperty("message").ToString());
            Console.WriteLine(result.GetProperty("errors").GetProperty("code").ToString());
            Console.WriteLine(result.GetProperty("errors").GetProperty("message").ToString());
            Console.WriteLine(result.GetProperty("errors").GetProperty("target").ToString());
            Console.WriteLine(result.GetProperty("errors").GetProperty("innererror").GetProperty("code").ToString());
            Console.WriteLine(result.GetProperty("id").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_SwapDeploymentsJob_GetSwapDeploymentsStatus_AllParameters_Convenience()
        {
            Uri endpoint = new Uri("<endpoint>");
            Jobs client = new AuthoringTypeSpecClient(endpoint).GetJobsClient(apiVersion: "2022-05-15-preview");

            Response<SwapDeploymentsJob> response = client.GetSwapDeploymentsStatusValue("<projectName>", "<deploymentName>", "<jobId>");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_SwapDeploymentsJob_GetSwapDeploymentsStatus_AllParameters_Convenience_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            Jobs client = new AuthoringTypeSpecClient(endpoint).GetJobsClient(apiVersion: "2022-05-15-preview");

            Response<SwapDeploymentsJob> response = await client.GetSwapDeploymentsStatusValueAsync("<projectName>", "<deploymentName>", "<jobId>");
        }
    }
}
