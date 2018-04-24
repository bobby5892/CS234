using System;
using System.Collections;
using System.Collections.Generic;

namespace CloneCustomer
{
    public class CustomerList : IEnumerator<Customer>
    {
        /// <summary>
        /// Constructor - sets the currentCustomer to 0
        /// </summary>
        public CustomerList()
        {
            // Part of Event Handler
            Changed = new ChangeHandler(HandleChanged);
            // Starts at 0
            this.currentCustomer = 0;
        }
        private List<Customer> customers = new List<Customer>();
        /// <summary>
        /// Return a Count of the number of entres in customers
        /// </summary>
		public int Count => customers.Count;
        /// <summary>
        /// Grab the current Customer at the Index Point
        /// </summary>
        public Customer Current => this.customers[this.currentCustomer];
        /// <summary>
        /// Grab the current Customer at the Index Point
        /// </summary>
        object IEnumerator.Current => this.customers[this.currentCustomer];
        public Customer this[int i] => customers[i];
        public delegate void ChangeHandler(CustomerList customerList);

        public event ChangeHandler Changed;

        public void HandleChanged(CustomerList customerList) {
            // Is not supposed to do anything - its just so one event is bound already - so we dont have to
            // check if we're already bound, or deal with other things that may be bound. - In the future tho that
            // would probably be better etiquette. 
        }
        public void Add(Customer customer)
        {
            customers.Add(customer);
            Changed(this);
        }

        public List<Customer> getCustomers() {
            return this.customers;
        }

        /// <summary>
        ///  Garbage collection
        /// </summary>
     
        public void Dispose(){
        }
        /// <summary>
        /// Iterate to the next position in the list if available
        /// </summary>
        /// <returns></returns>
        public bool MoveNext()
        {
            if(this.Count < this.currentCustomer + 1)
            {
                this.currentCustomer++;
                return true;
            }
            return false;
        }
        /// <summary>
        /// Reset the Index to 0
        /// </summary>
        public void Reset()
        {
            // Reset Index to Beginning
            this.currentCustomer = 0;
        }
        private int currentCustomer;
    }
}
