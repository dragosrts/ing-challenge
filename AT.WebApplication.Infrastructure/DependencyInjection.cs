using AT.WebApplication.Application.Interfaces;
using AT.WebApplication.Infrastructure.Stores.Accounts;
using AT.WebApplication.Infrastructure.Stores.Transactions;
using Microsoft.Extensions.DependencyInjection;

namespace AT.WebApplication.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<IGetAccounts, AccountStore>();
            services.AddTransient<IGetTransactionsReport, TransactionStore>();

            return services;
        }
    }
}