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
using static Біржа_товарів.Validators.Validators;

namespace Біржа_товарів.Forms
{
    public partial class SearchProductForm : Form
    {
        User user;

        public SearchProductForm(User user)
        {
            InitializeComponent();

            this.user = user;
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
            ValidateField(ProductPriceField, ProductPriceError, e, IsProductPriceValid);
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
    }
}
