using Біржа_товарів.Forms;

namespace Біржа_товарів
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ToRegisterWindow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegistrationForm RegistrationForm = new RegistrationForm();
            RegistrationForm.Show();
        }
    }
}