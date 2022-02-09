using System;

namespace IntegerOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = Int32.Parse(Console.ReadLine());
            int num2 = Int32.Parse(Console.ReadLine());
            int num3 = Int32.Parse(Console.ReadLine());
            int num4 = Int32.Parse(Console.ReadLine());

            int res1 = num1 + num2;
            int res2 = res1 / num3;
            int res3 = res2 * num4;
            Console.WriteLine(res3);
        }
    }
}
