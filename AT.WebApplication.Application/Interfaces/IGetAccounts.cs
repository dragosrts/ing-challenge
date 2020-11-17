using AT.WebApplication.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AT.WebApplication.Application.Interfaces
{
    public interface IGetAccounts
    {
        Task<IEnumerable<Account>> GetAccounts();
    }
}