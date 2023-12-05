using System;
using KFU11;

namespace Lab14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lab 14");
            Bank account = new Bank(AccountType.Current,350000, "Vladislav N");
            account.Deposit(346666);
            account.DumpToScreen();
        }
    }
}
