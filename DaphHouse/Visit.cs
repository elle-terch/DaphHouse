using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaphHouse
{
    public enum TypeOfRoom
    {
        ParkView,
        WaterView,
        Standard
    }

    public class Visit
    {

        #region Properties related to the particular visit
        [Key]
        public int VisitID { get; private set; }
        public DateTime DayIn { get; set; }
        public DateTime DayOut { get; set; }
        public TypeOfRoom RoomType { get; set; }
        [ForeignKey("Dog")]
        public int DogID { get; set; }
        public virtual Dog Dog { get; set; }
        #endregion


    }
}