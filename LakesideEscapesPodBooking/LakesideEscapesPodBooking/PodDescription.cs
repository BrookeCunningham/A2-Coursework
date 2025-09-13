using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LakesideEscapesPodBooking
{
    internal class PodDescription
    {
        private string podType;
        private string podDescriptionString;
        private int maxOccupancy;
        private double costPerPersonPerNight;

        public PodDescription(string podType, string podDescription, int maxOccupancy, double costPerPersonPerNight)
        {
            this.CostPerPersonPerNight = costPerPersonPerNight;
            this.PodDescriptionString = podDescription;
            this.PodType = podType;
            this.MaxOccupancy = maxOccupancy;
        }

        public string PodType
        {
            get { return podType; }
            set { podType = value; }
        }
        public string PodDescriptionString
        {
            get { return podDescriptionString; }
            set { podDescriptionString = value; }
        }
        public int MaxOccupancy
        {
            get { return maxOccupancy; }
            set { maxOccupancy = value; }
        }
        public double CostPerPersonPerNight
        {
            get { return costPerPersonPerNight; }
            set { costPerPersonPerNight = value; }
        }

    }
}
