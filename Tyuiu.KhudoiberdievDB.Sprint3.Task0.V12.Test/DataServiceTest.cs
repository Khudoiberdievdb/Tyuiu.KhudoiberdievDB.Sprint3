using System.Transactions;
using Tyuiu.KhudoiberdievDB.Sprint3.Task0.V12.Lib;
namespace Tyuiu.KhudoiberdievDB.Sprint3.Task0.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMulSeries()
        {
            DataService ds = new DataService();
            int value = 1;
            int startValue = 1;
            int stopValue = 13;
            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            double wait = 7.5;
            Assert.AreEqual(res, wait);
        }
    }
}
