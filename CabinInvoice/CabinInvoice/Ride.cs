using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceGenerator
{
    public class Ride
    {
        public double distance;
        public int time;
        public int userID;
        private int v1;
        private int v2;

        public Ride(int v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public Ride(double distance, int time, int userID)
        {
            this.distance = distance;
            this.time = time;
            this.userID = userID;
        }
    }
}