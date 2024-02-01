// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstTestTypeSpec.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class FirstTestTypeSpecModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="Models.Thing"/>. </summary>
        /// <param name="name"> name of the Thing. </param>
        /// <param name="requiredUnion"> required Union. </param>
        /// <param name="requiredLiteralString"> required literal string. </param>
        /// <param name="requiredLiteralInt"> required literal int. </param>
        /// <param name="requiredLiteralFloat"> required literal float. </param>
        /// <param name="requiredLiteralBool"> required literal bool. </param>
        /// <param name="optionalLiteralString"> optional literal string. </param>
        /// <param name="optionalLiteralInt"> optional literal int. </param>
        /// <param name="optionalLiteralFloat"> optional literal float. </param>
        /// <param name="optionalLiteralBool"> optional literal bool. </param>
        /// <param name="requiredBadDescription"> description with xml &lt;|endoftext|&gt;. </param>
        /// <param name="optionalNullableList"> optional nullable collection. </param>
        /// <param name="requiredNullableList"> required nullable collection. </param>
        /// <returns> A new <see cref="Models.Thing"/> instance for mocking. </returns>
        public static Thing Thing(string name = null, BinaryData requiredUnion = null, ThingRequiredLiteralString requiredLiteralString = default, ThingRequiredLiteralInt requiredLiteralInt = default, ThingRequiredLiteralFloat requiredLiteralFloat = default, bool requiredLiteralBool = default, ThingOptionalLiteralString? optionalLiteralString = null, ThingOptionalLiteralInt? optionalLiteralInt = null, ThingOptionalLiteralFloat? optionalLiteralFloat = null, bool? optionalLiteralBool = null, string requiredBadDescription = null, IEnumerable<int> optionalNullableList = null, IEnumerable<int> requiredNullableList = null)
        {
            optionalNullableList ??= new List<int>();
            requiredNullableList ??= new List<int>();

            return new Thing(name, requiredUnion, requiredLiteralString, requiredLiteralInt, requiredLiteralFloat, requiredLiteralBool, optionalLiteralString, optionalLiteralInt, optionalLiteralFloat, optionalLiteralBool, requiredBadDescription, optionalNullableList?.ToList(), requiredNullableList?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.Extension"/>. </summary>
        /// <param name="extension"></param>
        /// <param name="level"></param>
        /// <returns> A new <see cref="Models.Extension"/> instance for mocking. </returns>
        public static Extension Extension(IEnumerable<Extension> extension = null, int level = default)
        {
            extension ??= new List<Extension>();

            return new Extension(extension?.ToList(), serializedAdditionalRawData: null, level);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ThereLevelExtension"/>. </summary>
        /// <param name="extension"></param>
        /// <param name="level"></param>
        /// <returns> A new <see cref="Models.ThereLevelExtension"/> instance for mocking. </returns>
        public static ThereLevelExtension ThereLevelExtension(IEnumerable<ThereLevelExtension> extension = null, int level = default)
        {
            extension ??= new List<ThereLevelExtension>();

            return new ThereLevelExtension(extension?.ToList(), serializedAdditionalRawData: null, level);
        }

        /// <summary> Initializes a new instance of <see cref="Models.RoundTripModel"/>. </summary>
        /// <param name="requiredString"> Required string, illustrating a reference type property. </param>
        /// <param name="requiredInt"> Required int, illustrating a value type property. </param>
        /// <param name="requiredCollection"> Required collection of enums. </param>
        /// <param name="requiredDictionary"> Required dictionary of enums. </param>
        /// <param name="requiredModel"> Required model. </param>
        /// <param name="intExtensibleEnum"> this is an int based extensible enum. </param>
        /// <param name="intExtensibleEnumCollection"> this is a collection of int based extensible enum. </param>
        /// <param name="floatExtensibleEnum"> this is a float based extensible enum. </param>
        /// <param name="floatExtensibleEnumCollection"> this is a collection of float based extensible enum. </param>
        /// <param name="floatFixedEnum"> this is a float based fixed enum. </param>
        /// <param name="floatFixedEnumCollection"> this is a collection of float based fixed enum. </param>
        /// <param name="intFixedEnum"> this is a int based fixed enum. </param>
        /// <param name="intFixedEnumCollection"> this is a collection of int based fixed enum. </param>
        /// <param name="stringFixedEnum"> this is a string based fixed enum. </param>
        /// <param name="requiredUnknown"> required unknown. </param>
        /// <param name="optionalUnknown"> optional unknown. </param>
        /// <param name="requiredRecordUnknown"> required record of unknown. </param>
        /// <param name="optionalRecordUnknown"> optional record of unknown. </param>
        /// <param name="readOnlyRequiredRecordUnknown"> required readonly record of unknown. </param>
        /// <param name="readOnlyOptionalRecordUnknown"> optional readonly record of unknown. </param>
        /// <param name="modelWithRequiredNullable"> this is a model with required nullable properties. </param>
        /// <returns> A new <see cref="Models.RoundTripModel"/> instance for mocking. </returns>
        public static RoundTripModel RoundTripModel(string requiredString = null, int requiredInt = default, IEnumerable<StringFixedEnum> requiredCollection = null, IDictionary<string, StringExtensibleEnum> requiredDictionary = null, Thing requiredModel = null, IntExtensibleEnum? intExtensibleEnum = null, IEnumerable<IntExtensibleEnum> intExtensibleEnumCollection = null, FloatExtensibleEnum? floatExtensibleEnum = null, IEnumerable<FloatExtensibleEnum> floatExtensibleEnumCollection = null, FloatFixedEnum? floatFixedEnum = null, IEnumerable<FloatFixedEnum> floatFixedEnumCollection = null, IntFixedEnum? intFixedEnum = null, IEnumerable<IntFixedEnum> intFixedEnumCollection = null, StringFixedEnum? stringFixedEnum = null, BinaryData requiredUnknown = null, BinaryData optionalUnknown = null, IDictionary<string, BinaryData> requiredRecordUnknown = null, IDictionary<string, BinaryData> optionalRecordUnknown = null, IReadOnlyDictionary<string, BinaryData> readOnlyRequiredRecordUnknown = null, IReadOnlyDictionary<string, BinaryData> readOnlyOptionalRecordUnknown = null, ModelWithRequiredNullableProperties modelWithRequiredNullable = null)
        {
            requiredCollection ??= new List<StringFixedEnum>();
            requiredDictionary ??= new Dictionary<string, StringExtensibleEnum>();
            intExtensibleEnumCollection ??= new List<IntExtensibleEnum>();
            floatExtensibleEnumCollection ??= new List<FloatExtensibleEnum>();
            floatFixedEnumCollection ??= new List<FloatFixedEnum>();
            intFixedEnumCollection ??= new List<IntFixedEnum>();
            requiredRecordUnknown ??= new Dictionary<string, BinaryData>();
            optionalRecordUnknown ??= new Dictionary<string, BinaryData>();
            readOnlyRequiredRecordUnknown ??= new Dictionary<string, BinaryData>();
            readOnlyOptionalRecordUnknown ??= new Dictionary<string, BinaryData>();

            return new RoundTripModel(requiredString, requiredInt, requiredCollection?.ToList(), requiredDictionary, requiredModel, intExtensibleEnum, intExtensibleEnumCollection?.ToList(), floatExtensibleEnum, floatExtensibleEnumCollection?.ToList(), floatFixedEnum, floatFixedEnumCollection?.ToList(), intFixedEnum, intFixedEnumCollection?.ToList(), stringFixedEnum, requiredUnknown, optionalUnknown, requiredRecordUnknown, optionalRecordUnknown, readOnlyRequiredRecordUnknown, readOnlyOptionalRecordUnknown, modelWithRequiredNullable, serializedAdditionalRawData: null);
        }
    }
}
