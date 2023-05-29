
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
    public partial class MainForm : Form
    {
        internal User user;

        public MainForm(User user)
        {
            InitializeComponent();

            this.user = user;
        }

        private void FindProductButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchProductForm searchProductForm = new SearchProductForm(user);
            searchProductForm.Show();
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddProductForm addProductForm = new AddProductForm(user);
            addProductForm.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RankText.Text = user.ClassName;
            MeetingLabel.Text = $"Привіт, {user.FullName}!";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ви точно хочете вийти?", "Підтвердіть вихід", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                ChangeForm<AuthorizationForm>(this);
            }
        }
    }
}
