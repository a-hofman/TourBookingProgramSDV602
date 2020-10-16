using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TourBookingProgramSDV602
{
    public class Tour
    {
        public string tourType;
        public decimal numPeople;

        public Tour(string tourType, decimal numPeople)
        {
            this.tourType = tourType;
            this.numPeople = numPeople;
        }

        public string TourType
        {
            get { return tourType; }
            set { tourType = value; }
        }

        public decimal NumPeople
        {
            get { return numPeople; }
            set { numPeople = value; }
        }

        /*public Tour()
        {
            TourType = "default title";
            NumPeople = 0; 
        }*/
    }
}
