using AutoMapper;
using EmailingList.Application.ViewModels;
using EmailingList.Domain.Models;

namespace EmailingList.Application.AutoMapper
{
    public class DomainToViewModelProfile : Profile
    {
        public DomainToViewModelProfile()
        {
            CreateMap<EmailList, EmailListViewModel>();
        }
    }
}
