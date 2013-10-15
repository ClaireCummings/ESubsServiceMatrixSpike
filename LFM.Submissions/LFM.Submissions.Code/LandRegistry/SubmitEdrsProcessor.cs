using System;
using NServiceBus;
using LFMSubmissions.InternalMessages.LandRegistry;


namespace LFMSubmissions.LandRegistry
{
    public partial class SubmitEdrsProcessor
    {
		
        partial void HandleImplementation(SubmitEdrs message)
        {
            // Implement your handler logic here.
            Console.WriteLine("LandRegistry received " + message.GetType().Name);
        }

    }
}
