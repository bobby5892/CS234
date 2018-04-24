using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CloneCustomer;


namespace CloneCustomerTests
{
    [TestFixture]
    public class Class1
    {
        //Declare
        Customer customer;
        CustomerList customerList;

        [SetUp]
        public void SetupAllTests()
        {
            // initialize
            customer = new Customer();
            customerList = new CustomerList();
        }

        [Test]
        public void DefaultTest()
        {
            Assert.IsTrue(true);
        }
        [Test]
        public void AdjustCustomer()
        {
            this.customer.FirstName = "Rob";
            this.customer.LastName = "Moore";
            this.customer.Email = "moorerb@my.lanecc.edu";

            Assert.AreEqual("Rob", this.customer.FirstName);
            Assert.AreEqual("Moore", this.customer.LastName);
            Assert.AreEqual("moorerb@my.lanecc.edu", this.customer.Email);
        }
        [Test]
        public void CreateClones()
        {
            // Run the previous test
            this.AdjustCustomer();

            // Clone the Customer
            int timesToDo = 1000;
            do {
                customerList.Add((Customer)customer.Clone());
                timesToDo--;
            } while (timesToDo > 0);

            Assert.AreEqual(1000, customerList.Count);
           
        }


    }
}
