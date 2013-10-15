using System;
using NServiceBus;
using LFMSubmissions.Contract.LandRegistry;


namespace LFMSubmissions.SubmissionManager
{
    public partial class EdrsSubmissionProcessedProcessor : IHandleMessages<EdrsSubmissionProcessed>
    {
		
		public void Handle(EdrsSubmissionProcessed message)
		{
			this.HandleImplementation(message);
		}

		partial void HandleImplementation(EdrsSubmissionProcessed message);

		public IBus Bus { get; set; }

    }
}
