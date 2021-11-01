using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersOrders
{
    public class DataProcessor
    {

        public static List<Order> GetOrders(string path)
        {
            var orderList = new List<Order>();
            string[] orders = FileProcessor.ReadFile(path);
            foreach (string s in orders)
            {
                string[] subs = s.Split(';');
                orderList.Add(new Order { OrderId = subs[0], UserId = subs[1], OrderNumber = subs[2], OrderDate = subs[3], Total = subs[4] });
            }
            
            return orderList;
        }

        public static List<User> GetUsers(string path)
        {
            var usersList = new List<User>();
            string[] users = FileProcessor.ReadFile(path);
            foreach (string s in users)
            {
                string[] subs = s.Split(';');
                usersList.Add(new User { UserId = subs[0], Name = subs[1], Gender = subs[2], Age = subs[3] });
            }
            return usersList;
        }
    }
}
