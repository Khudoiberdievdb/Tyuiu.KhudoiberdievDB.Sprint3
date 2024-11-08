using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KhudoiberdievDB.Sprint3.Task7.V4.Lib
{
    public class DataService : ISprint3Task7V4
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int i = startValue; i <=  stopValue; i++)
            {
                y = Math.Round((((2 * (i) + 6) / (Math.Cos(i) + (i))) - 3), 2);
                valueArray[count] = y;
                count++;
            }
            return valueArray;
        }
    }
}
