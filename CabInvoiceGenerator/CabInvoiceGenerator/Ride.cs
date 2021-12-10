using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class Ride
    {
        readonly public double DISTANCE;
        readonly public double TIME;
        public Ride(double RunningDistane, double RunningTime)
        {
            this.DISTANCE = RunningDistane;
            this.TIME = RunningTime;
        }
    }
}
