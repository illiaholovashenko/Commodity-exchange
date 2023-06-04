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
using static Біржа_товарів.Utilities.Utilities;
using static Біржа_товарів.Models.Product;
using System.Security.AccessControl;

namespace Біржа_товарів.Forms
{
    // Клас, що реалізує форму для пошуку товару продавцем або покупцем
    public partial class SearchProductForm : Form
    {
        User user;

        internal LinkedList<Product>? CustomersWishes;
        internal LinkedList<Product>? SalesmenProducts;

        public SearchProductForm(User user, LinkedList<Product> wishes, 
            LinkedList<Product> products)
        {
            InitializeComponent();

            this.user = user;
            CustomersWishes = wishes;
            SalesmenProducts = products;
        }

        private void ReturnLabel_Click(object sender, EventArgs e)
        {
            ConfirmOperation(this, user, 
                "Ви підтверджуєте завершення цієї операції?");
        }

        private void SearchProductForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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
            ValidateField(ProductPriceField, 
                ProductPriceError, e, IsProductPriceValid);
        }

        private void ProductPriceField_Validated(object sender, EventArgs e)
        {
            ProductPriceError.Text = "";
        }

        private void NotesField_Validating(object sender, CancelEventArgs e)
        {
            ValidateField(NotesField, NotesError, e, IsProductNameValid);
        }

        private void NotesField_Validated(object sender, EventArgs e)
        {
            NotesError.Text = "";
        }

        private void AdressField_Validating(object sender, CancelEventArgs e)
        {
            ValidateField(AdressField, AdressError, e, IsAdressValid);
        }

        private void AdressField_Validated(object sender, EventArgs e)
        {
            AdressError.Text = "";
        }

        private void SearchProductButton_Click(object sender, EventArgs e)
        {
            bool IsSuccess = FieldsFilled(this) >= 1;

            if (IsSuccess)
            {
                MainError.Text = "";

                Dictionary<string, string> searchParameters = GetFilledFields(this);
                List<Product> products;

                products = user is Salesman ? Search(CustomersWishes,
                    searchParameters) : Search(SalesmenProducts, searchParameters);

                this.Hide();
                ProductSelectionForm selectionForm = new ProductSelectionForm(user, products);
                selectionForm.Show();
            }
            else
            {
                MainError.Text = "Для пошуку має бути заповнено хоча б одне поле";
            }
        }
    }
}
