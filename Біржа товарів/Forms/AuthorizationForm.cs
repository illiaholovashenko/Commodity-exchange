using Біржа_товарів.Forms;
using Біржа_товарів.Models;

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
            Validators.Validators.ValidateField(LoginField,
                LoginError, e, Validators.Validators.IsLoginValid);
        }

        private void LoginField_Validated(object sender, EventArgs e)
        {
            LoginError.Text = "";
        }

        private void PasswordField_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Validators.Validators.ValidateField(PasswordField,
                PasswordError, e, Validators.Validators.IsPasswordValid);
        }

        private void PasswordField_Validated(object sender, EventArgs e)
        {
            PasswordError.Text = "";
        }

        private void AuthorizationButton_Click(object sender, EventArgs e)
        {
            bool IsSuccess = Validators.Validators.AreFieldsFilled(this);

            if (!IsSuccess)
            {
                MainError.Text = "Всі поля мають бути заповнені";
            }
            else
            {
                //string UserData = $"Логін: {LoginField.Text}, Пароль: {PasswordField.Text};";
                //const string BuyersData = @"C:\курсова\Біржа товарів\Біржа товарів\Data\Buyers.txt";
                //const string SellersData = @"C:\курсова\Біржа товарів\Біржа товарів\Data\Sellers.txt";

                //if (SalesMan.Checked)
                //{
                //    Data.DataAccess.WriteToDataBase(SellersData, UserData);
                //}
                //else
                //{
                //    Data.DataAccess.WriteToDataBase(BuyersData, UserData);
                //}

                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Show();
            }
        }
    }
}