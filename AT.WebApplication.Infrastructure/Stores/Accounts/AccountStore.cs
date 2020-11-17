using AT.WebApplication.Application.Interfaces;
using AT.WebApplication.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AT.WebApplication.Infrastructure.Stores.Accounts
{
    public class AccountStore : IGetAccounts
    {
        public async Task<IEnumerable<Account>> GetAccounts()
        {
            var accountList = new List<Account>();

            var acc1 = new Account
            {
                ResourceId = "450ffbb8-9f11-4ec6-a1e1-df48aefc82ef",
                Product = "Betaalrekening",
                Iban = "NL69INGB0123456789",
                Name = "Hr A van Dijk , Mw B Mol-van Dijk",
                Currency = "EUR",
            };
            accountList.Add(acc1);

            return await Task.FromResult(accountList);
        }
    }
}