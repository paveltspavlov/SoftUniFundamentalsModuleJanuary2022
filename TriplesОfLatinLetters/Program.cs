namespace TriplesОfLatinLetters
{
    using System;
        
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            char firstLetter = 'a';
           // a=97

            for (int i = 0; i < number; i++)
            {
                Console.Write(firstLetter);
                
                for (int j = 0; j < number; j++)
                {
                    Console.Write(firstLetter);
                    
                    for (int k = 0; k < number; k++)
                    {
                        Console.WriteLine(firstLetter);
                        k++;
                    }
                    j++;
                }
                i++;
            }
        }
    }
}