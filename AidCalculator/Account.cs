using System;

namespace AidCalculator
{
    public class Account
    {
        #region Properties
        /// <summary>
        /// Unique pin number for city representative to use to access their mask bank account
        /// </summary>
        public string PinNumber { get; set; }
        /// <summary>
        /// Official email address for city representative to receive email communications from mask bank
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Official phone number for city representative to receive calls from mask bank
        /// </summary>
        public string Phone { get; set; }
        public string City { get; set; }
        public USState State { get; set; }
        public string ZipCode { get; set; }
        /// <summary>
        /// Reported total population of the city
        /// </summary>
        public int TotalPopulation { get; set; }
        /// <summary>
        /// Reported percent of total population of the city residents who are over 80 years old
        /// </summary>
        public decimal PercentOver80 { get; set; }
        /// <summary>
        /// Reported number of city residents over 80 years old who are currently showing or reporting symptoms of COVID-19
        /// </summary>
        public int SymptomaticOver80 { get; set; }
        /// <summary>
        /// Reported number of city residents over 80 who have recovered from COVID-19
        /// </summary>
        public int RecoveredOver80 { get; set; }
        /// <summary>
        /// The date of the last request made by the city to the mask bank
        /// </summary>
        public DateTime LastRequest { get; set; }
        public int MasksAssigned { get; set; }

        #endregion

        #region Methods

        public void UpdateSymptomaticOver80(int quantity)
        {
            //SymptomaticOver80 = SymptomaticOver80 + quantity 
            SymptomaticOver80 += quantity;
        }

        public void UpdateRecoveredOver80(int quantity)
        {
            //RecoveredOver80 = RecoveredOver80 + quantity 
            RecoveredOver80 += quantity;
        }

        #endregion
    }

    public enum USState
    {
        Alabama, Alaska, Arizona, Arkansas, California, Colorado, Connecticut, Delaware, Florida, Georgia, Hawaii, Idaho, Illinois, Indiana, Iowa, Kansas, Kentucky, Louisiana, Maine, Maryland, Massachusetts, Michigan, Minnesota, Mississippi, Missouri, Montana, Nebraska, Nevada, New Hampshire, New Jersey, New Mexico, New York, North Carolina, North Dakota, Ohio, Oklahoma, Oregon, Pennsylvania, Rhode Island, South Carolina, South Dakota, Tennessee, Texas, Utah, Vermont, Virginia, Washington, West Virginia, Wisconsin, Wyoming,
    }
    
}
