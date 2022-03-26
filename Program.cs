using System;

namespace NewConsoleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = Multiply(2, 4);
            Console.WriteLine(total);
        }

        public static int Multiply(int multiplicand, int factor)
        {
            int result = 0;
            
            for (int i = 1; i <= Math.Abs(factor); i++)
            {
                result = result + multiplicand;
            }

            return result;
        }
    }
}
