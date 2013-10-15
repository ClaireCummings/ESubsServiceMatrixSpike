using System;
using NServiceBus;
 
namespace LFM.Submissions.Client
{
	public class TransportConfig : INeedInitialization
	{
		public void Init()
		{
			// Tranport: Msmq (Default) - No configuration needed
  		}
	}
}
