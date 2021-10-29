using AutoMapper;
using EmailingList.Application.ViewModels;
using EmailingList.Domain.Commands;

namespace EmailingList.Application.AutoMapper
{
    public class ViewModelToDomainProfile : Profile
    {
        public ViewModelToDomainProfile()
        {
            CreateMap<EmailListViewModel, CreateEmailListCommand>()
                .ConstructUsing(c => new CreateEmailListCommand(c.LastName, c.FirstName, c.Email));
        }
    }
}
