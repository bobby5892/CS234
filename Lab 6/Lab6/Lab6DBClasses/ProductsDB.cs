﻿using System;
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

        public IBaseProps Create(IBaseProps props)
        {
            throw new NotImplementedException();
        }

        public bool Delete(IBaseProps props)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public bool Update(IBaseProps props)
        {
            throw new NotImplementedException();
        }
    }
}
