using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Біржа_товарів.Data
{
    internal static class DataAccess
    {
        const string BuyersData = @"C:\курсова\Біржа товарів\Біржа товарів\Buyers.txt";
        const string SellersData = @"C:\курсова\Біржа товарів\Біржа товарів\Sellers.txt";

        public static void WriteToDataBase(string Path, string Data)
        {
            using (StreamWriter sw = new StreamWriter(Path, true))
            {
                sw.WriteLine(Data);
            }
        }

        public static void CreateDirectory(string Path) 
        {
            try
            {
                if (!Directory.Exists(Path))
                {
                    Directory.CreateDirectory(Path);
                }
                else
                {
                    Console.WriteLine("Така папка існує.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Помилка: " + e.Message);
            }
        }

    }
}
