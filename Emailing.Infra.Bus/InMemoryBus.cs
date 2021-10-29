using EmailingList.Domain.Core.Bus;
using EmailingList.Domain.Core.Commands;
using MediatR;
using System.Threading.Tasks;

namespace Emailing.Infra.Bus
{
    public class InMemoryBus : IMediatorHandler
    {
        private readonly IMediator _mediator;

        public InMemoryBus(IMediator mediator)
        {
            _mediator = mediator;
        }

        public Task SendCommand<T>(T command) where T : Command
        {
            return _mediator.Send(command);
        }
    }
}
