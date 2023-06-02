using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Біржа_товарів.Forms;
using Біржа_товарів.Models;
using static Біржа_товарів.Utilities.Validators;
using static Біржа_товарів.Utilities.Utilities;


namespace Біржа_товарів.Data
{
    internal static class DataAccess
    {
        public const string DataBasePath = @"..\..\..\DataBase\";
        public const string CustomersData = DataBasePath + "Customers.txt";
        public const string SalesmenData = DataBasePath + "Salesmen.txt";
        public const string SalesmenAddedProducts = DataBasePath + @"SalesmenAddedProducts\";
        public const string CustomerAddedProducts = DataBasePath + @"CustomerAddedProduct\";

        public static void WriteToDataBase(string Path, string Data)
        {
            using (StreamWriter sw = new StreamWriter(Path, true))
            {
                sw.WriteLine(Data);
            }
        }

        public static string? GetItemFromDatabase(string path, string FullLogOrPhoneField)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains(FullLogOrPhoneField))
                    {
                        return line;
                    }
                }
            }
            return null;
        }

        public static LinkedList<Product> LoadData(string Path) 
        {
            LinkedList<Product> list = new LinkedList<Product>();
            string[] files;
            
            try
            {
                files = Directory.GetFiles(Path);
            }
            catch (DirectoryNotFoundException)
            {
                files = new string[0];
            }

            foreach (string filePath in files)
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string? Productline;
                    while ((Productline = reader.ReadLine()) != null)
                    {
                        string[] productProp = GetData(Productline, 7);
                        Product product = new Product(productProp);
                        list.AddLast(product);
                    }
                }
            }

            return list;
        }
    }
}
