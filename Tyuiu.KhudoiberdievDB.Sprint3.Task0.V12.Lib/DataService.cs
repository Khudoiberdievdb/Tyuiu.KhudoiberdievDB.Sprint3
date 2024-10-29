using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KhudoiberdievDB.Sprint3.Task0.V12.Lib
{
    public class DataService : ISprint3Task0V12
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double MulSeries = 1;
            int i;
            for (i = startValue; i <= stopValue; i++)
            {
                MulSeries = MulSeries* (Math.Pow(value, i) + (1 / (i + 1)));
            }
            return Math.Round(MulSeries, 3);
        }
    }
}
