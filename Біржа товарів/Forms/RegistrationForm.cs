using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            bool IsSuccess = Validators.Validators.AreFieldsFilled(this);

            if (!IsSuccess)
            {
                MainError.Text = "Всі поля мають бути заповнені";
            }
            else
            {
                const string DataBasePath = @"C:\курсова\Біржа товарів\Біржа товарів\DataBase\";
                const string BuyersData = DataBasePath + "Buyers.txt";
                const string SellersData = DataBasePath + "Sellers.txt";

                bool isLoginAvailable = Validators.Validators.IsLoginAvailable(BuyersData, LoginField.Text)
                    || Validators.Validators.IsLoginAvailable(SellersData, LoginField.Text);
                bool isTelephoneAvailable = Validators.Validators.IsTelephoneAvailable(BuyersData, PhoneField.Text)
                    || Validators.Validators.IsTelephoneAvailable(SellersData, PhoneField.Text);

                if (isLoginAvailable && isTelephoneAvailable)
                {
                    Data.DataAccess.CreateDirectory(DataBasePath + LoginField.Text + "Products");
                    string UserData = $"Ім'я: {NameField.Text}, " +
                        $"Прізвище: {SurnameField.Text}, Телефон: {PhoneField.Text}, " +
                        $"Логін: {LoginField.Text}, Пароль: {PasswordField.Text}, " +
                        $"Товари: {DataBasePath + LoginField.Text}Products;";

                    if (SalesMan.Checked)
                    {
                        Data.DataAccess.WriteToDataBase(SellersData, UserData);
                    }
                    else
                    {
                        Data.DataAccess.WriteToDataBase(BuyersData, UserData);
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
            Validators.Validators.ValidateField(NameField,
                NameError, e, Validators.Validators.IsFieldValid);
        }

        private void NameField_Validated(object sender, EventArgs e)
        {
            NameError.Text = "";
        }

        private void SurnameField_Validating(object sender, CancelEventArgs e)
        {
            Validators.Validators.ValidateField(SurnameField,
                SurnameError, e, Validators.Validators.IsFieldValid);
        }

        private void SurnameField_Validated(object sender, EventArgs e)
        {
            SurnameError.Text = "";
        }

        private void PhoneField_Validating(object sender, CancelEventArgs e)
        {
            Validators.Validators.ValidateField(PhoneField,
                PhoneError, e, Validators.Validators.IsNumberValid);
        }

        private void PhoneField_Validated(object sender, EventArgs e)
        {
            PhoneError.Text = "";
        }

        private void LoginField_Validating(object sender, CancelEventArgs e)
        {
            Validators.Validators.ValidateField(LoginField,
                LoginError, e, Validators.Validators.IsLoginValid);
        }

        private void LoginField_Validated(object sender, EventArgs e)
        {
            LoginError.Text = "";
        }

        private void PasswordField_Validating(object sender, CancelEventArgs e)
        {
            Validators.Validators.ValidateField(PasswordField,
                PasswordError, e, Validators.Validators.IsPasswordValid);
        }

        private void PasswordField_Validated(object sender, EventArgs e)
        {
            PasswordError.Text = "";
        }
    }
}
