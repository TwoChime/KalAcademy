using System;
using System.Collections.Generic;
using System.Text;

namespace AidCalculator
{
    static class MaskBank
    {
        //private static MaskBankContext db = new MaskBankContext();
        /// <summary>
        /// Create an account with the mask bank
        /// </summary>
        /// <param name = "pinNumber" > Account holder's pin number</param>
        /// <param name = "email" > Account holder's email address</param>
        /// <param name = "phone" > Account holder's phone number</param>
        /// <param name = "uSCountyState" > Account holder's county and state</param>
        /// <param name = "totalPopulation" > County's total population</param>
        /// <param name = "percentOver80" > Percent of county's population over age of 80</param>
        /// <param name = "symptomaticOver80" > Number of residents over 80 with current symptoms of COVID-19</param>
        /// <param name = "recoveredOver80" > Number of residents over 80 who officially recovered from COVID-19</param>

        /// <returns></returns>
        public static Account CreateAccount(int pinNumber,string email,
            string phone, USCountyStates uSCountyState, int totalPopulation, decimal percentOver80,
            int symptomaticOver80, int recoveredOver80)
        {
            var account = new Account
            {
                PinNumber = pinNumber,
                Email = email,
                Phone = phone,
                USCountyState = uSCountyState,
                TotalPopulation = totalPopulation,
                PercentOver80 = percentOver80,
                SymptomaticOver80 = symptomaticOver80,
                RecoveredOver80 = recoveredOver80
                
            };
            //db.Accounts.Add(account);
            //db.SaveChanges();
            return account;
        }
    }
}
