using System;

namespace Task7VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            var coin = Console.ReadLine();
            double sum = 0.00;
            while (coin != "Start")
            {
                switch (coin)
                {
                    case "0.1":
                        sum += 0.1;
                        break;
                    case "0.2":
                        sum += 0.2;
                        break;
                    case "0.5":
                        sum += 0.5;
                        break;
                    case "1":
                        sum += 1;
                        break;
                    case "2":
                        sum += 2;
                        break;
                    default:
                        Console.WriteLine($"Cannot accept {coin}");
                        break;
                }
                coin = Console.ReadLine();
            }
            var product = Console.ReadLine();
            while (product != "End")
            {
                switch (product)
                {
                    case "Nuts":
                        if (sum >= 2.0)
                        {
                            sum -= 2.0;
                            Console.WriteLine($"Purchased {product.ToLower()}");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Water":
                        if (sum >= 0.7)
                        {
                            sum -= 0.7;
                            Console.WriteLine($"Purchased {product.ToLower()}");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Crisps":
                        if (sum >= 1.5)
                        {
                            sum -= 1.5;
                            Console.WriteLine($"Purchased {product.ToLower()}");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Soda":
                        if (sum >= 0.8)
                        {
                            sum -= 0.8;
                            Console.WriteLine($"Purchased {product.ToLower()}");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Coke":
                        if (sum >= 1.0)
                        {
                            sum -= 1.0;
                            Console.WriteLine($"Purchased {product.ToLower()}");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
                product = Console.ReadLine();
            }
            Console.WriteLine($"Change: {sum:f2}");
        }
    }

}
