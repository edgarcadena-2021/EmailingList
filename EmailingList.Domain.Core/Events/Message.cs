using MediatR;

namespace EmailingList.Domain.Core.Events
{
    public abstract class Message : IRequest<bool>
    {
        public string MessageType { get; set; }
        public Message()
        {
            MessageType = GetType().Name;
        }
    }
}
