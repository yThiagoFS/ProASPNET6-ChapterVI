using Microsoft.AspNetCore.Mvc;
using SimpleApp.Controllers;
using SimpleApp.Models;
using System;


namespace SimpleApp.Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void IndexActionModelIsComplete()
        {
            // Arrange
            var controller = new HomeController();
            Product[] products = new Product[]
            {
                new Product { Name = "Kayak", Price = 275M },
                new Product { Name = "LifeJacket", Price = 48.5M }
            };

            // Act
            var model = (controller.Index() as ViewResult)?.ViewData.Model
                as IEnumerable<Product>;

            // Assert
            Assert.Equal(products, model,
                Comparer.Get<Product>((p1, p2) => 
                p1?.Name == p2?.Name
                && p1?.Price == p2?.Price
                ));

        }
    }
}
