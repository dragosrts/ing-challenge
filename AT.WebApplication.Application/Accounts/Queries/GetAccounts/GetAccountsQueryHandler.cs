using AT.WebApplication.Application.Interfaces;
using AT.WebApplication.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace AT.WebApplication.Application.Accounts.Queries.GetAccounts
{
    public class GetAccountsQueryHandler : IRequestHandler<GetAccountsQuery, IEnumerable<Account>>
    {
        private readonly IGetAccounts getAccounts;

        public GetAccountsQueryHandler(IGetAccounts getAccounts)
        {
            this.getAccounts = getAccounts;
        }

        public Task<IEnumerable<Account>> Handle(GetAccountsQuery request, CancellationToken cancellationToken)
        {
            return getAccounts.GetAccounts();
        }
    }
}