using System;
using LFM.Submissions.LandRegistry.Gateway;
using NServiceBus;
using LFMSubmissions.Contract.LandRegistry;

namespace LFMSubmissions.LandRegistry
{
    public partial class EdrsSubmissionAcceptedProcessor
    {
		
        partial void HandleImplementation(EdrsSubmissionAccepted message)
        {
            // Implement your handler logic here.
            Console.WriteLine("LandRegistry received " + message.GetType().Name +" Id: " + message.MessageId);
            Console.WriteLine("Will now submit the message to the LR Gateway");
            var poller = new EdrsPollActioner { MessageId = message.MessageId, Username = "BGUser001", Password = "LandReg001" };
            var response = poller.SubmitToLRGateway();
            Console.WriteLine("Response from LR Gateway: {0}", response.GatewayResponse.Results.MessageDetails);
        }

    }
}
