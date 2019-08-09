using System;
using CleanArch.Domain.Core.Events;

namespace CleanArch.Domain.Core.Commands
{
    public abstract class Command : Message
    {
        public Command()
        {
            Timestamp = DateTime.Now;
        }

        public DateTime Timestamp { get; protected set; }
    }
}