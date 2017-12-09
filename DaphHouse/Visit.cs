﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaphHouse
{
    enum TypeOfRoom
    {
        ParkView,
        WaterView,
        Standard
    }


    class Visit
    {

        #region Properties related to the particular visit
        //need to figure out how to handle date/time
        public int DayIn { get; set; }
        public int DayOut { get; set }
        public TypeOfRoom RoomType { get; set; }
        #endregion


    }
}
