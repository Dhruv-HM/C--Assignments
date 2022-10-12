using Entities;
using NUnit.Framework;
using Repositories;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace test
{
    [TestFixture]
    public class ProductRepositoryTest
    {
        readonly ProductRepository repository;
        readonly List<Product> productList;
        public  ProductRepositoryTest()
        {
            productList = new List<Product>
            {
                new Product{
                    ProductId = 1001,
                    ProductName = "Titan black dial watch for women",
                    Price = 2200,
                    InStock = true
                }
            };

            repository = new ProductRepository(productList);
        }

        [Test, Order(1)]
        public void Should_AddProduct_Return_Index()
        {
            var product = new Product
            {
                ProductId = 1002,
                ProductName = "Titan white square dial watch for men",
                Price = 2500,
                InStock = true
            };
            repository.AddProduct(product);

            Assert.That(productList, Has.Count.EqualTo(2), message: "Count of total products must be 2");
            
        }

        [Test, Order(2)]
        public void Should_GetProduct_ById_Return_Product()
        {
            var result = repository.GetProduct(1001);

            Assert.That(result, Is.Not.Null,message:"Product Cannot be Null");
            Assert.That(result.ProductName, Is.EqualTo("Titan black dial watch for women"), message: "Product Name must be \'Titan black dial watch for women\'");

        }
        [Test, Order(3)]
        public void Should_GetProduct_ByName_Return_Product()
        {
            var result = repository.GetProduct("Titan black dial watch for women");

            Assert.That(result, Is.Not.Null, message: "Product Cannot be Null");
            Assert.That(result.Price, Is.EqualTo(2200), message: "Price must be 2200");
        }

        [Test, Order(4)]
        public void Should_GetProducts_Return_List()
        {
            var result = repository.GetAllProducts();

            Assert.That(result, Is.TypeOf<List<Product>>(), message: "List<Product> should be returned");
            Assert.That(result.Count, Is.EqualTo(2), message: "Count of products must be 2");
        }

        [Test, Order(5)]
        public void Should_RemoveProduct_Return_True()
        {
            var result = repository.RemoveProduct(1002);

            Assert.That(result, Is.True, message: "RemoveProduct() should return true for valid product id");
            Assert.That(productList, Has.Count.EqualTo(1), message: "Count of products should be 1");
            Assert.That(productList[0].Price, Is.EqualTo(2200), message: "Price should be 2200");
        }

        [Test, Order(6)]
        public void Should_GetProduct_ById_Return_Null()
        {
            var result = repository.GetProduct(1000);

            Assert.That(result, Is.Null, message: "Null value should be returned for invalid product id");
        }

        [Test, Order(7)]
        public void Should_GetProduct_ByName_Return_Null()
        {
            var result = repository.GetProduct("Titan black dial watch for men");

            Assert.That(result, Is.Null, message: "Null value should be returned for invalid product name");
        }

        [Test, Order(8)]
        public void Should_RemoveProduct_Return_False()
        {
            var result = repository.RemoveProduct(1000);

            Assert.That(result, Is.False, message: "RemoveProduct() should return false for invalid product id");
        }

        [Test, Order(9)]
        public void Should_AddProduct_NotAdd_Null()
        {
            repository.AddProduct(null);

            Assert.That(productList, Has.Count.EqualTo(1), message: "Cannot add null to product list");
        }

    }
}
