using System;

namespace AidCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            //Creating an instance of a mask bank account, which is an object
            var myFirstAccount = new Account();
            myFirstAccount.USCountyState = USCountyStates.Hays; 
            myFirstAccount.Email = "test@test.com";
            myFirstAccount.Phone = "123-456-7890";
            myFirstAccount.TotalPopulation = 10000;
            myFirstAccount.PercentOver80 = (Decimal) 0.10;
            myFirstAccount.SymptomaticOver80 = 500;
            myFirstAccount.RecoveredOver80 = 300;
            myFirstAccount.Calculate(500);
            Console.WriteLine($"PinNumber: {myFirstAccount.PinNumber}, County: {myFirstAccount.USCountyState}, Email: {myFirstAccount.Email}, Phone: {myFirstAccount.Phone}, TotalPopulation: {myFirstAccount.TotalPopulation}, PercentOver80: {myFirstAccount.PercentOver80}, SymptomaticOver80: {myFirstAccount.SymptomaticOver80}, RecoveredOver80: {myFirstAccount.RecoveredOver80}");


        }
    }
}