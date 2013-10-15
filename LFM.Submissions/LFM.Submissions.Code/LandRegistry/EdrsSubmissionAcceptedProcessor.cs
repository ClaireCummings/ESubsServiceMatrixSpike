using System;
using NServiceBus;
using LFMSubmissions.Contract.LandRegistry;


namespace LFMSubmissions.LandRegistry
{
    public partial class EdrsSubmissionAcceptedProcessor
    {
		
        partial void HandleImplementation(EdrsSubmissionAccepted message)
        {
            // Implement your handler logic here.
            Console.WriteLine("LandRegistry received " + message.GetType().Name);
        }

    }
}
