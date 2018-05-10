using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace CustomerMaintenance
{
    class ProductDB
    {
        public static Product GetProduct(string ProductCode)
        {
            SqlConnection connection = MMABooksDB.GetConnection();
            string selectStatement
                = "SELECT ProductCode, Description, UnitPrice, OnHandQuantity "
                + "FROM Products "
                + "WHERE ProductCode = @ProductCode";
            SqlCommand selectCommand =
                new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@ProductCode", ProductCode);

            try
            {
                connection.Open();
                SqlDataReader prodReader =
                    selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (prodReader.Read())
                {
                    Product product = new Product();
                    product.ProductCode = (string)prodReader["ProductCode"].ToString();
                    product.Description = (string)prodReader["Description"].ToString();
                    product.UnitPrice = (decimal)prodReader["UnitPrice"];
                    product.OnHandQuantity = (int)prodReader["OnHandQuantity"];
                   
                    return product;
                }
                else
                {
                    return null;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }
        public static bool UpdateProduct(Product oldProduct,
        Product newProduct)
        {
            SqlConnection connection = MMABooksDB.GetConnection();
            string updateStatement =
                "UPDATE Products SET " +
                "Description = @newDescription, " +
                "UnitPrice = @newUnitPrice, " +
                "OnHandQuantity = @newOnHandQuantity " +
                "WHERE ProductCode = @newProductCode " +
                "AND Description = @OldDescription " +
                "AND UnitPrice = @OldUnitPrice " +
                "AND OnHandQuantity = @OldOnHandQuantity ";
               
            SqlCommand updateCommand =
                new SqlCommand(updateStatement, connection);
            updateCommand.Parameters.AddWithValue(
                "@newDescription", newProduct.Description);
            updateCommand.Parameters.AddWithValue(
                "@newUnitPrice", newProduct.UnitPrice);
            updateCommand.Parameters.AddWithValue(
                "@newOnHandQuantity", newProduct.OnHandQuantity);
            updateCommand.Parameters.AddWithValue(
                "@OldDescription", oldProduct.Description);
            updateCommand.Parameters.AddWithValue(
                "@OldUnitPrice", oldProduct.UnitPrice);
            updateCommand.Parameters.AddWithValue(
                "@OldOnHandQuantity", oldProduct.OnHandQuantity);
           
            try
            {
                connection.Open();
                int count = updateCommand.ExecuteNonQuery();
                if (count == 1)
                    return true;
                else
                    return false;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }
        public static bool AddProduct(Product product)
        {
            SqlConnection connection = MMABooksDB.GetConnection();
            string insertStatement =
                "INSERT Products " +
                "(ProductCode, Description, UnitPrice, OnHandQuantity) " +
                "VALUES (@ProductCode, @Description, @UnitPrice, @OnHandQuantity)";
            SqlCommand insertCommand =
                new SqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue(
                "@ProductCode", product.ProductCode);
            insertCommand.Parameters.AddWithValue(
                "@Description", product.Description);
            insertCommand.Parameters.AddWithValue(
                "@UnitPrice", product.UnitPrice);
            insertCommand.Parameters.AddWithValue(
                "@OnHandQuantity", product.OnHandQuantity);
        
            try
            {
                connection.Open();
                insertCommand.ExecuteNonQuery();
                string selectStatement =
                    "SELECT count(*) FROM Products WHERE ProductCode=@ProductCode";
                SqlCommand selectCommand =
                    new SqlCommand(selectStatement, connection);

                selectCommand.Parameters.AddWithValue(
				"@ProductCode", product.ProductCode);

                int count = Convert.ToInt32(selectCommand.ExecuteScalar());
                if(count == 1) { return true; }
                return false;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }
        public static bool DeleteProduct(Product product)
        {
            SqlConnection connection = MMABooksDB.GetConnection();
            string deleteStatement =
                "DELETE FROM Products " +
                "WHERE ProductCode = @ProductCode " +
                "AND Description = @Description " +
                "AND UnitPrice = @UnitPrice " +
                "AND OnHandQuantity = @OnHandQuantity ";
            SqlCommand deleteCommand =
                new SqlCommand(deleteStatement, connection);
            deleteCommand.Parameters.AddWithValue(
                "@ProductCode", product.ProductCode);
            deleteCommand.Parameters.AddWithValue(
                "@Description", product.Description);
            deleteCommand.Parameters.AddWithValue(
                "@UnitPrice", product.UnitPrice);
            deleteCommand.Parameters.AddWithValue(
                "@OnHandQuantity", product.OnHandQuantity);
           
            try
            {
                connection.Open();
                int count = deleteCommand.ExecuteNonQuery();
                if (count == 1)
                    return true;
                else
                    return false;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
