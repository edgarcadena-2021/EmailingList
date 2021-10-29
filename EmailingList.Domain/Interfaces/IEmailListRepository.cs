using EmailingList.Domain.Models;
using System.Linq;

namespace EmailingList.Domain.Interfaces
{
    public interface IEmailListRepository
    {
        IQueryable<EmailList> GetEmailList();
        void Add(EmailList emailList);
    }
}
