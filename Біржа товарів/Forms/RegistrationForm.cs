﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Біржа_товарів.Utilities.Validators;
using static Біржа_товарів.Data.DataAccess;
using static Біржа_товарів.Utilities.Utilities;

namespace Біржа_товарів.Forms
{
    // Клас, що реалізує форму для реєстрації користувача як продавця або покупця
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ToAuthorizationFormLink_LinkClicked(object sender,
            LinkLabelLinkClickedEventArgs e)
        {
            ChangeForm<AuthorizationForm>(this);
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            bool IsSuccess = FieldsFilled(this) == 5;

            if (!IsSuccess)
            {
                MainError.Text = "Всі поля мають бути заповнені";
            }
            else
            {
                MainError.Text = "";

                string UserData = $"Ім'я: {NameField.Text}; " +
                    $"Прізвище: {SurnameField.Text}; Телефон: {PhoneField.Text}; " +
                    $"Логін: {LoginField.Text}; Пароль: {PasswordField.Text}; ";

                if (SalesMan.Checked)
                {
                    UserData += $"Товари: {SalesmenAddedProducts + LoginField.Text}Products.txt; " +
                        $"Архів: {SaleArchive + LoginField.Text}Archive.txt";
                    WriteToDataBase(SalesmenData, UserData);
                }
                else
                {
                    UserData += $"Товари: {CustomerAddedProducts + LoginField.Text}Products.txt; " +
                        $"Архів: {PurchasesArchive + LoginField.Text}Archive.txt";
                    WriteToDataBase(CustomersData, UserData);
                }
                ChangeForm<AuthorizationForm>(this);
            }
        }

        private void NameField_Validating(object sender, CancelEventArgs e)
        {
            ValidateField(NameField, NameError, e, IsFieldValid);
        }

        private void NameField_Validated(object sender, EventArgs e)
        {
            NameError.Text = "";
        }

        private void SurnameField_Validating(object sender, CancelEventArgs e)
        {
            ValidateField(SurnameField, SurnameError, e, IsFieldValid);
        }

        private void SurnameField_Validated(object sender, EventArgs e)
        {
            SurnameError.Text = "";
        }

        private void PhoneField_Validating(object sender, CancelEventArgs e)
        {
            ValidateField(PhoneField, PhoneError, e, IsNumberValid);
            AvailabilityCheck(PhoneField, PhoneError, "Телефон", e, IsAvailable);
        }

        private void PhoneField_Validated(object sender, EventArgs e)
        {
            PhoneError.Text = "";
        }

        private void LoginField_Validating(object sender, CancelEventArgs e)
        {
            ValidateField(LoginField, LoginError, e, IsLoginValid);
            AvailabilityCheck(LoginField, LoginError, "Логін", e, IsAvailable);
        }

        private void LoginField_Validated(object sender, EventArgs e)
        {
            LoginError.Text = "";
        }

        private void PasswordField_Validating(object sender, CancelEventArgs e)
        {
            ValidateField(PasswordField, PasswordError, e, IsPasswordValid);
        }

        private void PasswordField_Validated(object sender, EventArgs e)
        {
            PasswordError.Text = "";
        }
    }
}
