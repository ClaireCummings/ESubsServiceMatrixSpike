using System;
using LFMSubmissions.Contract.LandRegistry;
using NServiceBus;
using LFMSubmissions.InternalMessages.LandRegistry;


namespace LFMSubmissions.LandRegistry
{
    public partial class SubmitEdrsProcessor : IHandleMessages<SubmitEdrs>
    {
		
		public void Handle(SubmitEdrs message)
		{
			this.HandleImplementation(message);

			this.Bus.Publish<LFMSubmissions.Contract.LandRegistry.EdrsSubmissionAccepted>(e =>
			    {
			        e.MessageId = message.MessageId; /* set properties on e in here */
			    });
			this.Bus.Publish<LFMSubmissions.Contract.LandRegistry.EdrsSubmissionProcessed>(e =>
			    {
			        e.MessageId = message.MessageId;
			        e.SubmissionStatus = SubmissionStatus.Accepted; /* set properties on e in here */
			    });
		}

		partial void HandleImplementation(SubmitEdrs message);

		public IBus Bus { get; set; }

    }
}
