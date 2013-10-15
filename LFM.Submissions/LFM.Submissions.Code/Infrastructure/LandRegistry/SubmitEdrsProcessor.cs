using System;
using NServiceBus;
using LFMSubmissions.InternalMessages.LandRegistry;


namespace LFMSubmissions.LandRegistry
{
    public partial class SubmitEdrsProcessor : IHandleMessages<SubmitEdrs>
    {
		
		public void Handle(SubmitEdrs message)
		{
			this.HandleImplementation(message);

			this.Bus.Publish<LFMSubmissions.Contract.LandRegistry.EdrsSubmissionAccepted>(e => { /* set properties on e in here */ });
		}

		partial void HandleImplementation(SubmitEdrs message);

		public IBus Bus { get; set; }

    }
}
