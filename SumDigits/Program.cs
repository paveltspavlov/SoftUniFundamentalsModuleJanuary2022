using System;

namespace SumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
          //  string[] numbersArray = new string[number.Length];
            int result = 0;
           // char[] charsArray = new char[numbersArray.Length];

            char[] charArr = number.ToCharArray();  
            foreach (char ch in charArr)  
            {  
                Console.WriteLine(ch);  
            }   

            for (int i = 0; i < charArr.Length; i++)
            {
                Console.WriteLine(charArr[i]);
                
                result +=charArr[i];
                
            }
            Console.WriteLine(result);
        }
    }
}
