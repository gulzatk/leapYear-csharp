using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calendar;

namespace Calendar.Tests
{
    [TestClass]
    public class LeapYearTest
    {
        [TestMethod]
        public void IsLeapYear_NumberDivisibleByFour_True()
        {
            LeapYear testLeapYear = new LeapYear();
            Assert.AreEqual(true, testLeapYear.isLeapYear(2012));
        }
        [TestMethod]
        public void IsLeapYear_NumberNotDivisibleByFour_False()
        {
            LeapYear testLeapYear = new LeapYear();
            Assert.AreEqual(false, testLeapYear.isLeapYear(1999));
        }
        [TestMethod]
        public void IsLeapYear_MultiplesOfOneHundred_False()
        {
            LeapYear testLeapYear = new LeapYear();
            Assert.AreEqual(false, testLeapYear.isLeapYear(1900));
        }
        [TestMethod]
        public void IsLeapYear_MultiplesOfOneHundred_True()
        {
            LeapYear testLeapYear = new LeapYear();
            Assert.AreEqual(true, testLeapYear.isLeapYear(2000));
        }
    }
}