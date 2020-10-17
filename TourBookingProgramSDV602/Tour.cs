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
        public string tourType { get; set; }
        public decimal numPeople { get; set; }

        //public tour(string tourtype, decimal numpeople)
        //{
        //    this.tourtype = tourtype;
        //    this.numpeople = numpeople;
        //}

        //public string TourType
        //{
        //    get { return tourType; }
        //    set { tourType = value; }
        //}

        //public decimal NumPeople
        //{
        //    get { return numPeople; }
        //    set { numPeople = value; }
        //}

        /*public Tour()
        {
            TourType = "default title";
            NumPeople = 0; 
        }*/
    }
}
