using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace RentACar
{
    class User
    {
        static string userName;
        static List<string> _customerList = new List<string>();


        public string UserName
        {
            get
            {
                return userName;
            }
            set
            {           
                userName = value;
            }
        }

        //This method will creates users and put them in a list
        public static void CreateUser()
        {
            User newCustomer = new User(); // Making new User
            Console.Write("Enter customer name: "); //Enter customers name   
            newCustomer.UserName = Console.ReadLine();

            _customerList.Add(newCustomer.UserName); //Adding username to _CustomerList
        }

        public static void ShowCustomers()
        {
            foreach (var names in _customerList) //Foreach loop to show all names.
            {
                Console.WriteLine($"Customer: {names}");
            }
            Console.ReadKey();
        }
    }
}
