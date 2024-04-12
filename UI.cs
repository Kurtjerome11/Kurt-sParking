using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kurt_sParking;
using Parkingg;

namespace ParkUI
{
    internal class UI
    {
        internal class Program
        {
            public static void Main(string[] args)
            {
                Console.WriteLine("Enter you Username: ");
                string accountNumber = Console.ReadLine();

                Console.WriteLine("Enter your password: ");
                string accountPassword = Console.ReadLine();

                Servivess accountServices = new Servivess();
                bool result = accountServices.VerifyAccount(accountNumber);
                bool result1 = accountServices.VerifyPassword(accountPassword);


                if (result)
                {
                    Console.WriteLine("Welcome to Kurt's Parking");
                    Console.WriteLine("What do you want to do?");
                    Console.WriteLine("1.I want to park my vehicle");
                    Console.WriteLine("2.I want to go out");
                    Console.WriteLine("3.What is your parking rate?");
                    Console.WriteLine("Enter a number:");
                    string number = Console.ReadLine();

                    if (number == "1")
                    {
                        Console.WriteLine("Okay here is your parking ticket.");
                    }

                    if (number == "2")
                    {
                        Console.WriteLine("Okay bye, have a good day! ");
                    }

                    if (number == "3")
                    {
                        Console.WriteLine("Motorcycle=20PHP");
                        Console.WriteLine("Car=50PHP");
                        Console.WriteLine("That's between 8am to 8pm only, If you exceed the time, you will have to pay 20PHP per hour");
                    }
                }
                else
                {
                    Console.WriteLine("ERROR");
                }
            }
        }
    }

}