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
        /// <summary>
        /// Add a dog to database
        /// </summary>
        /// <param name="dogName">Name of dog</param>
        /// <param name="breed">Dog breed</param>
        /// <param name="age">Age of dog</param>
        /// <param name="vetName">Name of vet</param>
        /// <param name="vetPhone">Vet phone</param>
        /// <param name="ownerName">Name of owner</param>
        /// <param name="ownerPhone">Owner phone</param>
        /// <returns>Dog information</returns>
        /// <exception cref="ArgumentNullException" />

        #region Methods 
        public static Dog CreateDog(string ownerName, string ownerPhone, string dogName, TypeOfDog breed, int age, string vetName, string vetPhone)
        {

            if (string.IsNullOrEmpty(ownerName))
                throw new ArgumentNullException("ownerName", "Your name is required!");



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
            return db.Dogs.Where(a => a.OwnerName == ownerName).ToList();
        }

        public static Visit CreateVisit(DateTime dayIn, DateTime dayOut, TypeOfRoom roomType, int dogID)
        {
            var dog = db.Dogs.Where(v => v.DogID == dogID).FirstOrDefault();
            var visit = new Visit
            {
                DayIn = dayIn,
                DayOut = dayOut,
                RoomType = roomType,
                DogID = dog.DogID
            };

            db.Visits.Add(visit);
            db.SaveChanges();
            return visit;
        }


        public static List<Visit> GetAllVisits(int dogID)
        {
            return db.Visits.Where(v => v.DogID == dogID).ToList();
        }

        #endregion



    }
}
