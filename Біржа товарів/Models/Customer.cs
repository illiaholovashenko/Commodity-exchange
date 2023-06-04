using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Біржа_товарів.Forms;

namespace Біржа_товарів.Models
{
    // Клас покупця, успадковується від користувача
    internal class Customer: User
    {
        public override string ClassName
        {
            get
            {
                return "Покупець";
            }
        }

        public Customer(string[] data): base(data) { }
    }
}
