using Tyuiu.KhudoiberdievDB.Sprint3.Task2.V21.Lib;
namespace Tyuiu.KhudoiberdievDB.Sprint3.Task2.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckValidSumSeries()
        {
            DataService ds  = new DataService();
            int startValue = 1;
            int stopValue = 10;
            double value = 1.5;
            double wait = 0.298;
            var res = ds.GetSumSeries(value, startValue, stopValue);
            Assert.AreEqual(wait, res);

        }
    }
}