// <auto-generated/>

#nullable disable

using System;

namespace OpenAI.Models
{
    internal static partial class FineTuningJobStatusExtensions
    {
        public static string ToSerialString(this FineTuningJobStatus value) => value switch
        {
            FineTuningJobStatus.Created => "created",
            FineTuningJobStatus.Pending => "pending",
            FineTuningJobStatus.Running => "running",
            FineTuningJobStatus.Succeeded => "succeeded",
            FineTuningJobStatus.Failed => "failed",
            FineTuningJobStatus.Cancelled => "cancelled",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown FineTuningJobStatus value.")
        };

        public static FineTuningJobStatus ToFineTuningJobStatus(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "created")) return FineTuningJobStatus.Created;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "pending")) return FineTuningJobStatus.Pending;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "running")) return FineTuningJobStatus.Running;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "succeeded")) return FineTuningJobStatus.Succeeded;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "failed")) return FineTuningJobStatus.Failed;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "cancelled")) return FineTuningJobStatus.Cancelled;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown FineTuningJobStatus value.");
        }
    }
}