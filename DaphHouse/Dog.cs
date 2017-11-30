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
        public int DogID { get; private set; }
        public string DogName { get; set; }
        public string Breed { get; set; }
        public int Age { get; set; }
        public string VetName { get; set; }
        //Is contact number string or int?
        public string VetPhone { get; set; }
        #endregion

        #region Methods
       
        #endregion
    }
}
