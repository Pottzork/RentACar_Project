using System;
using System.Collections.Generic;
using System.Collections;

namespace RentACar
{
    class Rental
    {
        private bool IsAvailable = true;
        private string StartDay;
        private string ReturnDay;
        private const float BookinFee = 200f;
        private const float hourFee = 70;

        static double userDaysInput;
        static double userHoursInput;

        //This function will calculate rentalTime..
        public static void CalculateRentalTimeHours()
        {
            if (userHoursInput > 0 && userHoursInput < 24)
            {
                double TotalCostHours = userHoursInput * hourFee + BookinFee;
                Console.WriteLine($"Totalfee for this car = {TotalCostHours}$ for {userHoursInput} hours rent."); 
            }
            else
            {
               // CalculateRentalTimeDays();
            }
        }

        public static void CalculateRentalTimeDays()
        {

            float volvoPrice = Sedan.listOfCars[1].DailyPrice;

            Console.WriteLine(volvoPrice);



            //Here we add days!
        }

        //Show list of all vehicles
        public static void ShowVehicles()
        {
            //Use Foreach to loop through all the vehicles in the list.
            
        }

        //Calculate total cost of rental and return value
        public void TotalCost()
        {
            // Create local variable TotalPrice
            //Totalprice =  CalculateRentalTime() + Dailyprice + discount/discounts
            //Print TotalPrice
            
        }

        //Method that will give 10% discount if rental = more then 7 days
        public void SevenDaysDiscount()
        {

        }
        public static void RentalPeriodInput()
        {
            //Prompts the user to choose to rent the car for either a couple of hours or days
            Console.WriteLine("How long do you want to rent the vehicle?");
            Console.WriteLine("1) Just a couple of hours");
            Console.WriteLine("2) A day or longer");
            string menuRentTime = Console.ReadLine();
            switch (menuRentTime)
            {
                //if user chooses "1", then the user must enter amount of hours which will be stored
                //in the userHoursInput variable, or if user chooses days it will be stored in userDaysInput
                case "1":
                    Console.Write("Enter how many hours you want to rent for: ");
                    userHoursInput = double.Parse(Console.ReadLine());
                    CalculateRentalTimeHours();
                    break;
                case "2":
                    Console.Write("Enter how many days you want to rent for: ");
                    userDaysInput = double.Parse(Console.ReadLine());
                    break;
                default:
                    break;
            }
        }

       
    }
}
