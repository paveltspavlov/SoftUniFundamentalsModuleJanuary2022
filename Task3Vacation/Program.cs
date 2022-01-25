namespace Task3Vacation
{
    using System;
    public class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double pricePerPerson = 0.00;
            double vacationCost = 0.00;
            double costWithoutDiscount = 0.00;

            if (groupType == "Students" && dayOfWeek == "Friday")
            {
                pricePerPerson = 8.45;
            }
            else if (groupType == "Students" && dayOfWeek == "Saturday")
            {
                pricePerPerson = 9.80;
            }
            else if (groupType == "Students" && dayOfWeek == "Sunday")
            {
                pricePerPerson = 10.46;
            }
            else if (groupType == "Business" && dayOfWeek == "Friday")
            {
                pricePerPerson = 10.90;
            }
            else if (groupType == "Business" && dayOfWeek == "Saturday")
            {
                pricePerPerson = 15.60;
            }
            else if (groupType == "Business" && dayOfWeek == "Sunday")
            {
                pricePerPerson = 16;
            }
            else if (groupType == "Regular" && dayOfWeek == "Friday")
            {
                pricePerPerson = 15;
            }
            else if (groupType == "Regular" && dayOfWeek == "Saturday")
            {
                pricePerPerson = 20;
            }
            else if (groupType == "Regular" && dayOfWeek == "Sunday")
            {
                pricePerPerson = 22.50;
            }

            costWithoutDiscount = pricePerPerson * numberOfPeople;

            if (groupType == "Students" && numberOfPeople >= 30)
            {
                vacationCost = costWithoutDiscount * 0.85;
            }
            else if (groupType == "Students" && numberOfPeople < 30)
            {
                vacationCost = costWithoutDiscount;
            }
            else if (groupType == "Business" && numberOfPeople >= 100)
            {
                vacationCost = costWithoutDiscount * 0.90;
            }
            else if (groupType == "Business" && numberOfPeople < 100)
            {
                vacationCost = costWithoutDiscount;
            }
            else if (groupType == "Regular" && numberOfPeople >= 10 && numberOfPeople <= 20)
            {
                vacationCost = costWithoutDiscount * 0.95;
            }
            else if (groupType == "Regular" && numberOfPeople > 20)
            {
                vacationCost = costWithoutDiscount;
            }
            else if (groupType == "Regular" && numberOfPeople < 10)
            {
                vacationCost = costWithoutDiscount;
            }

            Console.WriteLine($"Total price: {vacationCost:N2}");
        }
    }
}