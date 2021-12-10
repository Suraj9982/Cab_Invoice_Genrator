using CabInvoiceGenerator;
using NUnit.Framework;

namespace CabInvoiceGeneratorTest
{
    public class Tests
    {
        [Test]
        public void GivenDistanceAndTime_WhenACalculate_shoouldReturntotalFare()
        {
            InviceGenerator invoice = new InviceGenerator(5, 2);
            double result = invoice.CalculateFare();
            Assert.AreEqual(result, 52);

        }
}
}