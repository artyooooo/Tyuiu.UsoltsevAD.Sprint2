using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.UsoltsevAD.Sprint2.Task3.V14.Lib;
namespace Tyuiu.UsoltsevAD.Sprint2.Task3.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double x = 2;
            double res = ds.Calculate(x);
            double wait = -25;
            Assert.AreEqual(wait, res);
        }
    }
}
