using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Біржа_товарів.Models
{
    internal class User
    {
        protected int id;

        protected string FullName;

        protected string Login;

        protected string Password;

        protected string telephone;

        protected List<Product> products;
    }
}
