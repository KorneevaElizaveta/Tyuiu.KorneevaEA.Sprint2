using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KorneevaEA.Sprint2.Task6.V15.Lib;

namespace Tyuiu.KorneevaEA.Sprint2.Task6.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDayName()
        {
            DataService ds = new DataService();

            Assert.AreEqual("Понедельник", ds.FindDayName(1));

            Assert.ThrowsException<ArgumentException>(() =>
            {
               ds.FindDayName(0);
            });
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDayName(366);
            });
        }
    }
}
