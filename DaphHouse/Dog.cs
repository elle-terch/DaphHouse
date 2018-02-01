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

        [Required]
        public string DogName { get; set; }

        [Required]
        public TypeOfDog Breed { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public string VetName { get; set; }

        [StringLength(10, ErrorMessage ="Wrong amount of numbers.")]
        [Required]
        public string VetPhone { get; set; }

        [Required]
        public string OwnerName { get; set; }

        [StringLength(10, ErrorMessage = "Please enter numbers only, including the area code.")]
        [Required]
        public string OwnerPhone { get; set; }
        #endregion



    }
}
