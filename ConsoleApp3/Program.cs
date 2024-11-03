namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "l2ss 4il 45ps";
            foreach (char c in str)
            {
                if (Char.IsDigit(c))
                {
                    str = str.Replace(c, 'o');
                }

            }
            Console.WriteLine(str);


        }
    }
}