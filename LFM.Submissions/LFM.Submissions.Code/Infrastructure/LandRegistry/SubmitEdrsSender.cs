using System;
using NServiceBus;
using LFMSubmissions.InternalMessages.LandRegistry;

namespace LFMSubmissions.LandRegistry
{
    public partial class SubmitEdrsSender: ISubmitEdrsSender, NServiceBus.INServiceBusComponent
    {
        public void Send(SubmitEdrs message)
		{
			Bus.Send(message);	
		}

        public IBus Bus { get; set; }
    }

    public interface ISubmitEdrsSender
    {
        void Send(SubmitEdrs message);
    }
}
