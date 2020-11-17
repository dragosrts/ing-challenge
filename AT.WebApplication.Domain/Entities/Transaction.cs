using System;

namespace AT.WebApplication.Domain.Entities
{
    public class Transaction
    {
        public int TransactionId { get; init; }

        public string Iban { get; init; }

        public double Amount { get; init; }

        public Category Category { get; init; }

        public DateTime TransactionDate { get; init; }
    }
}