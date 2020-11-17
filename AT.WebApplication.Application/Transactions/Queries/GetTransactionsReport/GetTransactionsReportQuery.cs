using AT.WebApplication.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace AT.WebApplication.Application.Transactions.Queries.GetTransactionsReport
{
    public class GetTransactionsReportQuery : IRequest<IEnumerable<TransactionReport>>
    {
    }
}