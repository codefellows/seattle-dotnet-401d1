using Class19Demo.Models;
using System;
using Xunit;
using System.Collections.Generic;
using Class19Demo.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace MyTests.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void CanChangeProductPrice()
        {
            // Arrange
            var p = new Product { Price = 10m };

            //Act
            p.Price = 20M;

            //Assert
            Assert.Equal(20M, p.Price);
        }

        [Fact]
        public void TestRepositoryChangeInProductsController()
        {
            //Arrange
            var controller = new ProductsController();
            controller._repo = new DuanesRepository();

            // Act
            var model = (controller.Index() as ViewResult)?.ViewData.Model
                as IEnumerable<Product>;

            // Assert

            
            //p1 is equal to the first product in the _repo.products.
            // p2 is equal to the first produt in the model (the fake repo located below)
            // this Assert.Equal method is asking if p1 is equal to p2 in both price and name.
           
            Assert.Equal(controller._repo.Products, model,
                    Comparer.Get<Product>((p1, p2) => p1.Name == p2.Name
                    && p1.Price == p2.Price));

        }


        class DuanesRepository : IRepository
        {
            public IEnumerable<Product> Products => new List<Product>
            {
                new Product {Name = "P1", Price= 50M, SKU = "Sku123", ID=1},
                new Product {Name = "P2", Price= 60M, SKU = "Sku183", ID=3},
                new Product {Name = "P3", Price= 80M, SKU = "Sku123", ID=6}


            };
        }



    }
}
