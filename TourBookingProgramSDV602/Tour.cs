using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourBookingProgramSDV602
{
    public class Tour
    {
        public string tourName { get; set; }
        public decimal numPeople { get; set; }

        public override string ToString()
        {
            return this.tourName;
        }
    }

    
}
