using System;
using LFM.Submissions.LandRegistry.Gateway;
using LFM.Submissions.LandRegistry.Gateway.EdrsPollRequestService;
using NServiceBus;
using LFMSubmissions.Contract.LandRegistry;

namespace LFMSubmissions.LandRegistry
{
    public partial class EdrsSubmissionAcceptedProcessor
    {
        public SubmissionStatus ResponseStatus { get; set; }

        partial void HandleImplementation(EdrsSubmissionAccepted message)
        {
            // Implement your handler logic here.
            Console.WriteLine("LandRegistry received " + message.GetType().Name +" Id: " + message.MessageId);
            Console.WriteLine("Will now submit the message to the LR Gateway");
            var poller = new EdrsPollActioner { MessageId = message.MessageId, Username = "BGUser001", Password = "LandReg001" };
            var response = poller.SubmitToLRGateway();
            
            switch (response.GatewayResponse.TypeCode)
            {
                case ProductResponseCodeContentType.Item10:
                    ResponseStatus = SubmissionStatus.Acknowledgement;
                    break;
                case ProductResponseCodeContentType.Item20:
                    ResponseStatus = SubmissionStatus.Rejection;
                    break;
                case ProductResponseCodeContentType.Item30:
                    ResponseStatus = SubmissionStatus.Results;
                    break;
                default:
                    ResponseStatus = SubmissionStatus.Other;
                    break;
            }
        }
    }
}
