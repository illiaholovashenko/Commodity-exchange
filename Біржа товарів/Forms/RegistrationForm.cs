using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Біржа_товарів.Validators.Validators;
using static Біржа_товарів.Data.DataAccess;

namespace Біржа_товарів.Forms
{
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

        private void ToAuthorizationFormLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            AuthorizationForm authorizationForm = new AuthorizationForm();
            authorizationForm.Show();
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            bool IsSuccess = AreFieldsFilled(this);

            if (!IsSuccess)
            {
                MainError.Text = "Всі поля мають бути заповнені";
            }
            else
            {
                bool isLoginAvailable = IsLoginAvailable(BuyersData, LoginField.Text)
                    && IsLoginAvailable(SellersData, LoginField.Text);
                bool isTelephoneAvailable = IsTelephoneAvailable(BuyersData, PhoneField.Text)
                    && IsTelephoneAvailable(SellersData, PhoneField.Text);

                if (isLoginAvailable && isTelephoneAvailable)
                {
                    CreateDirectory(DataBasePath + LoginField.Text + "Products");
                    string UserData = $"Ім'я: {NameField.Text}, " +
                        $"Прізвище: {SurnameField.Text}, Телефон: {PhoneField.Text}, " +
                        $"Логін: {LoginField.Text}, Пароль: {PasswordField.Text}, " +
                        $"Товари: {DataBasePath + LoginField.Text}Products;";

                    if (SalesMan.Checked)
                    {
                        WriteToDataBase(SellersData, UserData);
                    }
                    else
                    {
                        WriteToDataBase(BuyersData, UserData);
                    }

                    this.Hide();
                    AuthorizationForm authorizationForm = new AuthorizationForm();
                    authorizationForm.Show();
                }
                else if (!isTelephoneAvailable)
                {
                    PhoneError.Text = "Такий номер телефону вже зареєстроовано";
                }
                else if (!isLoginAvailable)
                {
                    LoginError.Text = "Такий Логін вже зареєстроовано";
                }
                else
                {
                    PhoneError.Text = "Такий номер телефону вже зареєстроовано";
                    LoginError.Text = "Такий Логін вже зареєстроовано";
                }
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
        }

        private void PhoneField_Validated(object sender, EventArgs e)
        {
            PhoneError.Text = "";
        }

        private void LoginField_Validating(object sender, CancelEventArgs e)
        {
            ValidateField(LoginField, LoginError, e, IsLoginValid);
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
