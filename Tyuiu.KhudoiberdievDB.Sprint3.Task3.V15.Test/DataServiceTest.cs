using Tyuiu.KhudoiberdievDB.Sprint3.Task3.V15.Lib;
namespace Tyuiu.KhudoiberdievDB.Sprint3.Task3.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCharCount()
        {
            DataService ds = new DataService();
            string str = "lrmmse mg sermmmrt";
            char chr = 'm';
            int res = ds.GetMinCharCount(str, chr);
            int wait = 1;
            Assert.AreEqual(res, wait);
        }
    }
}