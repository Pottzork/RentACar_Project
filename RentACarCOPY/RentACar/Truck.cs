using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar
{
    /// <summary>
    /// Truck class which inherits from the abstract class Vehicles
    /// </summary>
    public class Truck : Vehicles
    {
        float CargoCapacity;

        /// <summary>
        /// Checks if the cargo capacity requested is within the limits of the truck
        /// </summary>
        /// <returns> True or false </returns>
        public bool CheckCapacity()
        {
            return true;
        }

        /// <summary>
        /// Constructor for creating a truck
        /// </summary>
        /// <param name="regNr"> Registration number of the truck</param>
        /// <param name="dPrice"> Daily price for renting the truck </param>
        public Truck(string regNr, float dPrice) : base(regNr, dPrice)
        {
            RegistrationNumber = regNr;
            DailyPrice = dPrice;
        }

    }
}
