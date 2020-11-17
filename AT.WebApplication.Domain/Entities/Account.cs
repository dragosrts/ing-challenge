namespace AT.WebApplication.Domain.Entities
{
    public class Account
    {
        public string ResourceId { get; init; }

        public string Product { get; init; }

        public string Iban { get; init; }

        public string Name { get; init; }

        public string Currency { get; init; }
    }
}