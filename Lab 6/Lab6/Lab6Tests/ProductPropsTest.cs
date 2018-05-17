using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Lab6PropsClasses;

namespace Lab6Tests
{
   [TestFixture]
   public class ProductPropsTest
    {
        public ProductsProps p = new ProductsProps();

        [SetUp]
        public void SetupTests()
        {
           
            p.ID = 100;
            p.code = "xxx";
            p.description = "my test product";
            p.quantity = 2;
            p.unitPrice = 99;
        }
      
        [Test]
        public void TestGetState()
        {
           
            string xml = p.GetState();
            Assert.Greater(xml.Length, 0);
            Assert.True(xml.Contains(p.description));
            Console.WriteLine(xml);
        }
        [Test]
        public void TestSetState()
        {
            ProductsProps newP =  new ProductsProps();
            string xml = p.GetState();
            newP.SetState(xml);
            Assert.AreEqual(newP.ID, p.ID);
            Assert.AreEqual(newP.description, p.description);
            Assert.AreEqual(newP.unitPrice, p.unitPrice);
            Assert.AreEqual(newP.quantity, p.quantity);
            Assert.AreEqual(newP.code, p.code);
        }
        [Test]
        public void TestClone()
        {
            ProductsProps newP = (ProductsProps) p.Clone();
            Assert.AreEqual(newP.ID, p.ID);
            Assert.AreEqual(newP.description, p.description);
            Assert.AreEqual(newP.unitPrice, p.unitPrice);
            Assert.AreEqual(newP.quantity, p.quantity);
            Assert.AreEqual(newP.code, p.code);
        }
    }
}
