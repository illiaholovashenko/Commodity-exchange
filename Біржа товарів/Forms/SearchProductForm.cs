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

namespace Біржа_товарів.Forms
{
    public partial class SearchProductForm : ProductForm
    {
        public SearchProductForm(User user, string rank):base(user, rank)
        {
            InitializeComponent();
        }
    }
}
