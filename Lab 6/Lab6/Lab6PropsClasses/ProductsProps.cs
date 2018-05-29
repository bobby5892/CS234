using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using ToolsCSharp;
using DBDataReader = System.Data.SqlClient.SqlDataReader;

namespace Lab6PropsClasses
{
    [Serializable()]
    public class ProductsProps : IBaseProps
    {
      

            #region instance variables
            /// <summary>
            /// 
            /// </summary>
            public int ID = Int32.MinValue;

            /// <summary>
            /// 
            /// </summary>
            public string code = "";

            /// <summary>
            /// 
            /// </summary>
            public string description = "";

            /// <summary>
            /// ConcurrencyID. See main docs, don't manipulate directly
            /// </summary>
            public int ConcurrencyID = 0;
        #endregion

        public int quantity = 0;
        public decimal unitPrice = 0;

            #region constructor
            /// <summary>
            /// Constructor. This object should only be instantiated by Customer, not used directly.
            /// </summary>
            public ProductsProps()
            {
            }

            #endregion

            #region BaseProps Members
            /// <summary>
            /// Serializes this props object to XML, and writes the key-value pairs to a string.
            /// </summary>
            /// <returns>String containing key-value pairs</returns>	
            public string GetState()
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType());
                StringWriter writer = new StringWriter();
                serializer.Serialize(writer, this);
                return writer.GetStringBuilder().ToString();
            }

            // I don't always want to generate xml in the db class so the 
            // props class can read in from xml
            public void SetState(DBDataReader dr)
            {
                this.ID = (Int32)dr["ProductID"];
                this.code = ((string)dr["ProductCode"]).Trim();
                this.description = (string)dr["Description"];
                this.unitPrice = (decimal)dr["UnitPrice"];
                this.quantity = (int)dr["OnHandQuantity"];
                this.ConcurrencyID = (int)dr["ConcurrencyID"];
            //this.userID = (Int32)dr["UserID"];
                //this.title = (string)dr["EventTitle"];
                //this.description = (string)dr["EventDescription"];
                //this.date = (DateTime)dr["EventDate"];
                //this.ConcurrencyID = (Int32)dr["ConcurrencyID"];
            }

            /// <summary>
            /// 
            /// </summary>
            public void SetState(string xml)
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType());
                StringReader reader = new StringReader(xml);
                ProductsProps p = (ProductsProps)serializer.Deserialize(reader);
                this.ID = p.ID;
                this.code = p.code;
                this.description = p.description;
                this.ConcurrencyID = p.ConcurrencyID;
                this.quantity = p.quantity;
                this.unitPrice = p.unitPrice;
           
            }
            #endregion

            #region ICloneable Members
            /// <summary>
            /// Clones this object.
            /// </summary>
            /// <returns>A clone of this object.</returns>
            public Object Clone()
            {
                ProductsProps p = new ProductsProps();
                p.ID = this.ID;
                p.code = this.code;
                p.description = this.description;
                p.ConcurrencyID = this.ConcurrencyID;
                p.quantity = this.quantity;
                p.unitPrice = this.unitPrice;

               
                return p;
            }

   
        #endregion

    }
    
}
