using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Біржа_товарів.Forms;

namespace Біржа_товарів.Models
{
    public class Product
    {
        internal int Id { get; set; }
        public string? ProductName { get; set; }
        public int? ProductAmount { get; set; }
        public int? ProductPrice { get; set; }
        public string? PaymentForm { get; set; }
        public string? DeliveryCondition { get; set; }
        public string? Adress { get; set; }
        public string? Notes { get; set; }
        internal static int idCount = 0;

        public Product(string[] Productprop)
        {
            idCount++;
            Id = idCount;
            ProductName = Productprop[0];
            ProductPrice = Productprop[1] != "" ? int.Parse(Productprop[1]) : 0;
            ProductAmount = int.Parse(Productprop[2]);
            Adress = Productprop[3];
            PaymentForm = Productprop[4];
            DeliveryCondition = Productprop[5];
            Notes = Productprop[6];
        }

        public static LinkedList<Product> Search(LinkedList<Product> products,
            Dictionary<string, string> searchParameters)
        {
            LinkedList<Product> foundProducts = new LinkedList<Product>();

            foreach (Product product in products)
            {
                bool found = true;

                foreach (var item in searchParameters)
                {
                    string productPropertyName = item.Key;
                    string searchParameterValue = item.Value;

                    var prop = product.GetType().GetProperty(productPropertyName);
                    var value = prop?.GetValue(product);

                    if (prop != null && prop.Name == "ProductPrice" && value != null && value is IConvertible)
                    {
                        int actualValue = Convert.ToInt32(value);
                        int actualParameterValue = Convert.ToInt32(searchParameterValue);

                        if (actualParameterValue < actualValue)
                        {
                            found = false;
                            break;
                        }
                    }
                    else if (value != null && (value.ToString()?.Contains(searchParameterValue) != true))
                    { 
                        found = false;
                        break;
                    }
                }

                if (found)
                {
                    foundProducts.AddLast(product);
                }
            }

            return foundProducts;
        }

        public string GetInfo()
        {
            return $"Назва: {ProductName}, Ціна: {ProductPrice}, Кількість: {ProductAmount}, " +
                $"Адреса: {Adress}, Оплата: {PaymentForm}, " +
                $"Доставка: {DeliveryCondition}, Замітки: {Notes}";
        }
    }
}
