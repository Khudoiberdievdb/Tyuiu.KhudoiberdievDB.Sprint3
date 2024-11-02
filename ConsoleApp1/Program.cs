namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 4; int b = 3;
            int c = 6;
            int d = 8;
            int i = 1; while (i < 5)
            {
                b++;
                b += a;
                c = b - a; 
                d = (c - a) + i;
                i++;
            }
            Console.WriteLine(d);
        }
    }
}
