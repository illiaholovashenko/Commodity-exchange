using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Біржа_товарів.Data
{
    internal static class DataAccess
    {
        public const string DataBasePath = @"\Біржа товарів\DataBase\";
        public const string CustomersData = DataBasePath + "Customers.txt";
        public const string SalesmenData = DataBasePath + "Salesmen.txt";

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
    }
}
