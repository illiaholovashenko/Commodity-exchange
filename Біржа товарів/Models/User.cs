using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Біржа_товарів.Forms;

namespace Біржа_товарів.Models
{
    public abstract class User
    {
        public abstract string ClassName { get; }

        public string FullName { get; set; } = " ";

        protected string Login;

        protected string Password;

        protected string Telephone;

        public string ProductsPath;

        public List<Product> products = new List<Product>();

        public User(string[] data) 
        {
            FullName = data[0] + " " + data[1];
            Telephone = data[2];
            Login = data[3];
            Password = data[4];
            ProductsPath = data[5];
        }

        public virtual void SetMeetingText(MainForm mainForm)
        {
            mainForm.RankText.Text = ClassName;
            mainForm.MeetingLabel.Text = $"Привіт, {FullName}!";
        }
    }
}
