using AT.WebApplication.Application.Interfaces;
using AT.WebApplication.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AT.WebApplication.Infrastructure.Stores.Transactions
{
    public class TransactionStore : IGetTransactionsReport
    {
        public async Task<IEnumerable<Transaction>> GetTransactionsReport()
        {
            var transactionList = new List<Transaction>();

            var tr1 = new Transaction
            {
                TransactionId = 1,
                Amount = 20.00,
                Iban = "NL69INGB0123456789",
                Category = Category.Food,
                TransactionDate = DateTime.Parse("2020-10-23"),
            };
            transactionList.Add(tr1);

            var tr2 = new Transaction
            {
                TransactionId = 2,
                Amount = 27.19,
                Iban = "NL69INGB0123456789",
                Category = Category.MedicalExpenses,
                TransactionDate = DateTime.Parse("2020-08-23"),
            };
            transactionList.Add(tr2);

            var tr3 = new Transaction
            {
                TransactionId = 3,
                Amount = 20.00,
                Iban = "NL69INGB0123456789",
                Category = Category.Clothing,
                TransactionDate = DateTime.Parse("2020-09-23"),
            };
            transactionList.Add(tr3);

            var tr4 = new Transaction
            {
                TransactionId = 4,
                Amount = 27.90,
                Iban = "NL69INGB0123456789",
                Category = Category.Food,
                TransactionDate = DateTime.Parse("2020-09-23"),
            };
            transactionList.Add(tr4);

            return await Task.FromResult(transactionList);
        }
    }
}