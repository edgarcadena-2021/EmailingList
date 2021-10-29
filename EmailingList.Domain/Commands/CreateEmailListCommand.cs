namespace EmailingList.Domain.Commands
{
    public class CreateEmailListCommand: EmailListCommand
    {
        public CreateEmailListCommand(string lastName, string firstName, string email)
        {
            LastName = lastName;
            FirstName = firstName;
            Email = email;
        }
    }
}
