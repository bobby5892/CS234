using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab6PropsClasses;
using ToolsCSharp;
using Lab6DBClasses;
using ProductDB = Lab6DBClasses.ProductsDB;

// *** I added this
using System.Data;

namespace lab6classes
{
    public class Customers : BaseBusiness
    {

        public int ID
        {
            get
            {
                return ((CustomersProps)mProps).ID;
            }
        }

        /// <summary>
        /// Read/Write property. 
        /// </summary>
        /// 

        public string name
        {
            get
            {
                return ((CustomersProps)mProps).name;
            }

            set
            {
                if (!(value == ((CustomersProps)mProps).name))
                {
                    value = value.Trim();
                    if (
                        (value.Length > 0) &&
                        (value.Length < 101)
                       )
                    {
                        mRules.RuleBroken("Name", false);
                        ((CustomersProps)mProps).name = value;
                        mIsDirty = true;
                    }

                    else
                    {
                        throw new ArgumentOutOfRangeException("name must be between 1 and 100 chars in length");
                    }
                }
            }
        }
        public string address
        {
            get
            {
                return ((CustomersProps)mProps).address;
            }

            set
            {
                if (!(value == ((CustomersProps)mProps).address))
                {
                    value = value.Trim();
                    if (
                        (value.Length > 0) &&
                        (value.Length < 51)
                       )
                    {
                        mRules.RuleBroken("Address", false);
                        ((CustomersProps)mProps).address = value;
                        mIsDirty = true;
                    }

                    else
                    {
                        throw new ArgumentOutOfRangeException("address must be between 1 and 50 chars in length");
                    }
                }
            }
        }
        public string city
        {
            get
            {
                return ((CustomersProps)mProps).city;
            }

            set
            {
                if (!(value == ((CustomersProps)mProps).city))
                {
                    value = value.Trim();
                    if (
                        (value.Length > 0) &&
                        (value.Length < 21)
                       )
                    {
                        mRules.RuleBroken("City", false);
                        ((CustomersProps)mProps).city = value;
                        mIsDirty = true;
                    }

                    else
                    {
                        throw new ArgumentOutOfRangeException("city must be between 1 and 20 chars in length");
                    }
                }
            }
        }
        public string state
        {
            get
            {
                return ((CustomersProps)mProps).state;
            }

            set
            {
                if (!(value == ((CustomersProps)mProps).state))
                {
                    value = value.Trim();
                    if (
                        (value.Length > 0) &&
                        (value.Length < 3)
                       )
                    {
                        mRules.RuleBroken("State", false);
                        ((CustomersProps)mProps).state = value;
                        mIsDirty = true;
                    }

                    else
                    {
                        throw new ArgumentOutOfRangeException("state must be  2 chars in length");
                    }
                }
            }
        }
        public Customers()
        {
        }

        public Customers(string cnString) : base(cnString)
        {
        }

        public Customers(object key) : base(key)
        {
        }

        public Customers(IBaseProps props) : base(props)
        {
        }

        public Customers(object key, string cnString) : base(key, cnString)
        {
        }

        public Customers(IBaseProps props, string cnString) : base(props, cnString)
        {
        }

        public override object GetList()
        {
            List<Customers> events = new List<Customers>();
            List<CustomersProps> props = new List<CustomersProps>();


            props = (List<CustomersProps>)mdbReadable.RetrieveAll(props.GetType());
            foreach (CustomersProps prop in props)
            {
                Customers e = new Customers(prop, this.mConnectionString);
                events.Add(e);
            }

            return events;
        }

        protected override void SetDefaultProperties()
        {
            throw new NotImplementedException();
        }

        protected override void SetRequiredRules()
        {
            mRules.RuleBroken("Name", true);
            mRules.RuleBroken("Address", true);
            mRules.RuleBroken("City", true);
            mRules.RuleBroken("State", true);
        }

        protected override void SetUp()
        {
            mProps = new CustomersProps();
            mOldProps = new CustomersProps();

            if (this.mConnectionString == "")
            {
                mdbReadable = new CustomersDB();
                mdbWriteable = new CustomersDB();
            }

            else
            {
                mdbReadable = new CustomersDB(this.mConnectionString);
                mdbWriteable = new CustomersDB(this.mConnectionString);
            }
        }
    }
}
