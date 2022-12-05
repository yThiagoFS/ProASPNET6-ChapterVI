namespace SimpleApp.Models
{
    public class Product
    {
        public string Name { get; set; } = string.Empty;

        public decimal? Price { get; set; }

        public static Product?[] GetProducts()
        {
            return new Product?[]
            {
                new Product { Name = "Kayak", Price = 275M },
                new Product { Name = "LifeJacket", Price = 48.5M }
            };
        }
    }
}
