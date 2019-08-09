using MediatR;

namespace CleanArch.Domain.Core.Events
{
    public abstract class Message : IRequest<bool>
    {
        public Message()
        {
            MessageType = GetType().Name;
        }

        public string MessageType { get; protected set; }
    }
}