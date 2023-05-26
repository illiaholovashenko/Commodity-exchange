using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Біржа_товарів.Forms;

namespace Біржа_товарів.Models
{
    public class User
    {
        public string ClassName;

        public string FullName { get; set; } = " ";

        protected string Login;

        protected string Password;

        protected string Telephone;

        protected string ProductsPath;

        public User(string[] data) 
        {
            FullName = data[0];
            Telephone = data[1];
            Login = data[2];
            Password = data[3];
            ProductsPath = data[4];
        }

        public virtual void SetMeetingText(MainForm mainForm)
        {
            mainForm.RankText.Text = ClassName;
            mainForm.MeetingLabel.Text = $"Привіт, {FullName}!";
        }
    }
}
