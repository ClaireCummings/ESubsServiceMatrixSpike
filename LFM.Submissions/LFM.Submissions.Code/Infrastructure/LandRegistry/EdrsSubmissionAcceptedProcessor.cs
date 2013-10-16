using System;
using NServiceBus;
using LFMSubmissions.Contract.LandRegistry;


namespace LFMSubmissions.LandRegistry
{
    public partial class EdrsSubmissionAcceptedProcessor : IHandleMessages<EdrsSubmissionAccepted>
    {
		
		public void Handle(EdrsSubmissionAccepted message)
		{
			this.HandleImplementation(message);

			this.Bus.Publish<LFMSubmissions.Contract.LandRegistry.EdrsSubmissionProcessed>(e =>
			    {
			        e.MessageId = message.MessageId;
			        e.SubmissionStatus = ResponseStatus; /* set properties on e in here */
			    });
		}

		partial void HandleImplementation(EdrsSubmissionAccepted message);

		public IBus Bus { get; set; }

    }
}
