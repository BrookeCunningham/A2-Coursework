using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LakesideEscapesPodBooking
{
    internal class Pod
    {
        private int podID;
        private string podType;

        public Pod(string podType)
        {
            this.podType = podType;
        }

        public string PodType 
        {
            get { return podType; }
            set { podType = value; }        
        }
        public int PodID
        {
            get { return podID; }
            set { podID = value; }
        }
    }
}
