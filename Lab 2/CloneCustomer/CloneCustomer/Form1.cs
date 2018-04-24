using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloneCustomer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Changed = new ChangeHandler(HandleChanged);
        }

        private Customer customer;
        // Valid for 15-1 - List <Customer> customers = new List<Customer>();
        // Updated for version 15-2
        // private List<Customer> customers;

        private CustomerList customers = new CustomerList();
        // Part of the 13-1 portion of the assignment
        public delegate void ChangeHandler(CustomerList customers);

        public event ChangeHandler Changed;

        public void HandleChanged(CustomerList customers)
        {
          
            lstCustomers.DataSource = customers.getCustomers();
           
        }
        private void Form1_Load(object sender, System.EventArgs e)
        {
            customer = new Customer("John", "Mendez", "jmendez@msysco.com");
            lblCustomer.Text = customer.GetDisplayText();
        }


        private void btnExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnClone_Click(object sender, EventArgs e)
        {
            //Check Copies Button - there and integer
            if (
                (Validator.IsPresent(txtCopies)) 
                && (Validator.IsInt32(txtCopies))
                ){
               
                
                int i;
                int.TryParse(txtCopies.Text,out i);
                do {
                    customers.Add((Customer)this.customer.Clone());
                   // customers.Add((Customer) this.customer.Clone());
                    i--;
                } while (i > 0);

                // Put it in the list 15-1
                //lstCustomers.DataSource = customers;

                //15-2
                Changed(customers);
                //lstCustomers.DataSource = customers.getCustomers();


               
                 
            }


        }

        private void lstCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}