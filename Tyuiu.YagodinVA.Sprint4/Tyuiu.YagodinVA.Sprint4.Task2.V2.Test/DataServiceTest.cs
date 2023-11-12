using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.YagodinVA.Sprint4.Task2.V2.Lib;
namespace Tyuiu.YagodinVA.Sprint4.Task2.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] array = new int[] { 1, 7, 2, 4, 5, 8, 2, 1, 5, 1, 3 };
            int res = ds.Calculate(array);
            int wait = 525;
            Assert.AreEqual(wait, res);
        }
    }
}
