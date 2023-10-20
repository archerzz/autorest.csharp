// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Encode.Bytes;
using NUnit.Framework;

namespace Encode.Bytes.Samples
{
    public partial class Samples_RequestBody
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Default_ShortVersion()
        {
            RequestBody client = new BytesClient().GetRequestBodyClient(apiVersion: "1.0.0");

            using RequestContent content = RequestContent.Create(new object());
            Response response = client.Default(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Default_ShortVersion_Async()
        {
            RequestBody client = new BytesClient().GetRequestBodyClient(apiVersion: "1.0.0");

            using RequestContent content = RequestContent.Create(new object());
            Response response = await client.DefaultAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Default_ShortVersion_Convenience()
        {
            RequestBody client = new BytesClient().GetRequestBodyClient(apiVersion: "1.0.0");

            Response response = client.Default(BinaryData.FromObjectAsJson(new object()));
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Default_ShortVersion_Convenience_Async()
        {
            RequestBody client = new BytesClient().GetRequestBodyClient(apiVersion: "1.0.0");

            Response response = await client.DefaultAsync(BinaryData.FromObjectAsJson(new object()));
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Default_AllParameters()
        {
            RequestBody client = new BytesClient().GetRequestBodyClient(apiVersion: "1.0.0");

            using RequestContent content = RequestContent.Create(new object());
            Response response = client.Default(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Default_AllParameters_Async()
        {
            RequestBody client = new BytesClient().GetRequestBodyClient(apiVersion: "1.0.0");

            using RequestContent content = RequestContent.Create(new object());
            Response response = await client.DefaultAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Default_AllParameters_Convenience()
        {
            RequestBody client = new BytesClient().GetRequestBodyClient(apiVersion: "1.0.0");

            Response response = client.Default(BinaryData.FromObjectAsJson(new object()));
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Default_AllParameters_Convenience_Async()
        {
            RequestBody client = new BytesClient().GetRequestBodyClient(apiVersion: "1.0.0");

            Response response = await client.DefaultAsync(BinaryData.FromObjectAsJson(new object()));
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_OctetStream_ShortVersion()
        {
            RequestBody client = new BytesClient().GetRequestBodyClient(apiVersion: "1.0.0");

            using RequestContent content = RequestContent.Create(new object());
            Response response = client.OctetStream(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_OctetStream_ShortVersion_Async()
        {
            RequestBody client = new BytesClient().GetRequestBodyClient(apiVersion: "1.0.0");

            using RequestContent content = RequestContent.Create(new object());
            Response response = await client.OctetStreamAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_OctetStream_ShortVersion_Convenience()
        {
            RequestBody client = new BytesClient().GetRequestBodyClient(apiVersion: "1.0.0");

            Response response = client.OctetStream(BinaryData.FromObjectAsJson(new object()));
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_OctetStream_ShortVersion_Convenience_Async()
        {
            RequestBody client = new BytesClient().GetRequestBodyClient(apiVersion: "1.0.0");

            Response response = await client.OctetStreamAsync(BinaryData.FromObjectAsJson(new object()));
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_OctetStream_AllParameters()
        {
            RequestBody client = new BytesClient().GetRequestBodyClient(apiVersion: "1.0.0");

            using RequestContent content = RequestContent.Create(new object());
            Response response = client.OctetStream(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_OctetStream_AllParameters_Async()
        {
            RequestBody client = new BytesClient().GetRequestBodyClient(apiVersion: "1.0.0");

            using RequestContent content = RequestContent.Create(new object());
            Response response = await client.OctetStreamAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_OctetStream_AllParameters_Convenience()
        {
            RequestBody client = new BytesClient().GetRequestBodyClient(apiVersion: "1.0.0");

            Response response = client.OctetStream(BinaryData.FromObjectAsJson(new object()));
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_OctetStream_AllParameters_Convenience_Async()
        {
            RequestBody client = new BytesClient().GetRequestBodyClient(apiVersion: "1.0.0");

            Response response = await client.OctetStreamAsync(BinaryData.FromObjectAsJson(new object()));
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CustomContentType_ShortVersion()
        {
            RequestBody client = new BytesClient().GetRequestBodyClient(apiVersion: "1.0.0");

            using RequestContent content = RequestContent.Create(new object());
            Response response = client.CustomContentType(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CustomContentType_ShortVersion_Async()
        {
            RequestBody client = new BytesClient().GetRequestBodyClient(apiVersion: "1.0.0");

            using RequestContent content = RequestContent.Create(new object());
            Response response = await client.CustomContentTypeAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CustomContentType_ShortVersion_Convenience()
        {
            RequestBody client = new BytesClient().GetRequestBodyClient(apiVersion: "1.0.0");

            Response response = client.CustomContentType(BinaryData.FromObjectAsJson(new object()));
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CustomContentType_ShortVersion_Convenience_Async()
        {
            RequestBody client = new BytesClient().GetRequestBodyClient(apiVersion: "1.0.0");

            Response response = await client.CustomContentTypeAsync(BinaryData.FromObjectAsJson(new object()));
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CustomContentType_AllParameters()
        {
            RequestBody client = new BytesClient().GetRequestBodyClient(apiVersion: "1.0.0");

            using RequestContent content = RequestContent.Create(new object());
            Response response = client.CustomContentType(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CustomContentType_AllParameters_Async()
        {
            RequestBody client = new BytesClient().GetRequestBodyClient(apiVersion: "1.0.0");

            using RequestContent content = RequestContent.Create(new object());
            Response response = await client.CustomContentTypeAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_CustomContentType_AllParameters_Convenience()
        {
            RequestBody client = new BytesClient().GetRequestBodyClient(apiVersion: "1.0.0");

            Response response = client.CustomContentType(BinaryData.FromObjectAsJson(new object()));
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_CustomContentType_AllParameters_Convenience_Async()
        {
            RequestBody client = new BytesClient().GetRequestBodyClient(apiVersion: "1.0.0");

            Response response = await client.CustomContentTypeAsync(BinaryData.FromObjectAsJson(new object()));
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Base64_ShortVersion()
        {
            RequestBody client = new BytesClient().GetRequestBodyClient(apiVersion: "1.0.0");

            using RequestContent content = RequestContent.Create(new object());
            Response response = client.Base64(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Base64_ShortVersion_Async()
        {
            RequestBody client = new BytesClient().GetRequestBodyClient(apiVersion: "1.0.0");

            using RequestContent content = RequestContent.Create(new object());
            Response response = await client.Base64Async(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Base64_ShortVersion_Convenience()
        {
            RequestBody client = new BytesClient().GetRequestBodyClient(apiVersion: "1.0.0");

            Response response = client.Base64(BinaryData.FromObjectAsJson(new object()));
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Base64_ShortVersion_Convenience_Async()
        {
            RequestBody client = new BytesClient().GetRequestBodyClient(apiVersion: "1.0.0");

            Response response = await client.Base64Async(BinaryData.FromObjectAsJson(new object()));
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Base64_AllParameters()
        {
            RequestBody client = new BytesClient().GetRequestBodyClient(apiVersion: "1.0.0");

            using RequestContent content = RequestContent.Create(new object());
            Response response = client.Base64(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Base64_AllParameters_Async()
        {
            RequestBody client = new BytesClient().GetRequestBodyClient(apiVersion: "1.0.0");

            using RequestContent content = RequestContent.Create(new object());
            Response response = await client.Base64Async(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Base64_AllParameters_Convenience()
        {
            RequestBody client = new BytesClient().GetRequestBodyClient(apiVersion: "1.0.0");

            Response response = client.Base64(BinaryData.FromObjectAsJson(new object()));
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Base64_AllParameters_Convenience_Async()
        {
            RequestBody client = new BytesClient().GetRequestBodyClient(apiVersion: "1.0.0");

            Response response = await client.Base64Async(BinaryData.FromObjectAsJson(new object()));
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Base64url_ShortVersion()
        {
            RequestBody client = new BytesClient().GetRequestBodyClient(apiVersion: "1.0.0");

            using RequestContent content = RequestContent.Create(new object());
            Response response = client.Base64url(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Base64url_ShortVersion_Async()
        {
            RequestBody client = new BytesClient().GetRequestBodyClient(apiVersion: "1.0.0");

            using RequestContent content = RequestContent.Create(new object());
            Response response = await client.Base64urlAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Base64url_ShortVersion_Convenience()
        {
            RequestBody client = new BytesClient().GetRequestBodyClient(apiVersion: "1.0.0");

            Response response = client.Base64url(BinaryData.FromObjectAsJson(new object()));
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Base64url_ShortVersion_Convenience_Async()
        {
            RequestBody client = new BytesClient().GetRequestBodyClient(apiVersion: "1.0.0");

            Response response = await client.Base64urlAsync(BinaryData.FromObjectAsJson(new object()));
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Base64url_AllParameters()
        {
            RequestBody client = new BytesClient().GetRequestBodyClient(apiVersion: "1.0.0");

            using RequestContent content = RequestContent.Create(new object());
            Response response = client.Base64url(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Base64url_AllParameters_Async()
        {
            RequestBody client = new BytesClient().GetRequestBodyClient(apiVersion: "1.0.0");

            using RequestContent content = RequestContent.Create(new object());
            Response response = await client.Base64urlAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Base64url_AllParameters_Convenience()
        {
            RequestBody client = new BytesClient().GetRequestBodyClient(apiVersion: "1.0.0");

            Response response = client.Base64url(BinaryData.FromObjectAsJson(new object()));
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Base64url_AllParameters_Convenience_Async()
        {
            RequestBody client = new BytesClient().GetRequestBodyClient(apiVersion: "1.0.0");

            Response response = await client.Base64urlAsync(BinaryData.FromObjectAsJson(new object()));
        }
    }
}