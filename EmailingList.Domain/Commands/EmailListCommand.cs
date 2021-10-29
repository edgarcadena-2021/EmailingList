using EmailingList.Domain.Core.Commands;

namespace EmailingList.Domain.Commands
{
    public class EmailListCommand : Command
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
    }
}
