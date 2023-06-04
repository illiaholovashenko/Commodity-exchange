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
using static Біржа_товарів.Utilities.Utilities;

namespace Біржа_товарів.Forms
{
    // Клас, що реалізує форму для перегляду знайдених товарів та обрання бажаного товару для покупки
    public partial class ProductSelectionForm : Form
    {
        User user;

        List<Product> foundProducts;
        public ProductSelectionForm(User user, List<Product> products)
        {
            InitializeComponent();
            this.user = user;
            foundProducts = products;
        }

        private void ProductSelectionForm_Load(object sender, EventArgs e)
        {
            PurchaseButton.Text = user is Salesman ? "Продати" : "Купити";

            if (foundProducts.Count == 0)
            {
                foundProductList.Items.Add("Таких товарів не знайдено");
                foundProductList.Enabled = false;
            }
            else
            {
                foundProductList.DataSource = foundProducts;
            }
        }

        private void ReturnLabel_Click(object sender, EventArgs e)
        {
            ConfirmOperation(this, user, "Ви підтверджуєте завершення цієї операції?");
        }

        private void PurchaseButton_Click(object sender, EventArgs e)
        {
            if (foundProductList.SelectedItem != null)
            {
                Product selectedProduct = (Product)foundProductList.SelectedItem;

                this.Hide();
                PurchaseForm purchaseForm = new PurchaseForm(user, 
                    selectedProduct, foundProducts);
                purchaseForm.Show();
            }
            else
            {
                PurchaseError.Text = "Оберіть товар для покупки";
            }
        }
    }
}
