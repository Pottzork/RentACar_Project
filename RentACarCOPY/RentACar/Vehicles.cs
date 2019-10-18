using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar
{
    /// <summary>
    /// Abstract vehicle class
    /// </summary>
    public abstract class Vehicles
    {
        protected string RegistrationNumber { get; set; }
        protected float dailyPrice { get; set; }
        public static int TotalNumberOfVehicles { get; set; } //Ta bort set?

        /// <summary>
        /// Constructor for creating a vehicle object
        /// </summary>
        /// <param name="regNr"> Registration number of the vehicle </param>
        /// <param name="dPrice"> Daily price of rental for the vehicle </param>
        public Vehicles(string regNr, float dPrice)
        {
            RegistrationNumber = regNr;
            DailyPrice = dPrice;
            // For each vehicle created, increment the total number of vehicles stored.
            TotalNumberOfVehicles++;
        }

        public float DailyPrice
        {
            get { return dailyPrice; }
            set
            {
                dailyPrice = value;
            }
        }


    }
}
