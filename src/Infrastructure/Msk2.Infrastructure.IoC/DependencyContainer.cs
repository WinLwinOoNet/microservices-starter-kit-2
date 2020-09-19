using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Msk2.Banking.Application.Interfaces;
using Msk2.Banking.Application.Services;
using Msk2.Banking.Data.Context;
using Msk2.Banking.Data.Repositories;
using Msk2.Banking.Domain.CommandHandlers;
using Msk2.Banking.Domain.Commands;
using Msk2.Banking.Domain.Interfaces;
using Msk2.Domain.Core.Bus;
using Msk2.Infrastructure.Bus;
using Msk2.Transfer.Application.Interfaces;
using Msk2.Transfer.Application.Services;
using Msk2.Transfer.Data.Context;
using Msk2.Transfer.Data.Repositories;
using Msk2.Transfer.Domain.EventHandlers;
using Msk2.Transfer.Domain.Events;
using Msk2.Transfer.Domain.Interfaces;

namespace Msk2.Infrastructure.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // message bus
            services.AddSingleton<IEventBus, RabbitMQBus>(sp =>
            {
                var scopeFactory = sp.GetRequiredService<IServiceScopeFactory>();
                return new RabbitMQBus(sp.GetService<IMediator>(), scopeFactory);
            });

            // subscriptions
            services.AddTransient<TransferEventHandler>();

            // commands
            services.AddTransient<IRequestHandler<CreateTransferCommand, bool>, TransferCommandHandler>();

            // events
            services.AddTransient<IEventHandler<TransferCreatedEvent>, TransferEventHandler>();

            // services
            services.AddTransient<IAccountService, AccountService>();
            services.AddTransient<ITransferService, TransferService>();

            // data
            services.AddTransient<IAccountRepository, AccountRepository>();
            services.AddTransient<ITransferRepository, TransferRepository>();

            services.AddTransient<BankingDbContext>();
            services.AddTransient<TransferDbContext>();
        }
    }
}
