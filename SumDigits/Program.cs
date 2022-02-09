using System;

namespace SumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            //string numbersArray = Convert.ToString(number);
            int result = 0;
            char[] numbers = number.ToCharArray(0,number.Length);

            foreach (char ch in numbers)
            {
                result = +ch;
                Console.WriteLine(ch);
            }
            
            for (int i = 0; i < numbers.Length; i++)
            {
                int buff = Convert.ToInt32(numbers[i]);
                result =+ buff;
            }
            Console.WriteLine(result);
        }
    }
}
