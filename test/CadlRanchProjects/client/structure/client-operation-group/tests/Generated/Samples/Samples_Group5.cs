// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Identity;
using Client.Structure.Service.ClientOperationGroup.Models;
using NUnit.Framework;

namespace Client.Structure.Service.ClientOperationGroup.Samples
{
    public partial class Samples_Group5
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Group5_Six_ShortVersion()
        {
            Uri endpoint = new Uri("<endpoint>");
            Group5 client = new SubNamespaceSecondClient(endpoint, default).GetGroup5Client();

            Response response = client.Six();

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Group5_Six_ShortVersion_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            Group5 client = new SubNamespaceSecondClient(endpoint, default).GetGroup5Client();

            Response response = await client.SixAsync();

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public void Example_Group5_Six_AllParameters()
        {
            Uri endpoint = new Uri("<endpoint>");
            Group5 client = new SubNamespaceSecondClient(endpoint, default).GetGroup5Client();

            Response response = client.Six();

            Console.WriteLine(response.Status);
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Example_Group5_Six_AllParameters_Async()
        {
            Uri endpoint = new Uri("<endpoint>");
            Group5 client = new SubNamespaceSecondClient(endpoint, default).GetGroup5Client();

            Response response = await client.SixAsync();

            Console.WriteLine(response.Status);
        }
    }
}
