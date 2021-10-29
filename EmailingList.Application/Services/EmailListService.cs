using AutoMapper;
using AutoMapper.QueryableExtensions;
using EmailingList.Application.Interfaces;
using EmailingList.Application.ViewModels;
using EmailingList.Domain.Commands;
using EmailingList.Domain.Core.Bus;
using EmailingList.Domain.Interfaces;
using System.Collections.Generic;

namespace EmailingList.Application.Services
{
    public class EmailListService : IEmailListService
    {
        private readonly IEmailListRepository _emailListRepository;
        private readonly IMediatorHandler _bus;
        private readonly IMapper _mapper;

        public EmailListService(IEmailListRepository emailListRepository, IMediatorHandler bus, IMapper mapper)
        {
            _emailListRepository = emailListRepository;
            _bus = bus;
            _mapper = mapper;
        }

        public void Create(EmailListViewModel courseViewModel)
        {
            _bus.SendCommand(_mapper.Map<CreateEmailListCommand>(courseViewModel));
        }

        public IEnumerable<EmailListViewModel> GetEmailList()
        {
            return _emailListRepository.GetEmailList().ProjectTo<EmailListViewModel>(_mapper.ConfigurationProvider);
        }
    }
}
