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
    public partial class ProductSelectionForm : Form
    {
        User user;

        LinkedList<Product> foundProducts;
        public ProductSelectionForm(User user, LinkedList<Product> products)
        {
            InitializeComponent();
            this.user = user;
            foundProducts = products;
        }

        private void ProductSelectionForm_Load(object sender, EventArgs e)
        {
            if (foundProducts == null)
            {
                foundProductList.Text = "Таких товарів не знайдено";
            }
            else
            {
                foreach (Product product in foundProducts)
                {
                    foundProductList.Items.Add(product.GetInfo());
                }
            }
        }

        private void ReturnLabel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ви точно хочете припинити операцію?", "Підтвердіть припинення операції", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                MainForm mainForm = new MainForm(user);
                mainForm.Show();
            }
        }
    }
}
