// <auto-generated/>

#nullable disable

using System;

namespace OpenAI.Models
{
    internal static partial class CreateCompletionResponseChoiceFinishReasonExtensions
    {
        public static string ToSerialString(this CreateCompletionResponseChoiceFinishReason value) => value switch
        {
            CreateCompletionResponseChoiceFinishReason.Stop => "stop",
            CreateCompletionResponseChoiceFinishReason.Length => "length",
            CreateCompletionResponseChoiceFinishReason.ContentFilter => "content_filter",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown CreateCompletionResponseChoiceFinishReason value.")
        };

        public static CreateCompletionResponseChoiceFinishReason ToCreateCompletionResponseChoiceFinishReason(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "stop")) return CreateCompletionResponseChoiceFinishReason.Stop;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "length")) return CreateCompletionResponseChoiceFinishReason.Length;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "content_filter")) return CreateCompletionResponseChoiceFinishReason.ContentFilter;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown CreateCompletionResponseChoiceFinishReason value.");
        }
    }
}