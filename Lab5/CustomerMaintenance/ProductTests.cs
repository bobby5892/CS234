using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CustomerMaintenance
{
    [TestFixture]
    public class ProductTests
    {
        Product testProduct;
        [SetUp]
        public void SetUpAllTests()
        {
            this.testProduct = new Product();
            testProduct.ProductCode = "2JST";
            testProduct.Description = "Murach's JavaScript (2nd Edition)";
            testProduct.UnitPrice = 54.50m;
            testProduct.OnHandQuantity = 6937;

        }

        [Test]
        public void basic()
        {
            Assert.IsTrue(true);
        }
        [Test, Order(1)]
        public void getProduct()
        {
            Product fromDB = ProductDB.GetProduct(this.testProduct.ProductCode);
            Assert.AreEqual(fromDB.Description,testProduct.Description);
            Assert.AreEqual(fromDB.UnitPrice, testProduct.UnitPrice);
            Assert.AreEqual(fromDB.OnHandQuantity, testProduct.OnHandQuantity);
        }
        [Test, Order(2)]
        public void DeleteProduct()
        {
            Assert.True(ProductDB.DeleteProduct(this.testProduct));
        }
        [Test, Order(3)]
        public void InsertProduct()
        {
            Assert.True(ProductDB.AddProduct(this.testProduct));
        }

    }
}
