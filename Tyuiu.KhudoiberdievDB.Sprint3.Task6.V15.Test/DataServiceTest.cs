using Tyuiu.KhudoiberdievDB.Sprint3.Task6.V15.Lib;
namespace Tyuiu.KhudoiberdievDB.Sprint3.Task6.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheck()
        {
            DataService ds  = new DataService();
            int startValue = 6;
            int stopValue = 15;
            int res = ds.GetSumTheDivisors(startValue, stopValue);
            int wait = 168;
            Assert.AreEqual(res, wait);

        }
    }
}