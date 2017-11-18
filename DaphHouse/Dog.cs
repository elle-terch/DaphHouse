using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaphHouse
{
    /// <summary>
    /// This is an application that can be used by a kennel to schedule dog visits.
    /// </summary>
    class Dog
    {
        #region Properties related to the pet
        public string DogName { get; set; }
        public string Breed { get; set; }
        public int Age { get; set; }
        public string VetName { get; set; }
        //Is contact number string or int?
        public string VetPhone { get; set; }
        #endregion
    }

    class Owner
    {
        #region Properties related to the owner
        public string OwnerName { get; set; }
        public string OwnerPhone { get; set; }
        public string EmergencyContact { get; set; }
        public string EmergencyPhone { get; set; }
        #endregion
    }

    class Visit
    {
        #region Properties related to the particular visit
        public int TotalDays { get; set; }
        public decimal DailyRate { get; set; }
        public string FoodType { get; set; }
        public int FoodFrequency { get; set; }
        public string MedicationName { get; set; }
        public int MedicationFrequency { get; set; }
        public decimal MedicationFee { get; set; }
        public int Playtime { get; set; }
        public decimal PlaytimeFee { get; set; }
        public string Belongings { get; set; }
        public string MiscComments { get; set; }
        #endregion

    }

}
