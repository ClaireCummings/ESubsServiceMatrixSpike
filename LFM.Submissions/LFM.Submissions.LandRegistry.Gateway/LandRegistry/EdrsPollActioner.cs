using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.Text;
using LFM.Submissions.LandRegistry.Gateway.EdrsPollRequestService;
using LFM.Submissions.LandRegistry.Gateway.LandRegistry;

namespace LFM.Submissions.LandRegistry.Gateway
{
    public class EdrsPollActioner
    {

        public string MessageId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public ResponseApplicationToChangeRegisterV1_0Type SubmitToLRGateway()
        {
            var request = new PollRequestType
                {
                    ID = new Q1IdentifierType {MessageID = new MessageIDTextType {Value = MessageId}}
                };

            // create an instance of the client
            var client = new EDocumentRegistrationV1_0PollRequestServiceClient();

            // overwrite endpoint address 
            client.ChannelFactory.Endpoint.Address =
                new EndpointAddress(
                    @"https://bgtest.landregistry.gov.uk/b2b/ECDRS_StubService/EDocumentRegistrationV1_0PollRequestWebService");

            // overwrite endpointBehavior attributes
            client.ChannelFactory.Credentials.ClientCertificate.SetCertificate(StoreLocation.CurrentUser, StoreName.My,
                                                                               X509FindType.FindBySerialNumber,
                                                                               "47 ce 29 6f");

            // create a Header Instance
            client.ChannelFactory.Endpoint.Behaviors.Add(new HMLRBGMessageEndpointBehavior(Username,Password));

            // submit the request
            return client.getResponse(request);
        }
    }
}
