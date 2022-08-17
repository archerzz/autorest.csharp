﻿using System;
using System.Collections.Generic;
using System.Text;
using AutoRest.CSharp.Common.Input;
using AutoRest.CSharp.Generation.Types;
using AutoRest.CSharp.Generation.Writers;
using AutoRest.CSharp.Output.Models.Types;
using NUnit.Framework;

namespace AutoRest.CSharp.Generation.Writers.Tests
{
    public class ReadonlyPropertyWritingTests : ModelGenerationTestBase
    {
        [TestCaseSource(nameof(RoundTripModelCase))]
        public void RoundTripModel(string expectedModelCodes, string expectedSerializationCodes)
        {
            // refer to the original CADL file: https://github.com/Azure/cadl-ranch/blob/main/packages/cadl-ranch-specs/http/models/readonly-properties/main.cadl
            // TODO: add model types after resolving how to deal with properties of model types
            var model = new ModelTypeProvider(
                new InputModelType("RoundTripModel", "Cadl.TestServer.ReadonlyProperties.Models", "public", InputModelTypeUsage.RoundTrip,
                    new List<InputModelProperty>{
                        new InputModelProperty("requiredReadonlyString", "requiredReadonlyString", "Required string, illustrating a readonly reference type property.", InputPrimitiveType.String, true, true, false),
                        new InputModelProperty("requiredReadonlyInt", "requiredReadonlyInt", "Required int, illustrating a readonly reference type property.", InputPrimitiveType.Int32, true, true, false),
                        new InputModelProperty("optionalReadonlyString", "optionalReadonlyString", "Optional string, illustrating a readonly reference type property.", InputPrimitiveType.String, true, true, false),
                        new InputModelProperty("optionalReadonlyInt", "optionalReadonlyInt", "Optional int, illustrating a readonly reference type property.", InputPrimitiveType.Int32, true, true, false),
                        new InputModelProperty("requiredReadonlyStringList", "requiredReadonlyStringList", "Required readonly string collection.", new InputListType("requiredReadonlyStringList", InputPrimitiveType.String), true, true, false),
                        new InputModelProperty("requiredReadonlyIntList", "requiredReadonlyIntList", "Required readonly int collection.", new InputListType("requiredReadonlyIntList", InputPrimitiveType.Int32), true, true, false),
                        new InputModelProperty("optionalReadonlyStringList", "optionalReadonlyStringList", "Optional readonly string collection.", new InputListType("optionalReadonlyStringList", InputPrimitiveType.String), true, true, false),
                        new InputModelProperty("optionalReadonlyIntList", "optionalReadonlyIntList", "Optional readonly int collection.", new InputListType("optionalReadonlyIntList", InputPrimitiveType.Int32), true, true, false),
                    },
                    null, null, null),
                new TypeFactory(null),
                "test",
                null);

            ValidateGeneratedCodes(model, expectedModelCodes, expectedSerializationCodes);
        }

