using System;
using System.Collections.Generic;
using System.Text;

namespace AidCalculator
{
    //Had to delete the actual enum USCountyState list b/c VS keeps crashing
    enum USCountyStates
    {
        Travis,
        Williamson,
        Hays

    }

    /// <summary>
    /// This class represents an official account for each county representative to access and use
    /// </summary>
    class Account
    {
        private static int lastPinNumber = 1000;

        #region Properties

        /// <summary>
        /// Unique account pin number
        /// </summary>
        public int PinNumber { get;  set; }

        /// <summary>
        /// Account holder email address
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Account holder phone number
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Enum list of all US Counties by State, e.g. 'Travis County of Texas'
        /// </summary>
        public USCountyStates USCountyState { get; set; }

        /// <summary>
        /// Reported total population of the county
        /// </summary>
        public int TotalPopulation { get; set; }

        /// <summary>
        /// Reported total number of county residents
        /// </summary>
        public decimal PercentOver80 { get; set; }

        /// <summary>
        /// Reported number of county residents over 80 years old who are currently showing or reporting symptoms of COVID-19
        /// </summary>
        public int SymptomaticOver80 { get; set; }

        /// <summary>
        /// Reported number of county residents over 80 who have recovered from COVID-19
        /// </summary>
        public int RecoveredOver80 { get; set; }

        /// <summary>
        /// The date of the last request made by the county to the mask bank
        /// </summary>
        public DateTime LastRequest { get; private set; }

        /// <summary>
        /// The number of masks assigned to each county per request
        /// </summary>
        public int MasksAssigned { get; private set; }

        #endregion


        #region Constructor

        public Account()
        {
            PinNumber = ++lastPinNumber;
            LastRequest = DateTime.Now;
        }
        #endregion


        #region Methods

        /// <summary>
        /// Update the number of symptomatic residents over 80
        /// </summary>
        /// <param name="quantity">New symptomatic over 80 number</param>
        public void Calculate(int quantity)
        {
            //SymptomaticOver80 = SymptomaticOver80 + quantity 
            SymptomaticOver80 += quantity;
        }

        #endregion
    }
}
