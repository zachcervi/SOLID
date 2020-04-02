using SOLID.D;
using SOLID.I;
using SOLID.L;
using SOLID.O;
using SOLID.S;
using System;
using System.Collections.Generic;

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

            Console.WriteLine("############################## The L of SOLID ######################################################################");
            Apple apple = new Apple();
            Console.WriteLine(apple.GetColor());

            Orange orange = new Orange();
            Console.WriteLine(orange.GetColor());

            Console.WriteLine("############################## The I of SOLID ######################################################################");
            HPLaserJetPrinter HPPrinter = new HPLaserJetPrinter();
            Console.WriteLine("~~~~ HP Printer ~~~~");
            HPPrinter.Print("1234");
            HPPrinter.Fax("1234");
            HPPrinter.Scan("1234");
            HPPrinter.PrintDuplex("1234");

            Console.WriteLine("~~~~ Liquid Ink Printer ~~~~");
            LiquidInkPrinter liquidInkPrinter = new LiquidInkPrinter();
            liquidInkPrinter.Print("1234");
            liquidInkPrinter.Scan("1234");

            Console.WriteLine("############################## The D of SOLID ######################################################################");
            IAutomobile automobile = new Jeep();
            //IAutomobile automobile = new Dodge();
            AutomobileController automobileController = new AutomobileController(automobile);
            //automobile.Ignition();
            //automobile.Stop();
            automobileController.Ignition();
            automobileController.Stop();
        }
    }
}
   
