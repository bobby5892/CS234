﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Xml.Serialization;
using System.IO;
using ToolsCSharp;
using Lab6PropsClasses;
using DBDataReader = System.Data.SqlClient.SqlDataReader;

namespace Lab6PropsClasses
{
    [Serializable()]
    public class CustomersProps : IBaseProps
    {


        #region instance variables
        /// <summary>
        /// 
        /// </summary>
        public int ID = Int32.MinValue;

        public string name;

        /// <summary>
        /// ConcurrencyID. See main docs, don't manipulate directly
        /// </summary>
        public int ConcurrencyID = 0;
        #endregion
        public string address = "";
        public string city = "";
        public string state = "";
        public string zipCode = "";

        #region constructor
        /// <summary>
        /// Constructor. This object should only be instantiated by Customer, not used directly.
        /// </summary>
        public CustomersProps()
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
            this.ID = (Int32)dr["CustomerID"];
            this.name = (string)dr["Name"];
            this.address = (string)dr["Address"];
            this.city = (string)dr["City"];
            this.state = (string)dr["State"];
            this.zipCode = (string)dr["ZipCode"];
            this.ConcurrencyID = (int)dr["ConcurrencyID"];
        }

        /// <summary>
        /// 
        /// </summary>
        public void SetState(string xml)
        {
            XmlSerializer serializer = new XmlSerializer(this.GetType());
            StringReader reader = new StringReader(xml);
            CustomersProps p = (CustomersProps)serializer.Deserialize(reader);
            this.ID = p.ID;
            this.name = p.name;
            this.address = p.address;
            this.city = p.city;
            this.ConcurrencyID = p.ConcurrencyID;
            this.state = p.state;
            this.zipCode = p.zipCode;

        }
        #endregion

        #region ICloneable Members
        /// <summary>
        /// Clones this object.
        /// </summary>
        /// <returns>A clone of this object.</returns>
        public Object Clone()
        {
            CustomersProps p = new CustomersProps();
            p.ID = this.ID;
            p.name = this.name;
            p.address = this.address;
            p.ConcurrencyID = this.ConcurrencyID;
            p.city = this.city;
            p.state = this.state;
            p.zipCode = this.zipCode;


            return p;
        }


        #endregion

    }

}