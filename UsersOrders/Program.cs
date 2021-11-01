using System;
using System.Threading;
using System.Threading.Tasks;
namespace UsersOrders
{
    class Program
    {
        static void Main(string[] args)
        {
            string ordersFilePath = @"..\..\..\OrdersFile.txt";
            string usersFilePath = @"..\..\..\UsersFile.txt";

            FileProcessor.PrintFile(DataProcessor.GetOrders(ordersFilePath), DataProcessor.GetUsers(usersFilePath));

            Console.ReadKey();

        }
    }
}

