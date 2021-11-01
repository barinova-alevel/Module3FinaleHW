using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace UsersOrders
{
    public class FileProcessor
    {
        public static void PrintFile(List<Order> orders, List<User> users)
        {
            var result = from u in users
                         join o in orders on u.UserId equals o.UserId
                         // where u.Age > 18
                         select new { OrderNumber = o.OrderNumber, OrderDate = o.OrderDate, UserName = u.Name, Total = o.Total };

            using (TextWriter tw = new StreamWriter("result.txt"))
            {
                foreach (var item in result)
                {
                   tw.WriteLine($"{item.OrderNumber};{item.OrderDate};{item.UserName};{item.Total}");
                }
            }

        }

        public static string[] ReadFile(string path)
        {
            string[] readText = File.ReadAllLines(path);

            return readText;
        }
    }
}


