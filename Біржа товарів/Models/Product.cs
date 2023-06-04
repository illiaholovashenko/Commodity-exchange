using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Біржа_товарів.Forms;

namespace Біржа_товарів.Models
{
    // Клас продукта для створення екземплярів прродуктів та роботи з ними 
    public class Product
    {
        public int Id;
        public string ProductName;
        public int ProductAmount;
        public int? ProductPrice;
        public string? PaymentForm;
        public string? DeliveryCondition;
        public string? Adress;
        public string? Notes;
        public string? OwnerLogin;

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

        // Перевизначений метод ToString() для коректного відображення знайдених продуктів
        public override string ToString()
        {
            return $"Назва: {ProductName}; " +
                $"Ціна: {ProductPrice} грн; Кількість: {ProductAmount}";
        }

        // Метод пошуку продуктів за заданими параметрами
        public static List<Product> Search(LinkedList<Product> products,
            Dictionary<string, string> searchParameters)
        {
            List<Product> foundProducts = new List<Product>();

            foreach (Product product in products)
            {
                bool found = true;

                foreach (var item in searchParameters)
                {
                    string productFieldName = item.Key;
                    string searchParameterValue = item.Value;

                    var prop = product.GetType().GetField(productFieldName);
                    var value = prop?.GetValue(product);

                    if (prop != null && prop.Name == "ProductPrice" && 
                        value != null && value is IConvertible)
                    {
                        int actualValue = Convert.ToInt32(value);
                        int actualParameterValue = Convert.ToInt32(searchParameterValue);

                        if (actualParameterValue < actualValue)
                        {
                            found = false;
                            break;
                        }
                    }
                    else if (value != null && 
                        (value.ToString().ToLower()?.Contains(searchParameterValue.ToLower()) != true))
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
    }
}
