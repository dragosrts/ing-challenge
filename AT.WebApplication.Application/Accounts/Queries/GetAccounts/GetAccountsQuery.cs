using AT.WebApplication.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace AT.WebApplication.Application.Accounts.Queries.GetAccounts
{
    public class GetAccountsQuery : IRequest<IEnumerable<Account>>
    {
    }
}