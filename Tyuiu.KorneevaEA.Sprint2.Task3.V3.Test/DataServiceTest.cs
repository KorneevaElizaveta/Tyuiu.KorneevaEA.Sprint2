using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KorneevaEA.Sprint2.Task3.V30.Lib;

namespace Tyuiu.KorneevaEA.Sprint2.Task3.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);

            double wait = 0.167;
            Assert.AreEqual(wait, res);
        }
    }
}