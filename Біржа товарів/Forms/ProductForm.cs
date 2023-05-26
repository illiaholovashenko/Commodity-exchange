using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Біржа_товарів.Models;

namespace Біржа_товарів.Forms
{
    public partial class ProductForm : Form
    {
        Customer? customer;

        Salesman? salesman;

        public ProductForm(User user, string rank)
        {
            InitializeComponent();

            if (rank == "Покупець")
            {
                customer = (Customer)user;
            }
            else
            {
                salesman = (Salesman)user;
            }
        }

        private void ReturnLabel_Click(object sender, EventArgs e)
        {
            if (customer != null)
            {
                this.Hide();
                MainForm mainForm = new MainForm(customer, customer.ClassName);
                mainForm.Show();
            }
            else
            {
                this.Hide();
                MainForm mainForm = new MainForm(salesman, salesman.ClassName);
                mainForm.Show();
            }
        }

        private void ProductForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
