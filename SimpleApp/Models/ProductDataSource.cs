namespace SimpleApp.Models
{
    public class ProductDataSource : IDataSource
    {
        public IEnumerable<Product> Products =>
            new Product[]
            {
                new Product { Name = "Kayak", Price = 270M },
                new Product { Name = "LifeJacket", Price = 48.5M }
            };
    }
}
