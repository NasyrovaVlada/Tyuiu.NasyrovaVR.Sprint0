using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.NasyrovaVR.Sprint0.Task2.V0.Lib;

namespace Tyuiu.NasyrovaVR.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageVaild()
        {
            var name = "Влада";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет..., Влада", res);
        }
    }
}
