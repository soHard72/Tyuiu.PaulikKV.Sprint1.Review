using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PaulikKV.Sprint1.TaskReview.V20.Lib;

namespace Tyuiu.PaulikKV.Sprint1.TaskReview.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 3;
            double wait = 9.751;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
