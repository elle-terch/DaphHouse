﻿using System;
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

            while (true)
            {

                Console.WriteLine("0.Exit");
                Console.WriteLine("1. Add your dog to our database.");
                Console.WriteLine("2. See all your dogs.");
                Console.WriteLine("3. Schedule a visit.");
                Console.WriteLine("4. See all of your dog's visits.");

                Console.Write("Please select an option:");
                var choice = Console.ReadLine();

                switch (choice)
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
                            for (var i = 0; i < typeOfDogs.Length; i++)
                            {
                                Console.WriteLine($"{i + 1}.{typeOfDogs[i]}");
                            }
                            Console.Write("Dog breed: ");
                            try
                            {
                                var dogType = Convert.ToInt32(Console.ReadLine());
                                Console.Write("How old is your dog?");
                                var age = Console.ReadLine();
                                Console.Write("Who is your primary vet?");
                                var vetName = Console.ReadLine();
                                Console.Write("What is your vet's phone number?");
                                var vetPhone = Console.ReadLine();
                                var dog = Kennel.CreateDog(ownerName, ownerPhone, dogName, (TypeOfDog)(dogType - 1), Convert.ToInt32(age), vetName, vetPhone);
                                Console.WriteLine($"Dog Name:{dog.DogName}, Age:{dog.Age}, Owner:{dog.OwnerName}");
                            }

                            catch(FormatException)
                            {
                                Console.WriteLine("Breed is invalid!");
                            }

                            catch(ArgumentNullException ax)
                            {
                                Console.WriteLine($"Error - {ax.ParamName}, {ax.Message}");
                            }

                            catch(Exception ex)
                            {
                            Console.WriteLine($"Something went wrong:{ex.Message}");
                            }

                        break;

                    case "2":
                        Console.Write("Your Name: ");
                        var dogOwner = Console.ReadLine();
                        var dogs = Kennel.GetAllDogs(dogOwner);
                        foreach (var d in dogs)
                        {
                            Console.WriteLine($"Dog Name:{d.DogName}, Age:{d.Age}");
                        }
                        break;

                    case "3":
                        PrintAllDogs();
                        Console.Write("What is your dog's ID?");
                        var dogID = Convert.ToInt32(Console.ReadLine());
                        Console.Write("When would you like to drop off your dog?");
                        var dayIn = Convert.ToDateTime(Console.ReadLine());
                        Console.Write("When are you picking your dog up?");
                        var dayOut = Convert.ToDateTime(Console.ReadLine());
                        Console.Write("What type of room would you like?");
                        var typeOfRooms = Enum.GetNames(typeof(TypeOfRoom));
                        for (var r = 0; r < typeOfRooms.Length; r++)
                        {
                            Console.WriteLine($"{r + 1}.{typeOfRooms[r]}");
                        }
                        Console.Write("Room Type: ");
                        var roomType = Convert.ToInt32(Console.ReadLine());
                        var visit = Kennel.CreateVisit(dayIn, dayOut, (TypeOfRoom)(roomType - 1), dogID);
                        Console.WriteLine($"Drop off: {visit.DayIn}, Pick up: {visit.DayOut}, Room type: {visit.RoomType}");
                        break;

                    case "4":
                        PrintAllDogs();
                        Console.Write("What is your dog's ID?");
                        dogID = Convert.ToInt32(Console.ReadLine());
                        var visits = Kennel.GetAllVisits(dogID);
                        foreach (var v in visits)
                        {
                            Console.WriteLine($"Day In:{v.DayIn}, Day Out:{v.DayOut}");
                        }
                        break;
              

                    default:
                        Console.WriteLine("Invalid choice. Please try again!");
                        break;



                }
            }


        }
        private static void PrintAllDogs()
        {
            Console.Write("What is your name?");
            var ownerName = Console.ReadLine();
            var dogs = Kennel.GetAllDogs(ownerName);
            foreach (var d in dogs)
            {
                Console.WriteLine($"Dog Name: {d.DogName}, Dog Id: {d.DogID}");
            }

            
        }

    }
}
