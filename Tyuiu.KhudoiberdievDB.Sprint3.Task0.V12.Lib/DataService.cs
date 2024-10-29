using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KhudoiberdievDB.Sprint3.Task0.V12.Lib
{
    public class DataService : ISprint3Task0V12
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double MulSeries0 = 0;
            double MulSeries1 = 1.0;
            double i;
            for (i = startValue; i <= stopValue; i++)
            {
                MulSeries0 = (Math.Pow(value, i)) + ((1 / (i + 1)));
                MulSeries1 *= MulSeries0;


            }
            return Math.Round(MulSeries1, 3);
        }
    }
}
