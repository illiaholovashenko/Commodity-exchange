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
using static Біржа_товарів.Data.DataAccess;

namespace Біржа_товарів.Forms
{
    // Клас, що реалізує форму для перегляду історії купівель/продаж
    public partial class ArchiveForm : Form
    {
        User user;

        public ArchiveForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void ArchiveForm_Load(object sender, EventArgs e)
        {
            ArchiveLabel.Text = user is Salesman ? "Продані товари" : "Куплені товари";
            ArchiveList.HorizontalScrollbar = true;

            string ArchivePath = user is Salesman ? SaleArchive : PurchasesArchive;
            ArchivePath += user.Login + "Archive.txt";

            ArchiveList.DataSource = LoadArchive(ArchivePath);

            if (ArchiveList.Items.Count == 0)
            {
                ArchiveList.Items.Add(user is Salesman ?
                    "Ви не продали жодного товару" : "Ви не купили жодного товару");
            }
        }

        private void ReturnLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm(user);
            mainForm.Show();
        }

        private void ArchiveForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
