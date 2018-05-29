using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

using Lab6DBClasses;
using lab6classes;

using ProductDB = Lab6DBClasses.ProductsDB;
using DBCommand = System.Data.SqlClient.SqlCommand;
namespace Lab6Test
{
    [TestFixture]
    public class Lab6Test
    {
        Products p;
     
        public ProductsDB db;
        public string dataSource = "Data Source=LAPTOP-57M3IJN1\\SQLEXPRESS;Initial Catalog=MMABooksUpdated;Integrated Security=True";

        [SetUp]
        public void SetUp()
        {
            db = new ProductsDB(dataSource);
        }

        [Test]
        public void Test()
        {
            Assert.True(true);
        }
        [Test]
        public void LoadFromDatabase()
        {
            p = new Products(7, dataSource);
            Assert.True(p.ID == 7);
            Console.WriteLine(p.ID + " " + p.code + " " + p.description);
        }
    }
}
