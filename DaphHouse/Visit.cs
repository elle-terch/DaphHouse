using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaphHouse
{
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
        public string RoomChoice { get; set; }
        public int Playtime { get; set; }
        public decimal PlaytimeFee { get; set; }
        public string Belongings { get; set; }
        public string MiscComments { get; set; }
        #endregion


    }
}
