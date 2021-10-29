using Emailing.Data.Context;
using EmailingList.Domain.Interfaces;
using EmailingList.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace Emailing.Data.Repositories
{
    public class EmailListRepository : IEmailListRepository
    {
        private readonly EmailingDBContext _emailingDBContext;

        public EmailListRepository(EmailingDBContext emailingDBContext)
        {
            _emailingDBContext = emailingDBContext;
        }
        public void Add(EmailList emailList)
        {
            _emailingDBContext.EmailLists.Add(emailList);
            _emailingDBContext.SaveChanges();
        }

        public IQueryable<EmailList> GetEmailList()
        {
            return _emailingDBContext.EmailLists;
        }
    }
}
