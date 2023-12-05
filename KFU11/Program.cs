using System;

namespace KFU11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lab 13 / 1-2");
            Bank account = new Bank(AccountType.Current,350000, "Vladislav N");
            account.Deposit(600000);
            account.WithDraw(200000);

            Transaction transaction = account[0];
            Console.WriteLine(transaction.Amount);




            Console.WriteLine("Lab 13 / DZ 1");
            Building building = new Building(2,20,5,30,2);
            Console.WriteLine(building);


            Console.WriteLine("Lab 13 / DZ 2");
            BuildingLibrary buildings = new BuildingLibrary();

            buildings[0].Height = 20;
            buildings[1].Height = 30;
            buildings[2].Height = 50;

            Console.WriteLine(buildings[0].Height);
            Console.WriteLine(buildings[1].Height);
            Console.WriteLine(buildings[2].Height);


        }
    }
}
