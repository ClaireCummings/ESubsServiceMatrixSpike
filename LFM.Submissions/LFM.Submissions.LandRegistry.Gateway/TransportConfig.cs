using System;
using NServiceBus;
 
namespace LFM.Submissions.LandRegistry.Gateway
{
	public class TransportConfig : INeedInitialization
	{
		public void Init()
		{
			// Tranport: Msmq (Default) - No configuration needed
		}
	}
}
