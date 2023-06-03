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
using static Біржа_товарів.Utilities.Validators;
using static Біржа_товарів.Data.DataAccess;

namespace Біржа_товарів.Forms
{
    public partial class AddProductForm : Form
    {
        User user;

        static int Id = 1;
        public AddProductForm(User user)
        {
            InitializeComponent();

            this.user = user;
        }

        private void AddProductForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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

        private void ProductNameField_Validating(object sender, CancelEventArgs e)
        {
            ValidateField(ProductNameField, ProductNameError, e, IsProductNameValid);
        }

        private void ProductNameField_Validated(object sender, EventArgs e)
        {
            ProductNameError.Text = "";
        }

        private void ProductPriceField_Validating(object sender, CancelEventArgs e)
        {
            ValidateField(ProductPriceField, ProductPriceError, e, IsProductPriceValid);
        }

        private void ProductPriceField_Validated(object sender, EventArgs e)
        {
            ProductPriceError.Text = "";
        }

        private void AdressField_Validating(object sender, CancelEventArgs e)
        {
            ValidateField(AdressField, AdressError, e, IsAdressValid);
        }

        private void AdressField_Validated(object sender, EventArgs e)
        {
            AdressError.Text = "";
        }

        private void ProductAmountField_Validating(object sender, CancelEventArgs e)
        {
            ValidateField(ProductAmountField, AmountError, e, IsProductPriceValid);
        }

        private void ProductAmountField_Validated(object sender, EventArgs e)
        {
            AmountError.Text = "";
        }

        private void NotesField_Validating(object sender, CancelEventArgs e)
        {
            ValidateField(NotesField, NotesError, e, IsProductNameValid);
        }

        private void NotesField_Validated(object sender, EventArgs e)
        {
            NotesError.Text = "";
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(ProductNameField.Text)
                || string.IsNullOrWhiteSpace(ProductAmountField.Text)))
            {
                string ProductData = $"Id: {Id}; Назва: {ProductNameField.Text}; " +
                    $"Ціна: {ProductPriceField.Text}; Кількість: {ProductAmountField.Text}; " +
                    $"Адреса: {AdressField.Text}; Оплата: {PaymentFormBox.Text}; " +
                    $"Доставка: {DeliveryConditionBox.Text}; Замітки: {NotesField.Text}; " +
                    $"Власник: {user.Login}";

                WriteToDataBase(user.ProductsPath, ProductData);

                MessageBox.Show("Ви успішно додали товар!");

                this.Hide();
                MainForm mainForm = new MainForm(user);
                mainForm.Show();
            }
            else
            {
                MainError.Text = "Поля для назви та кількісті товарів мають бути заповнені";
            }
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {
            if (GetItemById(CustomerAddedProducts, $"Id: {Id};") != null
                || GetItemById(SalesmenAddedProducts, $"Id: {Id};") != null)
            {
                Id++;
                AddProductForm_Load(sender, e);
            }
        }
    }
}
