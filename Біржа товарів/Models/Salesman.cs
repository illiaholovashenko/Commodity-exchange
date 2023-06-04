using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Біржа_товарів.Forms;

namespace Біржа_товарів.Models
{
    // Клас продавця, успадковується від користувача
    internal class Salesman: User
    {
        public override string ClassName 
        {
            get
            {
                return "Продавець";
            }
        }

        public Salesman(string[] data):base(data) { }
    }
}
