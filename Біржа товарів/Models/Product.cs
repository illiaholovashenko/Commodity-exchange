using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Біржа_товарів.Models
{
    internal class Product
    {
        internal int Id = 0;
        internal string Name { get; set; }
        internal int Amount { get; set; }
        internal int UnitPrice { get; set; }
        internal enum PaymentForm
        {

        }
        internal enum DeliveryCondition
        {
            
        }
        internal string Adress { get; set; }
        internal string Notes { get; set; }
        internal User Author { get; set; }

        public Product(string name, int amount, int price, string adress, string Notes)
        {
            Id++;

        }

    }
}
