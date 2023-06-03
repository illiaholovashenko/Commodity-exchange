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
        public string? OwnerLogin { get; set; }

        public Product(string[] Productprop)
        {
            Id = int.Parse(Productprop[0]);
            ProductName = Productprop[1];
            ProductPrice = Productprop[2] != "" ? int.Parse(Productprop[2]) : 0;
            ProductAmount = int.Parse(Productprop[3]);
            Adress = Productprop[4];
            PaymentForm = Productprop[5];
            DeliveryCondition = Productprop[6];
            Notes = Productprop[7];
            OwnerLogin = Productprop[8];
        }

        public static List<Product> Search(LinkedList<Product> products,
            Dictionary<string, string> searchParameters)
        {
            List<Product> foundProducts = new List<Product>();

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
                    else if (value != null && (value.ToString().ToLower()?.Contains(searchParameterValue.ToLower()) != true))
                    { 
                        found = false;
                        break;
                    }
                }

                if (found)
                {
                    foundProducts.Add(product);
                }
            }

            return foundProducts;
        }

        public override string ToString()
        {
            return GetInfo();
        }

        public string GetInfo()
        {
            return $"Назва: {ProductName}; Ціна: {ProductPrice} грн; Кількість: {ProductAmount}";
        }
    }
}
