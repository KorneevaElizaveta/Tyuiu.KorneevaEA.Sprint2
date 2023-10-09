using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KorneevaEA.Sprint2.Task4.V15.Lib;

namespace Tyuiu.KorneevaEA.Sprint2.Task4.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double x = 1;
            double y = 1;

            double z = ds.Calculate(x, y);
            double wait = 5;

            Assert.AreEqual(z, wait);
        }
    }
}
