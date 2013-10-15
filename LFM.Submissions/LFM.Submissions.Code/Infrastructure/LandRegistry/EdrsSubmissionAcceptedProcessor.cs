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
		}

		partial void HandleImplementation(EdrsSubmissionAccepted message);

		public IBus Bus { get; set; }

    }
}
