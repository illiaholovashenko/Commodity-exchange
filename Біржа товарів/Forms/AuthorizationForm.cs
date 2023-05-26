using System.Security.AccessControl;
using Біржа_товарів.Forms;
using Біржа_товарів.Models;
using static Біржа_товарів.Validators.Validators;
using static Біржа_товарів.Data.DataAccess;

namespace Біржа_товарів
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void ToRegisterWindow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegistrationForm RegistrationForm = new RegistrationForm();
            RegistrationForm.Show();
        }

        private void AuthorizationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void LoginField_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateField(LoginField, LoginError, e, IsLoginValid);
        }

        private void LoginField_Validated(object sender, EventArgs e)
        {
            LoginError.Text = "";
        }

        private void PasswordField_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateField(PasswordField, PasswordError, e, IsPasswordValid);
        }

        private void PasswordField_Validated(object sender, EventArgs e)
        {
            PasswordError.Text = "";
        }

        private void AuthorizationButton_Click(object sender, EventArgs e)
        {
            bool IsSuccess = AreFieldsFilled(this);

            if (!IsSuccess)
            {
                MainError.Text = "Всі поля мають бути заповнені";
            }
            else
            {
                string? user;
                bool isSalesman = !IsLoginAvailable(SellersData, LoginField.Text);
                bool isCustomer = !IsLoginAvailable(BuyersData, LoginField.Text);
                if (isSalesman)
                {
                    if ((user = IsPasswordCorrect(SellersData,
                        LoginField.Text, PasswordField.Text)) == null)
                    {
                        PasswordError.Text = "Пароль не правльний";
                    }
                    else 
                    {
                        Salesman salesman = new Salesman(UserLogIn(user));

                        this.Hide();
                        MainForm mainForm = new MainForm(salesman, "Продавець");
                        mainForm.Show();
                    }
                }
                else if (isCustomer)
                {
                    if ((user = IsPasswordCorrect(BuyersData,
                        LoginField.Text, PasswordField.Text)) == null)
                    {
                        PasswordError.Text = "Пароль не правльний";
                    }
                    else
                    {
                        Customer customer = new Customer(UserLogIn(user));

                        this.Hide();
                        MainForm mainForm = new MainForm(customer, "Покупець");
                        mainForm.Show();
                    }
                }
                else
                {
                    LoginError.Text = "Не правильний логін";
                }
            }
        }

        private string[] UserLogIn(string UserData)
        {
            string[] userData = new string[5];

            string[] DataPairs = UserData.Split(", ");

            userData[0] = DataPairs[0].Split(": ")[1]+ " ";

            for (int i = 0; i < DataPairs.Length - 1; i++)
            {
                userData[i] += DataPairs[i+1].Split(": ")[1];
            }

            return userData;
        }
    }
}