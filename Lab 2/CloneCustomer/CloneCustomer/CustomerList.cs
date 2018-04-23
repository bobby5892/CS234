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

        public void Add(Customer customer) => customers.Add(customer);

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
