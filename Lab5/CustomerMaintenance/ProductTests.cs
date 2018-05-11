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
        Product testProduct2;

        [SetUp]
        public void SetUpAllTests()
        {
            this.testProduct = new Product();
            testProduct.ProductCode = "2JST";
            testProduct.Description = "Murach's JavaScript (2nd Edition)";
            testProduct.UnitPrice = 54.50m;
            testProduct.OnHandQuantity = 6937;

            this.testProduct2 = new Product();
            testProduct2.ProductCode = "2JST";
            testProduct2.Description = "TESTMurach's JavaScript (2nd Edition)";
            testProduct2.UnitPrice = 54.50m;
            testProduct2.OnHandQuantity = 6937;

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
        [Test, Order(4)]
        public void UpdateProduct()
        {

            Assert.True(ProductDB.UpdateProduct(this.testProduct, this.testProduct2));
            Assert.True(ProductDB.UpdateProduct(this.testProduct2, this.testProduct));
        }

    }
}
