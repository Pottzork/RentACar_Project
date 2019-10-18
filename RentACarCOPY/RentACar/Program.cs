using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        public static void Menu()
        {
            Console.WriteLine("|---------------------------------------------------------|");
            Console.WriteLine("| Welcome to RentACar Company based in This Virtual World |");
            Console.WriteLine("|---------------------------------------------------------|");
            Console.WriteLine();
            Console.WriteLine("1: Create User ");
            Console.WriteLine("2: Exit ");
            int userInput = int.Parse(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    User.CreateUser();
                    Console.Clear();
                    MenuAfterCreatingUser();
                    break;

                case 2:
                    Console.WriteLine("Thanks for your time. Press enter to exit program.");
                    Console.ReadKey();
                    Environment.Exit(1);
                    break;
            }
        }
        public static void MenuAfterCreatingUser()
        {
            Console.WriteLine("|---------------------------------------------------------|");
            Console.WriteLine("| Welcome to RentACar Company based in This Virtual World |");
            Console.WriteLine("|---------------------------------------------------------|");
            Console.WriteLine();
            Console.WriteLine("1: Create User ");
            Console.WriteLine("2: Show Vehicles ");
            Console.WriteLine("3: Exit ");
            int userInput = int.Parse(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    User.CreateUser();
                    Console.Clear();
                    MenuAfterCreatingUser();
                    break;

                case 2:
                    Console.Clear();
                    Sedan.CreateCarObject();
                    MenuAfterShowVehicles();
                    break;

                case 3:
                    Console.WriteLine("Thanks for your time. Press enter to exit program.");
                    Console.ReadKey();
                    Environment.Exit(1);
                    break;
            }
        }

        public static void MenuAfterShowVehicles()
        {
            Console.WriteLine();
            Console.WriteLine("1: Choose car to rent "); 
            Console.WriteLine("2: MainMenu ");
            Console.WriteLine("3: Exit ");
            int userInput = int.Parse(Console.ReadLine());

            switch (userInput)
            {
                case 1:

                    //Rental.RentalPeriod();
                    break;

                case 2:
                   
                    break;

                case 3:
                    Console.WriteLine("Thanks for your time. Press enter to exit program.");
                    Console.ReadKey();
                    Environment.Exit(1);
                    break;
            }
        }
    }
}
