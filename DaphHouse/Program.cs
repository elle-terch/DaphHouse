using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaphHouse
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("***********************");
            Console.WriteLine("Welcome to Daph's House!");
            Console.WriteLine("***********************");
            Console.WriteLine("0.Exit");
            Console.WriteLine("1. Add your dog to our database.");
            Console.WriteLine("2. Schedule a visit.");
            Console.WriteLine("3. See your upcoming visits.");
            Console.WriteLine("4. See your visit history.");

            Console.Write("Please select an option:");
            var choice = Console.ReadLine();

            switch(choice)
            {
                case "0":
                    Console.WriteLine("Thank you for visiting");
                    return;
                case "1":
                    Console.Write("What is your name?");
                    var ownerName = Console.ReadLine();
                    Console.Write("What is your phone number?");
                    var ownerPhone = Console.ReadLine();
                    Console.Write("What is your dog's name?");
                    var dogName = Console.ReadLine();
                    Console.Write("What kind of dog do you have?");
                    var typeOfDogs = Enum.GetNames(typeof(TypeOfDog));
                    Console.Write("How old is your dog?");
                    var age = Console.ReadLine();
                    Console.Write("Who is your primary vet?");
                    var vetName = Console.ReadLine();
                    Console.Write("What is your vet's phone number?");
                    var vetPhone = Console.ReadLine();
                 


                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                default:
                    break;



            }


        }
    }
}
