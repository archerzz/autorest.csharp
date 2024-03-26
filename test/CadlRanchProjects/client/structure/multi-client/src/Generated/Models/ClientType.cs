// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Client.Structure.Service.Multiple.Client.Models
{
    /// <summary> The ClientType. </summary>
    public readonly partial struct ClientType : IEquatable<ClientType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ClientType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ClientType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DefaultValue = "default";
        private const string MultiClientValue = "multi-client";
        private const string RenamedOperationValue = "renamed-operation";
        private const string TwoOperationGroupValue = "two-operation-group";

        /// <summary> default. </summary>
        public static ClientType Default { get; } = new ClientType(DefaultValue);
        /// <summary> multi-client. </summary>
        public static ClientType MultiClient { get; } = new ClientType(MultiClientValue);
        /// <summary> renamed-operation. </summary>
        public static ClientType RenamedOperation { get; } = new ClientType(RenamedOperationValue);
        /// <summary> two-operation-group. </summary>
        public static ClientType TwoOperationGroup { get; } = new ClientType(TwoOperationGroupValue);
        /// <summary> Determines if two <see cref="ClientType"/> values are the same. </summary>
        public static bool operator ==(ClientType left, ClientType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ClientType"/> values are not the same. </summary>
        public static bool operator !=(ClientType left, ClientType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ClientType"/>. </summary>
        public static implicit operator ClientType(string value) => new ClientType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ClientType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ClientType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
