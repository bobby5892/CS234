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
            //ProductsDB db = new ProductsDB(dataSource);

            //DBCommand command = new DBCommand();
            //command.CommandText = "usp_ProductsSelect";
            //command.CommandType = CommandType.StoredProcedure;
            //db.RunNonQueryProcedure(command);
            ProductsProps p = (ProductsProps)db.Retrieve(8);
            Assert.AreEqual("DB2R      ", p.code);
        }
    }
}