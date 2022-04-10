using static System.Console;

namespace ArrayDemo1
{
    class ArrayDemo1
    {
        static void Main()
        {
            double[] payrate = { 13.00, 17.35, 19.12, 22.45 };

            for (int x = 0; x < payrate.Length; ++x)
                WriteLine("Pay rate {0} is {1}",
                    x, payrate[x].ToString("C"));


        }
    }
}
