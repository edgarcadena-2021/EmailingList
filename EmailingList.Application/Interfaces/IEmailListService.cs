using EmailingList.Application.ViewModels;
using System.Collections.Generic;

namespace EmailingList.Application.Interfaces
{
    public interface IEmailListService
    {
        IEnumerable<EmailListViewModel> GetEmailList();
        void Create(EmailListViewModel emailListViewModel);
    }
}
