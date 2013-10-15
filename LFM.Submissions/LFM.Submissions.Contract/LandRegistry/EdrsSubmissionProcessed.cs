using System;
using NServiceBus;

namespace LFMSubmissions.Contract.LandRegistry
{
    public class EdrsSubmissionProcessed
    {
        public SubmissionStatus SubmissionStatus { get; set; }
        public string MessageId { get; set; }
    }

    public enum SubmissionStatus
    {
        Processing,
        Accepted,
        Rejected
    }
}
