using System;
using NServiceBus;
using LFMSubmissions.Contract.LandRegistry;


namespace LFMSubmissions.SubmissionManager
{
    public partial class EdrsSubmissionProcessedProcessor
    {
		
        partial void HandleImplementation(EdrsSubmissionProcessed message)
        {
            // Implement your handler logic here.
            Console.WriteLine("SubmissionManager received " + message.GetType().Name + " Id: " +message.MessageId + " Status: " + message.SubmissionStatus);
        }

    }
}
