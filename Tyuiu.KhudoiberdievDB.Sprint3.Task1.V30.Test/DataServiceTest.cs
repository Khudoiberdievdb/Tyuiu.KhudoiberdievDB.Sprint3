using Tyuiu.KhudoiberdievDB.Sprint3.Task1.V30.Lib;
namespace Tyuiu.KhudoiberdievDB.Sprint3.Task1.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckValidSum()
        {
            DataService ds = new DataService();
            Assert.IsNotNull(ds);
            int startValue = 1;
            int stopValue = 12;
            double value = 0.5;
            double wait = 0.9587340299577701;
            var res = ds.GetSumSeries(value, startValue, stopValue);
            Assert.AreEqual(wait, res);
        }
    }
}