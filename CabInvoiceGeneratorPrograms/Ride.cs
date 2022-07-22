using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGeneratorPrograms
{
    public class Ride
    {
        public int time;
        public double distance;

        //Constructor for initializing distance and time for every ride
        public Ride(int time, double distance)
        {
            this.time = time;
            this.distance = distance;
        }
    }
}
