using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Lab6PropsClasses;
using ToolsCSharp;

using System.Data;
using System.Data.SqlClient;

// *** I use an "alias" for the ado.net classes throughout my code
// When I switch to an oracle database, I ONLY have to change the actual classes here
using DBBase = ToolsCSharp.BaseSQLDB;
using DBConnection = System.Data.SqlClient.SqlConnection;
using DBCommand = System.Data.SqlClient.SqlCommand;
using DBParameter = System.Data.SqlClient.SqlParameter;
using DBDataReader = System.Data.SqlClient.SqlDataReader;
using DBDataAdapter = System.Data.SqlClient.SqlDataAdapter;

namespace Lab6DBClasses
{
    public class ProductsDB : DBBase, IReadDB, IWriteDB
    {
        public ProductsDB() : base() { }
        public ProductsDB(string cnString) : base(cnString) { }
        public ProductsDB(DBConnection cn) : base(cn) { }

        public IBaseProps Create(IBaseProps p)
        {
            int rowsAffected = 0;
            ProductsProps props = (ProductsProps)p;

            DBCommand command = new DBCommand();
            command.CommandText = "usp_ProductsCreate";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@ProductID", SqlDbType.Int);
            command.Parameters.Add("@ProductCode", SqlDbType.Char);
            command.Parameters.Add("@Description", SqlDbType.VarChar);
            command.Parameters.Add("@UnitPrice", SqlDbType.Money);
            command.Parameters.Add("@OnHandQuantity", SqlDbType.Int);
           

            command.Parameters[0].Direction = ParameterDirection.Output;
            command.Parameters["@ProductCode"].Value = props.code;
            command.Parameters["@Description"].Value = props.description;
            command.Parameters["@UnitPrice"].Value = props.unitPrice;
            command.Parameters["@OnHandQuantity"].Value = props.quantity;
            //props.ID = (int) command.Parameters["@ProductID"].Value;

            try
            {
                rowsAffected = RunNonQueryProcedure(command);
                if (rowsAffected == 1)
                {
                    props.ID = (int)command.Parameters[0].Value;
                    props.ConcurrencyID = 1;
                    return props;
                }
                else
                    throw new Exception("Unable to insert record. " + props.ToString());
            }
            catch (Exception e)
            {
                // log this error
                throw;
            }
            finally
            {
                if (mConnection.State == ConnectionState.Open)
                    mConnection.Close();
            }
        }

        public bool Delete(IBaseProps props)
        {
            ProductsProps x = (ProductsProps)props;
            ProductsProps temp = (ProductsProps) Retrieve(x.ID);

            int rowsAffected = 0;
            ProductsProps p = (ProductsProps) props;
            DBCommand command = new DBCommand();
            command.CommandText = "usp_ProductsDelete";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@ProductID", SqlDbType.Int);
            command.Parameters["@ProductID"].Value =p.ID;
            command.Parameters.Add("@ConcurrencyID", SqlDbType.Int);
            command.Parameters["@ConcurrencyID"].Value = temp.ConcurrencyID;
            try
            {
                rowsAffected = RunNonQueryProcedure(command);
                if (rowsAffected != 1)
                {
                    string message = "Record was not deleted. Perhaps the key you specified does not exist.";
                    throw new Exception(message);
                }
                return true;
            }
            catch (Exception e)
            {
                // log this error
                throw;
            }
            finally
            {
                if (mConnection.State == ConnectionState.Open)
                    mConnection.Close();
            }
            return (rowsAffected != 0);
        }

        public IBaseProps Retrieve(object key)
        {
            DBDataReader data = null;
            ProductsProps props = new ProductsProps();
            DBCommand command = new DBCommand();

            command.CommandText = "usp_ProductsSelect";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@ProductID", SqlDbType.Int);
            command.Parameters["@ProductID"].Value = (Int32)key;

            try
            {
                data = RunProcedure(command);
                if (!data.IsClosed)
                {
                    if (data.Read())
                    {
                        props.SetState(data);
                    }
                    else
                        throw new Exception("Record does not exist in the database.");
                }
                return props;
            }
            catch (Exception e)
            {
                // log this exception
                throw;
            }
            finally
            {
                if (data != null)
                {
                    if (!data.IsClosed)
                        data.Close();
                }
            }
        }

        public object RetrieveAll(Type type)
        {
            List<ProductsProps> results = new List<ProductsProps>();
            DBDataReader data = null;
            ProductsProps props = new ProductsProps();
            DBCommand command = new DBCommand();

            command.CommandText = "usp_ProductsSelectAll";
            command.CommandType = CommandType.StoredProcedure;
           

            try
            {
                data = RunProcedure(command);
                if (!data.IsClosed)
                {
                    while (data.Read())
                    {
                        props = new ProductsProps();
                        props.SetState(data);
                        results.Add(props);
                       
                    }
                  
                }
                return results;
            }
            catch (Exception e)
            {
                // log this exception
                throw;
            }
            finally
            {
                if (data != null)
                {
                    if (!data.IsClosed)
                        data.Close();
                }
            }
        }

        public bool Update(IBaseProps p)
        {
            int rowsAffected = 0;
            ProductsProps props = (ProductsProps)p;

            DBCommand command = new DBCommand();
            command.CommandText = "usp_ProductsUpdate";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@ProductID", SqlDbType.Int);
            command.Parameters.Add("@ProductCode", SqlDbType.Char);
            command.Parameters.Add("@Description", SqlDbType.NVarChar);
            command.Parameters.Add("@UnitPrice", SqlDbType.Money);
            command.Parameters.Add("@OnHandQuanity", SqlDbType.Int);
            command.Parameters.Add("@ConcurrencyID", SqlDbType.Int);
            command.Parameters["@ProductID"].Value = props.ID;
            command.Parameters["@ProductCode"].Value = props.code;
            command.Parameters["@UnitPrice"].Value = props.unitPrice;
            command.Parameters["@OnHandQuanity"].Value = props.quantity;
            command.Parameters["@Description"].Value = props.description;
            command.Parameters["@ConcurrencyID"].Value = props.ConcurrencyID;

            try
            {
                rowsAffected = RunNonQueryProcedure(command);
                if (rowsAffected == 1)
                {
                    props.ConcurrencyID++;
                    return true;
                }
                else
                {
                    string message = "Record cannot be updated. It has been edited by another user.";
                    throw new Exception(message);
                }
            }
            catch (Exception e)
            {
                // log this exception
                throw;
            }
            finally
            {
                if (mConnection.State == ConnectionState.Open)
                    mConnection.Close();
            }
        }
    }
}
