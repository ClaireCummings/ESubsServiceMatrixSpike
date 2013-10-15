using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NServiceBus;

namespace LFM.Submissions.Backend
{
    public class MessageConventions : IWantToRunBeforeConfiguration
    {
        public void Init()
        {
            Configure.Instance
            .DefiningCommandsAs(t => t.Namespace != null && t.Namespace.StartsWith("LFMSubmissions.InternalMessages"))
            .DefiningEventsAs(t => t.Namespace != null && t.Namespace.StartsWith("LFMSubmissions.Contract"));
        }
    }
}

