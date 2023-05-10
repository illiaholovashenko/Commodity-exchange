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
    public partial class PurchaseForm : Form
    {
        public PurchaseForm()
        {
            InitializeComponent();
        }

        private void PurchaseForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
