using System;

namespace Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int trips;
            int remainingPassangers = people % capacity;

            if (people > capacity)
            {
                if (remainingPassangers != 0)
                {
                    trips = people / capacity+ 1;
                }
                else
                {
                    trips = people / capacity;
                }
            }
            else
            {
                
                trips = 1;
            }
            
            Console.WriteLine(trips);
        }
    }
}