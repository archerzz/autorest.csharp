// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.ClientModel.Internal;

namespace OpenAI.Models
{
    /// <summary> The ListFineTunesResponse. </summary>
    public partial class ListFineTunesResponse
    {
        /// <summary> Initializes a new instance of ListFineTunesResponse. </summary>
        /// <param name="object"></param>
        /// <param name="data"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="object"/> or <paramref name="data"/> is null. </exception>
        internal ListFineTunesResponse(string @object, IEnumerable<FineTune> data)
        {
            ClientUtilities.AssertNotNull(@object, nameof(@object));
            ClientUtilities.AssertNotNull(data, nameof(data));

            Object = @object;
            Data = data.ToList();
        }

        /// <summary> Initializes a new instance of ListFineTunesResponse. </summary>
        /// <param name="object"></param>
        /// <param name="data"></param>
        internal ListFineTunesResponse(string @object, IReadOnlyList<FineTune> data)
        {
            Object = @object;
            Data = data;
        }

        /// <summary> Gets the object. </summary>
        public string Object { get; }
        /// <summary> Gets the data. </summary>
        public IReadOnlyList<FineTune> Data { get; }
    }
}
