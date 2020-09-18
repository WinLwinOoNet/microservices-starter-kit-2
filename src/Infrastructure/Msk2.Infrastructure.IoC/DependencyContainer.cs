using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Msk2.Banking.Application.Interfaces;
using Msk2.Banking.Application.Services;
using Msk2.Banking.Data.Context;
using Msk2.Banking.Data.Repositories;
using Msk2.Banking.Domain.CommandHandlers;
using Msk2.Banking.Domain.Commands;
using Msk2.Banking.Domain.Events;
using Msk2.Banking.Domain.Interfaces;
using Msk2.Domain.Core.Bus;
using Msk2.Infrastructure.Bus;

namespace Msk2.Infrastructure.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // message bus
            services.AddTransient<IEventBus, RabbitMQBus>();

            // commands
            services.AddTransient<IRequestHandler<CreateTransferCommand, bool>, TransferCommandHandler>();

            // services
            services.AddTransient<IAccountService, AccountService>();

            // data
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<BankingDbContext>();
        }
    }
}
