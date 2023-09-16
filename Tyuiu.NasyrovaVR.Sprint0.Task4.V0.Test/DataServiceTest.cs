using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.NasyrovaVR.Sprint0.Task4.V0.Lib;

namespace Tyuiu.NasyrovaVR.Sprint0.Task4.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedAdditionVaild()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }

        public void CheckedSubtractionVaild() 
        {
            Assert.AreEqual(5, DataService.Subtraction(10, 5));
        }

        public void CheckedMultiplicationVaild()
        {
            Assert.AreEqual(50, DataService.Multiplication(10, 5));
        }

        public void CheckedDivisionVaild()
        {
            Assert.AreEqual(3, DataService.Division(9, 3));
        }
    }
}
