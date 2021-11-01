using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class Account
    {
        public delegate void AccountHandler(string message);
        public event AccountHandler Notify;             
        public Account(int sum)
        {
            Sum = sum;
        }
        public int Sum { get; private set; }
        public void Put(int sum)
        {
            Sum += sum;
            Notify?.Invoke($"Crediting money: {sum}");
        }
        public void Take(int sum)
        {
            if (Sum >= sum)
            {
                Sum -= sum;
                Notify?.Invoke($"Withdrawal: {sum}");
            }
            else
            {
                Notify?.Invoke($"Not enough fund. Current balance: {Sum}"); ;
            }
        }
    }
}
