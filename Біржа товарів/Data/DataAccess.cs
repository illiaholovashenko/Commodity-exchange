using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Біржа_товарів.Forms;
using Біржа_товарів.Models;
using static Біржа_товарів.Utilities.Validators;
using static Біржа_товарів.Utilities.Utilities;
using System.Web;

namespace Біржа_товарів.Data
{
    // Статичний клас для роботи з базою даних
    internal static class DataAccess
    {
        public const string DataBasePath = @"..\..\..\DataBase\";
        public const string CustomersData = DataBasePath + "Customers.txt";
        public const string SalesmenData = DataBasePath + "Salesmen.txt";
        public const string SalesmenAddedProducts = DataBasePath + @"SalesmenAddedProducts\";
        public const string CustomerAddedProducts = DataBasePath + @"CustomersAddedProducts\";
        public const string SaleArchive = DataBasePath + @"SaleArchive\";
        public const string PurchasesArchive = DataBasePath + @"PurchasesArchive\";

        // Метод для запису даних у базу даних
        public static void WriteToDataBase(string Path, string Data)
        {
            using (StreamWriter sw = new StreamWriter(Path, true))
            {
                sw.WriteLine(Data);
            }
        }

        // Метод для отримання рядка данних з файлу за унікальним параметром
        public static string? GetItemFromDatabase(string path, 
            string FullLogOrPhoneField)
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

        // Метод для отримання данних про товар за унікальним ідентифікатором
        public static string? GetItemById(string path, string idField)
        {
            string[] files;
            string? line;

            try
            {
                files = Directory.GetFiles(path);
            }
            catch (DirectoryNotFoundException)
            {
                files = new string[0];
            }

            foreach (string filePath in files)
            {
                if ((line = GetItemFromDatabase(filePath, idField)) != null)
                {
                    return line;
                }
            }
            return null;
        }

        // Метод для завантаження з папки всіх продуктів з бази даних
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
                        string[] productProp = GetData(Productline, 9);
                        Product product = new Product(productProp);
                        list.AddLast(product);
                    }
                }
            }

            return list;
        }

        // Метод який зчитує архів у базі даних та повертає його список 
        public static List<string>? LoadArchive(string Path)
        {
            List<string> archive = new List<string>();

            try
            {
                using (StreamReader reader = new StreamReader(Path))
                {
                    string? line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        archive.Add(line);
                    }
                }
            }
            catch (FileNotFoundException)
            {
                return null;
            }
            return archive;
        }

        // Метод для видалення або зміни змісту строки з даними у базі даних
        public static void ChangeLineInDataBase(string folderPath, 
            string? oldLine, string? newLine, string? lineToRemove)
        {
            string[] files = Directory.GetFiles(folderPath);

            foreach (string filePath in files)
            {
                string tempFilePath = Path.GetTempFileName();

                using (StreamReader reader = new StreamReader(filePath))
                {
                    using (StreamWriter writer = new StreamWriter(tempFilePath))
                    {
                        string? line;

                        bool lineReplaced = false;

                        while ((line = reader.ReadLine()) != null)
                        {
                            if (lineToRemove != null && line == lineToRemove)
                            {
                                continue;
                            }
                            else if (oldLine != null && newLine != null && 
                                line == oldLine && !lineReplaced)
                            {
                                writer.WriteLine(newLine);
                                lineReplaced = true;
                            }
                            else
                            {
                                writer.WriteLine(line);
                            }
                        }
                    }
                }

                File.Delete(filePath);
                File.Move(tempFilePath, filePath);
            }
        }
    }
}
