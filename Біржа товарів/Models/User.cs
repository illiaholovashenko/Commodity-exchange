using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Біржа_товарів.Forms;

namespace Біржа_товарів.Models
{
    // Абстрактний клас реалізує поля та конструктор
    // для продавців та покупців
    public abstract class User
    {
        public string FullName;

        public string ProductsPath;

        public string Archive;

        public string Login;

        protected string Password;

        protected string Telephone;


        public User(string[] data) 
        {
            FullName = data[0] + " " + data[1];
            Telephone = data[2];
            Login = data[3];
            Password = data[4];
            ProductsPath = data[5];
            Archive = data[6];
        }

        public abstract string ClassName { get; }
    }
}