        // below are test cases
        private static readonly object[] RoundTripModelCase =
        {
            new string[]
            {
                @"// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Cadl.TestServer.ReadonlyProperties.Models
{
public partial class RoundTripModel
{
/// <summary> Initializes a new instance of RoundTripModel. </summary>
public RoundTripModel()
{
RequiredReadonlyStringList = new List<string>(0).AsReadOnly();
RequiredReadonlyIntList = new List<int>(0).AsReadOnly();
OptionalReadonlyStringList = new List<string>(0).AsReadOnly();
OptionalReadonlyIntList = new List<int>(0).AsReadOnly();
}
/// <summary> Initializes a new instance of RoundTripModel. </summary>
/// <param name=""requiredReadonlyString""> Required string, illustrating a readonly reference type property. </param>
/// <param name=""requiredReadonlyInt""> Required int, illustrating a readonly reference type property. </param>
/// <param name=""optionalReadonlyString""> Optional string, illustrating a readonly reference type property. </param>
/// <param name=""optionalReadonlyInt""> Optional int, illustrating a readonly reference type property. </param>
/// <param name=""requiredReadonlyStringList""> Required readonly string collection. </param>
/// <param name=""requiredReadonlyIntList""> Required readonly int collection. </param>
/// <param name=""optionalReadonlyStringList""> Optional readonly string collection. </param>
/// <param name=""optionalReadonlyIntList""> Optional readonly int collection. </param>
/// <exception cref=""global::System.ArgumentNullException""> <paramref name=""requiredReadonlyString""/>, <paramref name=""optionalReadonlyString""/>, <paramref name=""requiredReadonlyStringList""/>, <paramref name=""requiredReadonlyIntList""/>, <paramref name=""optionalReadonlyStringList""/> or <paramref name=""optionalReadonlyIntList""/> is null. </exception>
internal RoundTripModel(string requiredReadonlyString,int requiredReadonlyInt,string optionalReadonlyString,int optionalReadonlyInt,global::System.Collections.Generic.IReadOnlyList<string> requiredReadonlyStringList,global::System.Collections.Generic.IReadOnlyList<int> requiredReadonlyIntList,global::System.Collections.Generic.IReadOnlyList<string> optionalReadonlyStringList,global::System.Collections.Generic.IReadOnlyList<int> optionalReadonlyIntList)
{
global::Azure.Core.Argument.AssertNotNull(requiredReadonlyString, nameof(requiredReadonlyString));
global::Azure.Core.Argument.AssertNotNull(optionalReadonlyString, nameof(optionalReadonlyString));
global::Azure.Core.Argument.AssertNotNull(requiredReadonlyStringList, nameof(requiredReadonlyStringList));
global::Azure.Core.Argument.AssertNotNull(requiredReadonlyIntList, nameof(requiredReadonlyIntList));
global::Azure.Core.Argument.AssertNotNull(optionalReadonlyStringList, nameof(optionalReadonlyStringList));
global::Azure.Core.Argument.AssertNotNull(optionalReadonlyIntList, nameof(optionalReadonlyIntList));

RequiredReadonlyString = requiredReadonlyString;
RequiredReadonlyInt = requiredReadonlyInt;
OptionalReadonlyString = optionalReadonlyString;
OptionalReadonlyInt = optionalReadonlyInt;
RequiredReadonlyStringList = requiredReadonlyStringList;
RequiredReadonlyIntList = requiredReadonlyIntList;
OptionalReadonlyStringList = optionalReadonlyStringList;
OptionalReadonlyIntList = optionalReadonlyIntList;
}

/// <summary> Required string, illustrating a readonly reference type property. </summary>
public string RequiredReadonlyString{ get; }

/// <summary> Required int, illustrating a readonly reference type property. </summary>
public int RequiredReadonlyInt{ get; }

/// <summary> Optional string, illustrating a readonly reference type property. </summary>
public string OptionalReadonlyString{ get; }

/// <summary> Optional int, illustrating a readonly reference type property. </summary>
public int OptionalReadonlyInt{ get; }

/// <summary> Required readonly string collection. </summary>
public global::System.Collections.Generic.IReadOnlyList<string> RequiredReadonlyStringList{ get; }

/// <summary> Required readonly int collection. </summary>
public global::System.Collections.Generic.IReadOnlyList<int> RequiredReadonlyIntList{ get; }

/// <summary> Optional readonly string collection. </summary>
public global::System.Collections.Generic.IReadOnlyList<string> OptionalReadonlyStringList{ get; }

/// <summary> Optional readonly int collection. </summary>
public global::System.Collections.Generic.IReadOnlyList<int> OptionalReadonlyIntList{ get; }
}
}
",
                @"// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Cadl.TestServer.ReadonlyProperties.Models
{
public partial class RoundTripModel: global::Azure.Core.IUtf8JsonSerializable
{
void global::Azure.Core.IUtf8JsonSerializable.Write(global::System.Text.Json.Utf8JsonWriter writer)
{
writer.WriteStartObject();
writer.WriteEndObject();
}

internal static global::Cadl.TestServer.ReadonlyProperties.Models.RoundTripModel DeserializeRoundTripModel(global::System.Text.Json.JsonElement element)
{
string requiredReadonlyString = default;
int requiredReadonlyInt = default;
string optionalReadonlyString = default;
int optionalReadonlyInt = default;
global::System.Collections.Generic.IReadOnlyList<string> requiredReadonlyStringList = default;
global::System.Collections.Generic.IReadOnlyList<int> requiredReadonlyIntList = default;
global::System.Collections.Generic.IReadOnlyList<string> optionalReadonlyStringList = default;
global::System.Collections.Generic.IReadOnlyList<int> optionalReadonlyIntList = default;
foreach (var property in element.EnumerateObject())
{
if(property.NameEquals(""requiredReadonlyString"")){
requiredReadonlyString = property.Value.GetString();
continue;
}
if(property.NameEquals(""requiredReadonlyInt"")){
requiredReadonlyInt = property.Value.GetInt32();
continue;
}
if(property.NameEquals(""optionalReadonlyString"")){
optionalReadonlyString = property.Value.GetString();
continue;
}
if(property.NameEquals(""optionalReadonlyInt"")){
optionalReadonlyInt = property.Value.GetInt32();
continue;
}
if(property.NameEquals(""requiredReadonlyStringList"")){
global::System.Collections.Generic.List<string> array = new global::System.Collections.Generic.List<string>();
foreach (var item in property.Value.EnumerateArray())
{
array.Add(item.GetString());}
requiredReadonlyStringList = array;
continue;
}
if(property.NameEquals(""requiredReadonlyIntList"")){
global::System.Collections.Generic.List<int> array = new global::System.Collections.Generic.List<int>();
foreach (var item in property.Value.EnumerateArray())
{
array.Add(item.GetInt32());}
requiredReadonlyIntList = array;
continue;
}
if(property.NameEquals(""optionalReadonlyStringList"")){
global::System.Collections.Generic.List<string> array = new global::System.Collections.Generic.List<string>();
foreach (var item in property.Value.EnumerateArray())
{
array.Add(item.GetString());}
optionalReadonlyStringList = array;
continue;
}
if(property.NameEquals(""optionalReadonlyIntList"")){
global::System.Collections.Generic.List<int> array = new global::System.Collections.Generic.List<int>();
foreach (var item in property.Value.EnumerateArray())
{
array.Add(item.GetInt32());}
optionalReadonlyIntList = array;
continue;
}
}
return new global::Cadl.TestServer.ReadonlyProperties.Models.RoundTripModel(requiredReadonlyString, requiredReadonlyInt, optionalReadonlyString, optionalReadonlyInt, requiredReadonlyStringList, requiredReadonlyIntList, optionalReadonlyStringList, optionalReadonlyIntList);}

internal global::Azure.Core.RequestContent ToRequestContent()
{
var content = new global::Azure.Core.Utf8JsonRequestContent();
content.JsonWriter.WriteObjectValue(this);
return content;
}

internal static global::Cadl.TestServer.ReadonlyProperties.Models.RoundTripModel FromResponse(global::Azure.Response response)
{
using var document = global::System.Text.Json.JsonDocument.Parse(response.Content);
return DeserializeRoundTripModel(document.RootElement);
}
}
}
"
            }
        };
    }
}
