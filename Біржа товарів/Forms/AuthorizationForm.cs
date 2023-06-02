using System.Security.AccessControl;
using Біржа_товарів.Forms;
using Біржа_товарів.Models;
using static Біржа_товарів.Utilities.Validators;
using static Біржа_товарів.Data.DataAccess;
using static Біржа_товарів.Utilities.Utilities;

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
            ChangeForm<RegistrationForm>(this);
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
            bool IsSuccess = FieldsFilled(this) == 2;

            if (!IsSuccess)
            {
                MainError.Text = "Всі поля мають бути заповнені";
            }
            else
            {
                MainError.Text = "";

                string? user;
                bool isSalesman = !IsAvailable(GetItemFromDatabase(SalesmenData, $"Логін: {LoginField.Text},"));
                bool isCustomer = !IsAvailable(GetItemFromDatabase(CustomersData, $"Логін: {LoginField.Text},"));
                
                if (isSalesman)
                {
                    user = GetItemFromDatabase(SalesmenData, $"Логін: {LoginField.Text},");

                    if (user.Contains($"Пароль: {PasswordField.Text},"))
                    {
                        Salesman salesman = new Salesman(GetData(user, 6));

                        this.Hide();
                        MainForm mainForm = new MainForm(salesman);
                        mainForm.Show();
                    }
                    else 
                    {
                        PasswordError.Text = "Пароль не правльний";
                    }
                }
                else if (isCustomer)
                {
                    user = GetItemFromDatabase(CustomersData, $"Логін: {LoginField.Text},");

                    if (user.Contains($"Пароль: {PasswordField.Text},"))
                    {
                        Customer customer = new Customer(GetData(user, 6));

                        this.Hide();
                        MainForm mainForm = new MainForm(customer);
                        mainForm.Show();
                    }
                    else
                    {
                        PasswordError.Text = "Пароль не правльний";
                    }
                }
                else
                {
                    LoginError.Text = "Логін не правильний";
                }
            }
        }

        private bool IsAvailable(string? field)
        {
            return field == null;
        }
    }
}