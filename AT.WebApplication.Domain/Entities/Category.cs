using AT.WebApplication.Domain.Common;

namespace AT.WebApplication.Domain.Entities
{
    public class Category : Enumeration
    {
        public static readonly Category Unspecified = new Category(0, "Unspecified");
        public static readonly Category Food = new Category(1, "Food");
        public static readonly Category Entertainment = new Category(2, "Entertainment");
        public static readonly Category Clothing = new Category(3, "Clothing");
        public static readonly Category Travel = new Category(4, "Travel");
        public static readonly Category MedicalExpenses = new Category(5, "Medical expenses");

        private Category(int value, string displayName) : base(value, displayName)
        {
        }
    }
}