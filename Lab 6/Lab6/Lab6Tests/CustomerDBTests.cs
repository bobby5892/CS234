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
    class CustomerDBTests
    {
        public CustomersDB db;
        public string dataSource = "Data Source=LAPTOP-57M3IJN1\\SQLEXPRESS;Initial Catalog=MMABooksUpdated;Integrated Security=True";

        [SetUp]
        public void Setup()
        {
            db = new CustomersDB(dataSource);
        }

        [Test]
        public void Retreive()
        {
            CustomersProps p = (CustomersProps)db.Retrieve(8);
            Assert.AreEqual("Plano", p.city);
            Console.WriteLine(p.ID + " " + p.name + " " + p.address);
        }
        [Test]
        public void RetreiveAll()
        {
            int test = 0;
            List<CustomersProps> listAll = (List<CustomersProps>)db.RetrieveAll(test.GetType());
            Assert.True(listAll.Count != 0);
            Console.WriteLine("Found " + listAll.Count + "records");
        }
        [Test, Order(1)]
        public void Create()
        {
            CustomersProps p = new CustomersProps();
            p.name = "TEST";
            p.address = "address";
            p.city = "testcity";
            p.state = "OR";
            p.zipCode = "75025-0587";

            CustomersProps x = (CustomersProps) db.Create(p);
           
            Assert.AreEqual(x.name, p.name);


        }
        [Test, Order(3)]
        public void Delete()
        {
            int test = 0;
            //ProductsProps p = (ProductsProps)db.Retrieve();
            List<CustomersProps> temp = (List<CustomersProps>)db.RetrieveAll(test.GetType());
            for (int i = 0; i < temp.Count(); i++)
            {
                if (temp[i].name == "TEST")
                {
                    Assert.True(db.Delete(temp[i]));
                    break;
                }
            }

        }
        [Test, Order(2)]
        public void Update()
        {
            int test = 0;
            List<CustomersProps> temp = (List<CustomersProps>)db.RetrieveAll(test.GetType());
            int i = 0;
            CustomersProps p;
            bool found = false;
            for (; i < temp.Count(); i++)
            {
                if (temp[i].name == "TEST")
                {
                    found = true;
                    break;

                }
            }
            if (found)
            {
                p = (CustomersProps)db.Retrieve(temp[i].ID);
                p.name = "NOTTEST";

                db.Update(p);

                CustomersProps x = (CustomersProps)db.Retrieve(temp[i].ID);
            }
            else
            {
                Assert.Fail();
            }
        



        }
    }
}
