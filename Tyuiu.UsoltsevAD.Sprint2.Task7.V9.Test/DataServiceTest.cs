using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.UsoltsevAD.Sprint2.Task7.V9.Lib;
namespace Tyuiu.UsoltsevAD.Sprint2.Task7.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            double x = Math.PI / 2;
            double y = 0.75;
            bool wait = true;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
