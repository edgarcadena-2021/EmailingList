using Emailing.Data.Context;
using Emailing.Data.Repositories;
using Emailing.Infra.Bus;
using EmailingList.Application.Interfaces;
using EmailingList.Application.Services;
using EmailingList.Domain.CommandHandlers;
using EmailingList.Domain.Commands;
using EmailingList.Domain.Core.Bus;
using EmailingList.Domain.Interfaces;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace EmailingList.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Domain InMemoryBus MediatR
            services.AddScoped<IMediatorHandler, InMemoryBus>();

            //Domain Handlers
            services.AddScoped<IRequestHandler<CreateEmailListCommand, bool>, EmailListCommandHandler>();

            //Application Layer
            services.AddScoped<IEmailListService, EmailListService>();

            //Infra.Data Layer
            services.AddScoped<IEmailListRepository, EmailListRepository>();

            services.AddScoped<EmailingDBContext>();
        }
    }
}
