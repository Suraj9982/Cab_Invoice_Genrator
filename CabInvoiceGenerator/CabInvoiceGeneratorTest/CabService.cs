using CabInvoiceGenerator;
using NUnit.Framework;

namespace CabInvoiceGeneratorTest
{
    public class Testsgit 
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
            double expected = invoice.CalculateMultipleRideFair(rides);
            double result = invoice.CalculateMultipleRideFair(rides);
            Assert.AreEqual(result, expected);
        }
    }
}