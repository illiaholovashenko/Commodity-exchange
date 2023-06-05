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

        public Product(string[] ProductData)
        {
            Id = int.Parse(ProductData[0]);
            ProductName = ProductData[1];
            ProductPrice = ProductData[2] != "" ? int.Parse(ProductData[2]) : 0;
            ProductAmount = int.Parse(ProductData[3]);
            Adress = ProductData[4];
            PaymentForm = ProductData[5];
            DeliveryCondition = ProductData[6];
            Notes = ProductData[7];
            OwnerLogin = ProductData[8];
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

                    var field = product.GetType().GetField(productFieldName);
                    var value = field?.GetValue(product);

                    if (field != null && field.Name == "ProductPrice" && 
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
                        (value.ToString()?.ToLower().Contains(searchParameterValue.ToLower()) != true))
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
