﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Біржа_товарів.Models;
using System.Text.RegularExpressions;
using static Біржа_товарів.Data.DataAccess;

namespace Біржа_товарів.Forms
{
    // Клас, що реалізує форму для купівлі-продажу товару
    public partial class PurchaseForm : Form
    {
        User user;

        List<Product> foundedProducts;
        Product SelectedProduct;

        public PurchaseForm(User user,
            Product selectedProduct, List<Product> foundedProducts)
        {
            InitializeComponent();
            this.user = user;
            SelectedProduct = selectedProduct;
            this.foundedProducts = foundedProducts;
        }

        private void PurchaseForm_FormClosing(object sender,
            FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void PurchaseForm_Load(object sender, EventArgs e)
        {
            PurchaseFormLabel.Text = user is Salesman ? "Продаж товару" : "Покупка товару";
            ProductNameField.Text = SelectedProduct.ProductName;
            TotalPrice.Text = (Amount.Value * SelectedProduct.ProductPrice).ToString() + " грн";
            BuyButton.Text = user is Salesman ? "Продати" : "Купити";
        }

        private void Amount_ValueChanged(object sender, EventArgs e)
        {
            TotalPrice.Text = (Amount.Value * SelectedProduct.ProductPrice).ToString() + " грн";
        }

        private void ReturnLabel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ви точно хочете припинити операцію?",
                "Підтвердіть припинення операції", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                ProductSelectionForm selectionForm = new ProductSelectionForm(user,
                    foundedProducts);
                selectionForm.Show();
            }
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            string PurchaseData = $"Назва: {ProductNameField.Text}; " +
                $"Кількість: {Amount.Value}; Ціна: {TotalPrice.Text}; " +
                $"Дата та час укладення угоди: {DateTime.Now.ToString("dd/MM/yy HH:mm:ss")}";

            string? line = GetItemById(user is Salesman ?
                CustomerAddedProducts : SalesmenAddedProducts, $"Id: {SelectedProduct.Id};");

            if (Amount.Value > 0 && Amount.Value <= SelectedProduct.ProductAmount)
            {
                WriteToDataBase(user.Archive, PurchaseData);

                string? owner = GetItemFromDatabase(user is Salesman ?
                    CustomersData : SalesmenData, $"Логін: {SelectedProduct.OwnerLogin};");

                string ownerArchivePath = owner is not null ? owner.Split("Архів: ")[1] : "";

                WriteToDataBase(ownerArchivePath, PurchaseData);

                if (Amount.Value == SelectedProduct.ProductAmount)
                {
                    ChangeLineInDataBase(user is Salesman ?
                        CustomerAddedProducts : SalesmenAddedProducts, null, null, line);
                }
                else
                {
                    string newValue = $"Кількість: {SelectedProduct.ProductAmount - Amount.Value}";

                    string newLine = line is not null ? Regex.Replace(line, @"Кількість:\s+\d+", newValue) : "";

                    ChangeLineInDataBase(user is Salesman ?
                        CustomerAddedProducts : SalesmenAddedProducts, line, newLine, null);
                }

                this.Hide();
                MainForm mainForm = new MainForm(user);
                mainForm.Show();
            }
            else
            {
                AmountError.Text = "Недоступна кількість";
            }
        }
    }
}
