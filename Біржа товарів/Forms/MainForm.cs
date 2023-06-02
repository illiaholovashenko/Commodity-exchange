
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
using static Біржа_товарів.Models.Product;
using static Біржа_товарів.Data.DataAccess;
using static Біржа_товарів.Utilities.Utilities;

namespace Біржа_товарів.Forms
{
    public partial class MainForm : Form
    {
        internal User user;

        internal LinkedList<Product>? CustomersWishes;
        internal LinkedList<Product>? SalesmenProducts;

        public MainForm(User user)
        {
            InitializeComponent();

            this.user = user;
        }

        private void FindProductButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchProductForm searchProductForm = new SearchProductForm(user, CustomersWishes, SalesmenProducts);
            searchProductForm.Show();
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddProductForm addProductForm = new AddProductForm(user);
            addProductForm.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RankText.Text = user.ClassName;
            MeetingLabel.Text = $"Привіт, {user.FullName}!";

            SalesmenProducts = null;
            CustomersWishes = null;
            idCount = 0;

            SalesmenProducts = LoadData(SalesmenAddedProducts);
            CustomersWishes = LoadData(CustomerAddedProducts);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ви точно хочете вийти?", "Підтвердіть вихід", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                ChangeForm<AuthorizationForm>(this);
            }
        }
    }
}
