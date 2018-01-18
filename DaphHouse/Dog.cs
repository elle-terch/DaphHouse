using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaphHouse
{

    public enum TypeOfDog
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

    public class Dog
    {

        #region Properties related to the pet
        [Key]
        public int DogID { get; private set; }
        public string DogName { get; set; }
        public TypeOfDog Breed { get; set; }
        public int Age { get; set; }
        public string VetName { get; set; }
        [StringLength(10, ErrorMessage ="Wrong amount of numbers.")]
        public string VetPhone { get; set; }
        public string OwnerName { get; set; }
        [StringLength(10, ErrorMessage = "Please enter numbers only, including the area code.")]
        public string OwnerPhone { get; set; }
        #endregion



    }
}
