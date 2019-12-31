using System;

namespace Actio.Common.Events
{
    public interface IRejectedEvent : IEvent
    {

        string Reason { get; }
        string Code { get; }

    }
}