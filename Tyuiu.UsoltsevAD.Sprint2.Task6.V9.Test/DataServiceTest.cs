using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.UsoltsevAD.Sprint2.Task6.V9.Lib;
namespace Tyuiu.UsoltsevAD.Sprint2.Task6.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfNextDay()
        {
            DataService ds = new DataService();
            int m = 2;
            int n = 3;
            string res = ds.FindDateOfNextDay(m, n);
            string wait = "2.4";
            Assert.AreEqual(wait, res);
        }
    }
}
