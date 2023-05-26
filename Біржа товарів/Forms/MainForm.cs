
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
    public partial class MainForm : Form
    {
        Customer customer;

        Salesman salesman;

        public MainForm(User user, string rank)
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

        private void FindProductButton_Click(object sender, EventArgs e)
        {
            if (customer != null)
            {
                this.Hide();
                SearchProductForm searchProductForm = new SearchProductForm(customer, customer.ClassName);
                searchProductForm.Show();
            }
            else
            {
                this.Hide();
                SearchProductForm searchProductForm = new SearchProductForm(salesman, salesman.ClassName);
                searchProductForm.Show();
            }
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            if (customer != null)
            {
                this.Hide();
                AddProductForm addProductForm = new AddProductForm(customer, customer.ClassName);
                addProductForm.Show();
            }
            else
            {
                this.Hide();
                AddProductForm addProductForm = new AddProductForm(salesman, salesman.ClassName);
                addProductForm.Show();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (customer != null)
            {
                RankText.Text = customer.ClassName;
                MeetingLabel.Text = $"Привіт, {customer.FullName}!";
            }
            else
            {
                RankText.Text = salesman.ClassName;
                MeetingLabel.Text = $"Привіт, {salesman.FullName}!";
            }
        }
    }
}
