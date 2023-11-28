// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace paging.Models
{
    /// <summary> Parameter group. </summary>
    public partial class PagingGetMultiplePagesWithOffsetOptions
    {
        /// <summary> Initializes a new instance of <see cref="PagingGetMultiplePagesWithOffsetOptions"/>. </summary>
        /// <param name="offset"> Offset of return value. </param>
        public PagingGetMultiplePagesWithOffsetOptions(int offset)
        {
            Offset = offset;
        }

        /// <summary> Sets the maximum number of items to return in the response. </summary>
        public int? Maxresults { get; set; }
        /// <summary> Offset of return value. </summary>
        public int Offset { get; }
        /// <summary> Sets the maximum time that the server can spend processing the request, in seconds. The default is 30 seconds. </summary>
        public int? Timeout { get; set; }
    }
}
