﻿using Microsoft.AspNetCore.Mvc;
using SimpleApp.Controllers;
using SimpleApp.Models;
using System;


namespace SimpleApp.Tests
{
    public class HomeControllerTests
    {
        class FakeDataSource : IDataSource
        {
            public FakeDataSource(Product[] data) => Products = data;
            public IEnumerable<Product> Products { get; set; }
        }
        #region before isolating a component
        //public void IndexActionModelIsComplete()
        //{
        //    // Arrange
        //    var controller = new HomeController();
        //    Product[] products = new Product[]
        //    {
        //        new Product { Name = "Kayak", Price = 275M },
        //        new Product { Name = "LifeJacket", Price = 48.5M }
        //    };

        //    // Act
        //    var model = (controller.Index() as ViewResult)?.ViewData.Model
        //        as IEnumerable<Product>;

        //    // Assert
        //    Assert.Equal(products, model,
        //        Comparer.Get<Product>((p1, p2) => 
        //        p1?.Name == p2?.Name
        //        && p1?.Price == p2?.Price
        //        ));
        //}
        #endregion

        #region after isolating a component
        [Fact]
        public void IndexActionModelIsComplete()
        {
            // Arrange
            Product[] testData = new Product[]
            {
                new Product { Name = "P1", Price = 75.10M },
                new Product { Name = "P2", Price = 120M},
                new Product { Name = "P3", Price = 110M }
            };
            IDataSource data = new FakeDataSource(testData);

            var controller = new HomeController();
            controller.dataSource = data;

            // Act
            var model = (controller.Index() as ViewResult)?.ViewData.Model
                as IEnumerable<Product>;

            // Assert
            Assert.Equal(data.Products, model,
                Comparer.Get<Product>((p1, p2) =>
                p1?.Name == p2?.Name &&
                p1?.Price == p2?.Price));
        }
        #endregion
    }
}
