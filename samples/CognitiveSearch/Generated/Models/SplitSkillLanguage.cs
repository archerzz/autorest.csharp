// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace CognitiveSearch.Models
{
    /// <summary> The language codes supported for input text by SplitSkill. </summary>
    public readonly partial struct SplitSkillLanguage : IEquatable<SplitSkillLanguage>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SplitSkillLanguage"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SplitSkillLanguage(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DaValue = "da";
        private const string DeValue = "de";
        private const string EnValue = "en";
        private const string EsValue = "es";
        private const string FiValue = "fi";
        private const string FrValue = "fr";
        private const string ItValue = "it";
        private const string KoValue = "ko";
        private const string PtValue = "pt";

        /// <summary> Danish. </summary>
        public static SplitSkillLanguage Da { get; } = new SplitSkillLanguage(DaValue);
        /// <summary> German. </summary>
        public static SplitSkillLanguage De { get; } = new SplitSkillLanguage(DeValue);
        /// <summary> English. </summary>
        public static SplitSkillLanguage En { get; } = new SplitSkillLanguage(EnValue);
        /// <summary> Spanish. </summary>
        public static SplitSkillLanguage Es { get; } = new SplitSkillLanguage(EsValue);
        /// <summary> Finnish. </summary>
        public static SplitSkillLanguage Fi { get; } = new SplitSkillLanguage(FiValue);
        /// <summary> French. </summary>
        public static SplitSkillLanguage Fr { get; } = new SplitSkillLanguage(FrValue);
        /// <summary> Italian. </summary>
        public static SplitSkillLanguage It { get; } = new SplitSkillLanguage(ItValue);
        /// <summary> Korean. </summary>
        public static SplitSkillLanguage Ko { get; } = new SplitSkillLanguage(KoValue);
        /// <summary> Portuguese. </summary>
        public static SplitSkillLanguage Pt { get; } = new SplitSkillLanguage(PtValue);
        /// <summary> Determines if two <see cref="SplitSkillLanguage"/> values are the same. </summary>
        public static bool operator ==(SplitSkillLanguage left, SplitSkillLanguage right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SplitSkillLanguage"/> values are not the same. </summary>
        public static bool operator !=(SplitSkillLanguage left, SplitSkillLanguage right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SplitSkillLanguage"/>. </summary>
        public static implicit operator SplitSkillLanguage(string value) => new SplitSkillLanguage(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SplitSkillLanguage other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SplitSkillLanguage other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
