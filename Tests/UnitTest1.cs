using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit;
using NUnit.Framework;

namespace Tests
{
    public class UnitTest1
    {
        [Test]
        [TestCase(1,"Styczeń")]
        [TestCase(2, "Luty")]
        [TestCase(3, "Marzec")]
        [TestCase(4, "Kwiecień")]
        [TestCase(5, "Maj")]
        [TestCase(6, "Czerwiec")]
        [TestCase(7, "Lipiec")]
        [TestCase(8, "Sierpień")]
        [TestCase(9, "Wrzesień")]
        [TestCase(10, "Październik")]
        [TestCase(11, "Listopad")]
        [TestCase(12, "Grudzień")]
        public void ShouldReturnCorrectMonthName(int month, string MonthName)
        {
            //G
            DateTime date = new DateTime(DateTime.Now.Year, month, 1);
            //W
            string name = aquadrom.Utilities.DateConvertor.MonthName(date);
            //T
            Assert.AreEqual(name, MonthName);
        }

        [Test]
        [TestCase(1,"Styczeń")]
        [TestCase(2, "Luty")]
        [TestCase(3, "Marzec")]
        [TestCase(4, "Kwiecień")]
        [TestCase(5, "Maj")]
        [TestCase(6, "Czerwiec")]
        [TestCase(7, "Lipiec")]
        [TestCase(8, "Sierpień")]
        [TestCase(9, "Wrzesień")]
        [TestCase(10, "Październik")]
        [TestCase(11, "Listopad")]
        [TestCase(12, "Grudzień")]
        public void ShouldReturnCorrectMonthNumber(int MonthNumber,string MonthName)
        {
            //g
            //w
            int number = aquadrom.Utilities.DateConvertor.GetMonthNumber(MonthName);
            //t
            Assert.AreEqual(MonthNumber, number);
        }
    }
   
}
