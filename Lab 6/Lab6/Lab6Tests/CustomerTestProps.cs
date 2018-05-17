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
    public class CustomerPropsTest
    {
        public CustomersProps p = new CustomersProps();

        [SetUp]
        public void SetupTests()
        {

            p.ID = 100;
            p.name = "xxx";
            p.state = "OR";
            p.zipCode = "97477";
            p.city = "Eugene";
            p.address = "123 T Blah";
           
        }

        [Test]
        public void TestGetState()
        {

            string xml = p.GetState();
            Assert.Greater(xml.Length, 0);
            Assert.True(xml.Contains(p.city));
            Console.WriteLine(xml);
        }
        [Test]
        public void TestSetState()
        {
            CustomersProps newP = new CustomersProps();
            string xml = p.GetState();
            newP.SetState(xml);
            Assert.AreEqual(newP.ID, p.ID);
            Assert.AreEqual(newP.name, p.name);
            Assert.AreEqual(newP.state, p.state);
            Assert.AreEqual(newP.zipCode, p.zipCode);
            Assert.AreEqual(newP.city, p.city);
            Assert.AreEqual(newP.address, p.address);
            
        }
        [Test]
        public void TestClone()
        {
            CustomersProps newP = (CustomersProps)p.Clone();
            Assert.AreEqual(newP.ID, p.ID);
            Assert.AreEqual(newP.name, p.name);
            Assert.AreEqual(newP.state, p.state);
            Assert.AreEqual(newP.zipCode, p.zipCode);
            Assert.AreEqual(newP.city, p.city);
            Assert.AreEqual(newP.address, p.address);
        }
    }
}
