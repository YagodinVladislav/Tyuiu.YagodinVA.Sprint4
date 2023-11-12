using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.YagodinVA.Sprint4.Task7.V17.Lib;
namespace Tyuiu.YagodinVA.Sprint4.Task7.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            string value = "753159864";
            int n = 3;
            int m = 3;
            int res = ds.Calculate(n, m, value);
            int wait = 3;
            Assert.AreEqual(wait, res);
        }
    }
}
