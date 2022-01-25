using System;

namespace Task4PrintAndSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int SecondNumber = int.Parse(Console.ReadLine());
            int sum=0;

            do
            {

                Console.Write($"{firstNumber} ");
                
                sum += firstNumber;

                firstNumber += 1;
            } while (firstNumber <= SecondNumber) ;
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
