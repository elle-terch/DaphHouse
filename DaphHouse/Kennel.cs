using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaphHouse
{
    static class Kennel
    {
        #region Properties
        //add name, address, phone number, website, etc
        #endregion


        private static List<Visit> visits = new List<Visit>();
        private static List<Dog> dogs = new List<Dog>();

        #region Methods
        public static Visit CreateVisit(int dayIn, int dayOut, TypeOfRoom roomType = TypeOfRoom.Standard)
        {
            var visit = new Visit
            {
                DayIn = dayIn,
                DayOut = dayOut,
                RoomType = roomType
            };

            visits.Add(visit);

            return visit;
        }

        public static Dog CreateDog(string dogName, TypeOfDog breed, int age, string vetName, string vetPhone, string ownerName, string ownerPhone)
        {
            var dog = new Dog
            {
                DogName = dogName,
                Breed = breed,
                Age = age,
                VetName = vetName,
                VetPhone = vetPhone,
                OwnerName = ownerName,
                OwnerPhone = ownerPhone
            };

            dogs.Add(dog);

            return dog;
        }

    #endregion



    }
}


