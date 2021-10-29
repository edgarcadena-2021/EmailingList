using EmailingList.Domain.Core.Commands;
using System.Threading.Tasks;

namespace EmailingList.Domain.Core.Bus
{
    public interface IMediatorHandler
    {
        Task SendCommand<T>(T command) where T : Command;
    }
}
