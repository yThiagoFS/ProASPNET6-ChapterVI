using NuGet.Frameworks;
using SimpleApp.Models;
using Xunit;


namespace SimpleApp.Tests 
{
    public class ProductTests 
    {
        [Fact]
        public void CanChangeProductName()
        {
            // Arrange
            var p = new Product { Name = "Test", Price = 100M };

            // Act
            p.Name = "New Name";

            // Assert
            Assert.Equal("New Name", p.Name);
        }
        [Fact]
        public void CanChangeProductPrice()
        {
            // Arrange
            var p = new Product { Name = "Test", Price = 100M };

            // Act
            p.Price = 50M;

            // Assert
            Assert.Equal(50M, p.Price);

        }
        [Fact]
        public void IsGreaterThanFifty()
        {
            // Arrange / Act
            var p = new Product { Name = "Test", Price = 52 };

            Assert.True(p.Price > 50);
            
        }
    }

}

