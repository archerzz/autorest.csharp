// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace CognitiveSearch.Models
{
    /// <summary> Limits the number of tokens while indexing. This token filter is implemented using Apache Lucene. </summary>
    public partial class LimitTokenFilter : TokenFilter
    {
        /// <summary> Initializes a new instance of LimitTokenFilter. </summary>
        public LimitTokenFilter()
        {
            OdataType = "#Microsoft.Azure.Search.LimitTokenFilter";
        }
        /// <summary> The maximum number of tokens to produce. Default is 1. </summary>
        public int? MaxTokenCount { get; set; }
        /// <summary> A value indicating whether all tokens from the input must be consumed even if maxTokenCount is reached. Default is false. </summary>
        public bool? ConsumeAllTokens { get; set; }
    }
}
