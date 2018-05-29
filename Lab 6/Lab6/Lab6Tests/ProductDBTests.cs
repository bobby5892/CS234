using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Lab6PropsClasses;
using Lab6DBClasses;

using System.Data;
using System.Data.SqlClient;

using DBCommand = System.Data.SqlClient.SqlCommand;

namespace Lab6Tests
{
    [TestFixture]
    public class ProductsDBTests
    {
        public ProductsDB db;
        public string dataSource = "Data Source=LAPTOP-57M3IJN1\\SQLEXPRESS;Initial Catalog=MMABooksUpdated;Integrated Security=True";

        [SetUp]
        public void Setup()
        {
            db = new ProductsDB(dataSource);
        }

        [Test]
        public void Retreive()
        {
            ProductsProps p = (ProductsProps)db.Retrieve(8);
            Assert.AreEqual("DB2R", p.code);
        }
        [Test]
        public void RetreiveAll()
        {
            int test = 0;
            List<ProductsProps> listAll = (List<ProductsProps>)db.RetrieveAll(test.GetType());
            Assert.True(listAll.Count != 0);
            Console.WriteLine("Found " + listAll.Count + "records");
        }
        [Test,Order(1)]
        public void Create()
        {
            ProductsProps p = new ProductsProps();
            p.code = "TEST";
            p.description = "Test Product";
            p.quantity = 1;
            p.unitPrice = 10.50m;

            db.Create(p);
            ProductsProps x = (ProductsProps)db.Retrieve(p.ID);
            Assert.AreEqual(x.description, p.description);


        }
        [Test,Order (3)]
        public void Delete()
        {
            int test = 0;
            //ProductsProps p = (ProductsProps)db.Retrieve();
            List<ProductsProps> temp = (List<ProductsProps>) db.RetrieveAll(test.GetType());  
           for(int i=0; i< temp.Count();i++)
            {
                if(temp[i].code == "TEST")
                {
                    Assert.True(db.Delete(db.Retrieve(temp[i].ID)));
                }
            }
            
        }
        [Test, Order(2)]
        public void Update()
        {
            int test = 0;
            List<ProductsProps> temp = (List<ProductsProps>)db.RetrieveAll(test.GetType());
            int i = 0;
            ProductsProps p;
            bool found = false;
            for (; i < temp.Count(); i++)
            {
                if (temp[i].code == "TEST")
                {
                    found = true;
                    break;

                }
            }
            if (found)
            {
                p = (ProductsProps)db.Retrieve(temp[i].ID);
                p.code = "NOTTEST";

                db.Update(p);

                ProductsProps x = (ProductsProps)db.Retrieve(temp[i].ID);
            }
            else
            {
                Assert.Fail();
            }
            //   Assert.True(x.code == p.code);
            //   x.code = "TEST";
            //   db.Update(x);

           

        }
    };
}