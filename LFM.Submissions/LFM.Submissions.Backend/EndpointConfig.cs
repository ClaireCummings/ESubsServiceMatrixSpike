using System;
using NServiceBus;
 
namespace LFM.Submissions.Backend
{
	public partial class EndpointConfig : IConfigureThisEndpoint, AsA_Publisher, ISpecifyMessageHandlerOrdering    
	{
	    public void SpecifyOrder(Order order)
	    {
	        order.Specify(First<LFMSubmissions.LandRegistry.SubmitEdrsProcessor>.Then<LFMSubmissions.SubmissionManager.EdrsSubmissionProcessedProcessor>());
	    }
    }
}
