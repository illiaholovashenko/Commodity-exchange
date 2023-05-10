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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void FindProductButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchProductForm searchProductForm = new SearchProductForm();
            searchProductForm.Show();
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
