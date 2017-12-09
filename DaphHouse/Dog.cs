using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaphHouse
{

    enum TypeOfDog
    {
        Lab,
        Doberman,
        Mutt,
        Poodle,
        GoldenRetriever,
        Boxer,
        EnglishBulldog,
        Frenchie
    }

    class Dog
    {
        #region Statics
        private static int lastDogID = 0;
        #endregion

        #region Properties related to the pet
        public int DogID { get; private set; }
        public string DogName { get; set; }
        public TypeOfDog Breed { get; set; }
        public int Age { get; set; }
        public string VetName { get; set; }
        //Is contact number string or int?
        public string VetPhone { get; set; }
        public string OwnerName { get; set; }
        public string OwnerPhone { get; set; }
        #endregion



        #region Methods
        #endregion


        #region Constructor
        public Dog()
        {
           DogID = ++lastDogID;
        }
        #endregion


    }
}
