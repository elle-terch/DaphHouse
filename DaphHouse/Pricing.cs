using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaphHouse
{
    class Pricing
    {
        #region Statics
        public static decimal DailyRate = 25;

        #endregion



        #region Properties related to pricing
        public decimal MedicationRate { get; private set; }
        public decimal PlayRate { get; private set; }
        public decimal PlaytimeFee { get; set; }
        #endregion
    }
}
