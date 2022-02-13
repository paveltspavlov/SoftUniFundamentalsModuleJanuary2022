using System;

namespace SumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int result = 0;
            char[] charArr = number.ToCharArray();  

            for (int i = 0; i < charArr.Length; i++)
            {
                result += int.Parse(charArr[i].ToString());
            }
            Console.WriteLine(result);
        }
    }
}