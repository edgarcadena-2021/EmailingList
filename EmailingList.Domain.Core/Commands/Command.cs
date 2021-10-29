using EmailingList.Domain.Core.Events;
using System;

namespace EmailingList.Domain.Core.Commands
{
    public class Command : Message
    {
        public DateTime Timespan { get; protected set; }

        public Command()
        {
            Timespan = DateTime.Now;
        }
    }
}
