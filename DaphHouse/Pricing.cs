using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaphHouse
{
    class Pricing
    {
        #region Properties related to pricing
        public decimal DailyRate { get; private set; }
        public decimal MedicationRate { get; private set; }
        public decimal PlayRate { get; private set; }
        #endregion
    }
}
