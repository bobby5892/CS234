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
    public class Products : BaseBusiness
    {

        public int ID
        {
            get
            {
                return ((ProductsProps)mProps).ID;
            }
        }

        /// <summary>
        /// Read/Write property. 
        /// </summary>
        /// 

        public string code
        {
            get
            {
                return ((ProductsProps)mProps).code;
            }

            set
            {
                if (!(value == ((ProductsProps)mProps).code))
                {
                    value = value.Trim();
                    if ( 
                        (value.Length > 0 ) && 
                        (value.Length < 11 ) 
                       )
                    {
                        mRules.RuleBroken("Code", false);
                        ((ProductsProps)mProps).code = value;
                        mIsDirty = true;
                    }

                    else
                    {
                        throw new ArgumentOutOfRangeException("code must be between 1 and 10 chars in length");
                    }
                }
            }
        }
        public string description
        {
            get
            {
                return ((ProductsProps)mProps).description;
            }

            set
            {
                if (!(value == ((ProductsProps)mProps).description))
                {
                    value = value.Trim();
                    if (
                        (value.Length > 0) &&
                        (value.Length < 51)
                       )
                    {
                        mRules.RuleBroken("Description", false);
                        ((ProductsProps)mProps).description = value;
                        mIsDirty = true;
                    }

                    else
                    {
                        throw new ArgumentOutOfRangeException("description must be between 1 and 50 chars in length");
                    }
                }
            }
        }
        public decimal unitPrice
        {
            get
            {
                return ((ProductsProps)mProps).unitPrice;
            }

            set
            {
                if (!(value == ((ProductsProps)mProps).unitPrice))
                {

                    if (value > -1)
                    {
                        ((ProductsProps)mProps).unitPrice = value;
                        mIsDirty = true;
                    }

                    else
                    {
                        throw new ArgumentOutOfRangeException("Price must be greater than or equal to 0");
                    }
                }
            }
        }
        public int quantity
        {
            get
            {
                return ((ProductsProps)mProps).quantity;
            }

            set
            {
                if (!(value == ((ProductsProps)mProps).quantity))
                {
                   
                    if(value > -1)
                    {
                        ((ProductsProps)mProps).quantity = value;
                        mIsDirty = true;
                    }

                    else
                    {
                        throw new ArgumentOutOfRangeException("Quantity must be greater than 0");
                    }
                }
            }
        }
        public Products()
        {
        }

        public Products(string cnString) : base(cnString)
        {
        }

        public Products(object key) : base(key)
        {
        }

        public Products(IBaseProps props) : base(props)
        {
        }

        public Products(object key, string cnString) : base(key, cnString)
        {
        }

        public Products(IBaseProps props, string cnString) : base(props, cnString)
        {
        }

        public override object GetList()
        {
            List<Products> events = new List<Products>();
            List<ProductsProps> props = new List<ProductsProps>();


            props = (List<ProductsProps>)mdbReadable.RetrieveAll(props.GetType());
            foreach (ProductsProps prop in props)
            {
                Products e = new Products(prop, this.mConnectionString);
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
            mRules.RuleBroken("Code", true);
            mRules.RuleBroken("Description", true);
        }

        protected override void SetUp()
        {
            mProps = new ProductsProps();
            mOldProps = new ProductsProps();

            if (this.mConnectionString == "")
            {
                mdbReadable = new ProductsDB();
                mdbWriteable = new ProductsDB();
            }

            else
            {
                mdbReadable = new ProductsDB(this.mConnectionString);
                mdbWriteable = new ProductsDB(this.mConnectionString);
            }
        }
    }
}
