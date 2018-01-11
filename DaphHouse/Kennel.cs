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

        private static KennelModel db = new KennelModel();
        private static List<Visit> visits = new List<Visit>();

        #region Methods 
        public static Visit CreateVisit(DateTime dayIn, DateTime dayOut, TypeOfRoom roomType)
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


            db.Dogs.Add(dog);
            db.SaveChanges();
            return dog;
        }

        public static List<Dog> GetAllDogs(string ownerName)
        {
            return db.Dogs.Where(a => a.OwnerName==ownerName).ToList();
        }

        public static List<Visit> GetAllVisits ()
        {

            return visits;
        }

    #endregion



    }
}


