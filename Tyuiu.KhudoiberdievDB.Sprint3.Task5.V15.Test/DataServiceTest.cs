using Tyuiu.KhudoiberdievDB.Sprint3.Task5.V15.Lib;
namespace Tyuiu.KhudoiberdievDB.Sprint3.Task5.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckSumSum()
        {
            DataService ds = new DataService();
            int x = 5;
            int startValue1 = 1;
            int startValue2 = 1;
            int stopValue1 = 3;
            int stopValue2 = 10;


            double res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);
            double wait = 548.732;
            Assert.AreEqual(wait, res);
        }
    }
}