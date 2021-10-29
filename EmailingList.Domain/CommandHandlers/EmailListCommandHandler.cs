using EmailingList.Domain.Commands;
using EmailingList.Domain.Interfaces;
using EmailingList.Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EmailingList.Domain.CommandHandlers
{
    public class EmailListCommandHandler : IRequestHandler<CreateEmailListCommand, bool>
    {
        private readonly IEmailListRepository _emailListRepository;

        public EmailListCommandHandler(IEmailListRepository emailListRepository)
        {
            _emailListRepository = emailListRepository;
        }

        public Task<bool> Handle(CreateEmailListCommand request, CancellationToken cancellationToken)
        {
            var emailList = new EmailList()
            {
                LastName = request.LastName,
                FirstName = request.FirstName,
                Email = request.Email
            };
            _emailListRepository.Add(emailList);
            return Task.FromResult(true);
        }
    }
}
