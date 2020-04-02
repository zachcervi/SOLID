using SOLID.O;
using SOLID.S;
using System;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("############################## The S of SOLID ######################################################################");
            GarageStationUtility stationUtility = new GarageStationUtility();
            GarageStation garage = new GarageStation(stationUtility);
            garage.OpenForService();
            garage.DoService();
            garage.CloseGarage();

            Console.WriteLine("############################## The O of SOLID ######################################################################");
            RegularSavingsAccount savingsAccount = new RegularSavingsAccount();
            savingsAccount.Balance = 10000;
            Console.WriteLine($"The interest on the Regular Savings Account with a balance of ${savingsAccount.Balance} is ${savingsAccount.CalcInterest()}.");

            SalarySavingsAccount salarySavingsAccount = new SalarySavingsAccount();
            salarySavingsAccount.Balance = 50000;
            Console.WriteLine($"The interest on the Salary Savings Account with a balance of ${salarySavingsAccount.Balance} is ${salarySavingsAccount.CalcInterest()}.");

            CorporateAccount corporateAccount = new CorporateAccount();
            corporateAccount.Balance = 100000;
            Console.WriteLine($"The interest on the Corporate Account with a balance of ${corporateAccount.Balance} is ${corporateAccount.CalcInterest()}.");


        }
    }
}
