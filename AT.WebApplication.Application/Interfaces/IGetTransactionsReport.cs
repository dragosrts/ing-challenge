using AT.WebApplication.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AT.WebApplication.Application.Interfaces
{
    public interface IGetTransactionsReport
    {
        Task<IEnumerable<Transaction>> GetTransactionsReport();
    }
}