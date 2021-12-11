using CabInvoiceGenerator;
using NUnit.Framework;

namespace CabInvoiceGeneratorTest
{
    public class CabService
    {
        [Test]
        public void GivenDistanceAndTime_WhenACalculate_shoouldReturntotalFare()
        {
            InvoiceGenerator invoice = new InvoiceGenerator();
            double Expected = 52;
            double result = invoice.CalculateFare(5, 2);
            Assert.AreEqual(Expected, result);
        }
        [Test]
        public void GivenDistanceAndTime_MultipleRide_WhenACalculate_shoouldReturntotalFare()
        {
            InvoiceGenerator invoice = new InvoiceGenerator();
            Ride[] rides = { new Ride(5, 2), new Ride(7, 2) };
            double expected = 124;
            double result = invoice.CalculateMultipleRideFair(rides);
            Assert.AreEqual(result, expected);
        }
        [Test]
        public void GivenSummary_whenCalculate_ShouldReturnAverageFair()
        {
            InvoiceGenerator invoice = new InvoiceGenerator();
            Ride[] rides = { new Ride(5, 2), new Ride(7, 2) };
            InvoiceSummary result= invoice.CalculateInvoiceSummary(rides);
            InvoiceSummary summary = new InvoiceSummary();
            summary.totalFare = 124;
            summary.totalNumberOfRides = 2;
            summary.CalulateAverageFare();
            if(result.totalFare==summary.totalFare && result.totalNumberOfRides==summary.totalNumberOfRides && summary.averageFarePerRide == result.averageFarePerRide)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }
        }
    }
}