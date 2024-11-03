using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KhudoiberdievDB.Sprint3.Task3.V15.Lib
{
    public class DataService : ISprint3Task3V15
    {
        public int GetMinCharCount(string value, char item)
        {
            int countletter = 0;
            foreach (char c in value)
            {
                if (c == item)
                {
                    countletter++;
                }
            }
            return countletter;
        }

    }
}
