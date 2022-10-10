using Entities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    [TestFixture]
    public class ProductTest
    {
        readonly Product product;
        public ProductTest()
        {
            product = new Product
            {
                Price = 2300,
                ProductId = 1005,
                ProductName = "Timex sports watch for men"
            };
        }

        [Test]
        public void Should_Test_Product_Model()
        {
            Assert.That(product, Has.Property("ProductId").TypeOf<int>(),"Product must have property ProductId of type integer");
            Assert.That(product, Has.Property("ProductName").TypeOf<string>(), "Product must have property ProductName of type string");
            Assert.That(product, Has.Property("Price").TypeOf<int>(), "Product must have property Price of type integer");
            Assert.That(product, Has.Property("InStock").TypeOf<bool>(), "Product must have property InStock of type bool");
        }
    }
}
