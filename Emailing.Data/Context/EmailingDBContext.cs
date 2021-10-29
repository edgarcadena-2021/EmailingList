using EmailingList.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Emailing.Data.Context
{
    public class EmailingDBContext : DbContext
    {
        public EmailingDBContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<EmailList> EmailLists { get; set; }
    }
}
