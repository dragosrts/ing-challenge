using AT.WebApplication.Application.Interfaces;
using AT.WebApplication.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AT.WebApplication.Application.Transactions.Queries.GetTransactionsReport
{
    public class GetTransactionsReportQueryHandler : IRequestHandler<GetTransactionsReportQuery, IEnumerable<TransactionReport>>
    {
        private readonly IGetTransactionsReport getTransactionsReport;
        private readonly IGetAccounts getAccounts;

        public GetTransactionsReportQueryHandler(IGetTransactionsReport getTransactionsReport, IGetAccounts getAccounts)
        {
            this.getTransactionsReport = getTransactionsReport;
            this.getAccounts = getAccounts;
        }

        public async Task<IEnumerable<TransactionReport>> Handle(GetTransactionsReportQuery request, CancellationToken cancellationToken)
        {
            var transactions = await getTransactionsReport.GetTransactionsReport();

            var accounts = await getAccounts.GetAccounts();

            var results = from tran in transactions
                          group tran by tran.Category.Value into gr
                          join acc in accounts on gr.FirstOrDefault().Iban equals acc.Iban
                          select new TransactionReport
                          {
                              CategoryName = gr.FirstOrDefault().Category.DisplayName,
                              TotalAmount = gr.Sum(pc => pc.Amount).ToString(),
                              Currency = acc.Currency.ToString(),
                          };

            return results;
        }
    }
}