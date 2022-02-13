namespace PrintAsciiTable
{
    using System;
        
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int finish = int.Parse(Console.ReadLine());
            char output;
            do
            {
                output = Convert.ToChar(start);
                Console.Write($"{output} ");
                start++;
            } while (start <= finish);
        }
    }
}