// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;
using _Type.Property.AdditionalProperties;
using _Type.Property.AdditionalProperties.Models;

namespace _Type.Property.AdditionalProperties.Samples
{
    public partial class Samples_ExtendsUnknownDiscriminated
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_ExtendsUnknownDiscriminated_GetExtendsUnknownDiscriminated_ShortVersion()
        {
            ExtendsUnknownDiscriminated client = new AdditionalPropertiesClient().GetExtendsUnknownDiscriminatedClient();

            Response response = client.GetExtendsUnknownDiscriminated(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("kind").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_ExtendsUnknownDiscriminated_GetExtendsUnknownDiscriminated_ShortVersion_Async()
        {
            ExtendsUnknownDiscriminated client = new AdditionalPropertiesClient().GetExtendsUnknownDiscriminatedClient();

            Response response = await client.GetExtendsUnknownDiscriminatedAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("kind").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_ExtendsUnknownDiscriminated_GetExtendsUnknownDiscriminated_ShortVersion_Convenience()
        {
            ExtendsUnknownDiscriminated client = new AdditionalPropertiesClient().GetExtendsUnknownDiscriminatedClient();

            Response<ExtendsUnknownAdditionalPropertiesDiscriminated> response = client.GetExtendsUnknownDiscriminated();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_ExtendsUnknownDiscriminated_GetExtendsUnknownDiscriminated_ShortVersion_Convenience_Async()
        {
            ExtendsUnknownDiscriminated client = new AdditionalPropertiesClient().GetExtendsUnknownDiscriminatedClient();

            Response<ExtendsUnknownAdditionalPropertiesDiscriminated> response = await client.GetExtendsUnknownDiscriminatedAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_ExtendsUnknownDiscriminated_GetExtendsUnknownDiscriminated_AllParameters()
        {
            ExtendsUnknownDiscriminated client = new AdditionalPropertiesClient().GetExtendsUnknownDiscriminatedClient();

            Response response = client.GetExtendsUnknownDiscriminated(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("kind").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_ExtendsUnknownDiscriminated_GetExtendsUnknownDiscriminated_AllParameters_Async()
        {
            ExtendsUnknownDiscriminated client = new AdditionalPropertiesClient().GetExtendsUnknownDiscriminatedClient();

            Response response = await client.GetExtendsUnknownDiscriminatedAsync(null);

            JsonElement result = JsonDocument.Parse(response.ContentStream).RootElement;
            Console.WriteLine(result.GetProperty("kind").ToString());
            Console.WriteLine(result.GetProperty("name").ToString());
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_ExtendsUnknownDiscriminated_GetExtendsUnknownDiscriminated_AllParameters_Convenience()
        {
            ExtendsUnknownDiscriminated client = new AdditionalPropertiesClient().GetExtendsUnknownDiscriminatedClient();

            Response<ExtendsUnknownAdditionalPropertiesDiscriminated> response = client.GetExtendsUnknownDiscriminated();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_ExtendsUnknownDiscriminated_GetExtendsUnknownDiscriminated_AllParameters_Convenience_Async()
        {
            ExtendsUnknownDiscriminated client = new AdditionalPropertiesClient().GetExtendsUnknownDiscriminatedClient();

            Response<ExtendsUnknownAdditionalPropertiesDiscriminated> response = await client.GetExtendsUnknownDiscriminatedAsync();
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_ExtendsUnknownDiscriminated_Put_ShortVersion()
        {
            ExtendsUnknownDiscriminated client = new AdditionalPropertiesClient().GetExtendsUnknownDiscriminatedClient();

            using RequestContent content = RequestContent.Create(new
            {
                index = 1234,
                kind = "derived",
                name = "<name>",
            });
            Response response = client.Put(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_ExtendsUnknownDiscriminated_Put_ShortVersion_Async()
        {
            ExtendsUnknownDiscriminated client = new AdditionalPropertiesClient().GetExtendsUnknownDiscriminatedClient();

            using RequestContent content = RequestContent.Create(new
            {
                index = 1234,
                kind = "derived",
                name = "<name>",
            });
            Response response = await client.PutAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_ExtendsUnknownDiscriminated_Put_ShortVersion_Convenience()
        {
            ExtendsUnknownDiscriminated client = new AdditionalPropertiesClient().GetExtendsUnknownDiscriminatedClient();

            ExtendsUnknownAdditionalPropertiesDiscriminated body = new ExtendsUnknownAdditionalPropertiesDiscriminatedDerived("<name>", 1234);
            Response response = client.Put(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_ExtendsUnknownDiscriminated_Put_ShortVersion_Convenience_Async()
        {
            ExtendsUnknownDiscriminated client = new AdditionalPropertiesClient().GetExtendsUnknownDiscriminatedClient();

            ExtendsUnknownAdditionalPropertiesDiscriminated body = new ExtendsUnknownAdditionalPropertiesDiscriminatedDerived("<name>", 1234);
            Response response = await client.PutAsync(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_ExtendsUnknownDiscriminated_Put_AllParameters()
        {
            ExtendsUnknownDiscriminated client = new AdditionalPropertiesClient().GetExtendsUnknownDiscriminatedClient();

            using RequestContent content = RequestContent.Create(new
            {
                index = 1234,
                age = 123.45F,
                kind = "derived",
                name = "<name>",
            });
            Response response = client.Put(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_ExtendsUnknownDiscriminated_Put_AllParameters_Async()
        {
            ExtendsUnknownDiscriminated client = new AdditionalPropertiesClient().GetExtendsUnknownDiscriminatedClient();

            using RequestContent content = RequestContent.Create(new
            {
                index = 1234,
                age = 123.45F,
                kind = "derived",
                name = "<name>",
            });
            Response response = await client.PutAsync(content);

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_ExtendsUnknownDiscriminated_Put_AllParameters_Convenience()
        {
            ExtendsUnknownDiscriminated client = new AdditionalPropertiesClient().GetExtendsUnknownDiscriminatedClient();

            ExtendsUnknownAdditionalPropertiesDiscriminated body = new ExtendsUnknownAdditionalPropertiesDiscriminatedDerived("<name>", 1234)
            {
                Age = 123.45F,
            };
            Response response = client.Put(body);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_ExtendsUnknownDiscriminated_Put_AllParameters_Convenience_Async()
        {
            ExtendsUnknownDiscriminated client = new AdditionalPropertiesClient().GetExtendsUnknownDiscriminatedClient();

            ExtendsUnknownAdditionalPropertiesDiscriminated body = new ExtendsUnknownAdditionalPropertiesDiscriminatedDerived("<name>", 1234)
            {
                Age = 123.45F,
            };
            Response response = await client.PutAsync(body);
        }
    }
}
