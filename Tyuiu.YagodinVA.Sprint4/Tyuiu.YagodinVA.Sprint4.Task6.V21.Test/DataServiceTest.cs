using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.YagodinVA.Sprint4.Task6.V21.Lib;
namespace Tyuiu.YagodinVA.Sprint4.Task6.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            string[] names = new string[] { "Facebook", "Twitter", "Instagram", "Snapchat", "LinkedIn", "Pinterest", "Reddit" };
            int res = ds.Calculate(names);
            int wait = 2;
            Assert.AreEqual(res, wait);
        }
    }
}
