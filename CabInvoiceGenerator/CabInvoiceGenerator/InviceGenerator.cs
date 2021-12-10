using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class InviceGenerator
    {
        readonly private double MIN_FARE = 5.0;
        readonly private double DISTANCE;
        readonly private  double TIME;
        readonly private double COST_PER_KM = 10.0;
        readonly private double COST_PER_MINUTE = 1.0;
        public InviceGenerator(double RunningDistane,double RunningTime)
        {
            this.DISTANCE = RunningDistane;
            this.TIME = RunningTime;
        }
        public double CalculateFare()
        {
            double TotalFare = (DISTANCE * COST_PER_KM) + (TIME * COST_PER_MINUTE);
            if (TotalFare < MIN_FARE)
            {
                return MIN_FARE;
            }
            else
            {
                return TotalFare;
            }
        }

    }

}
