using System;

namespace Task5Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String username = Console.ReadLine();

            String encryptedPassword = "";
            int length = username.Length - 1;
            while (length >= 0)
            {
                encryptedPassword += username[length];
                length--;
            }

            for(int counter=0; counter < 4; counter++) {
                
                string password = Console.ReadLine();
                if (counter == 3)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }

                ;

                 if (password == encryptedPassword)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                else if (password != encryptedPassword)
                {
                    Console.WriteLine("Incorrect password. Try again.");

                }


            };
        }
    }
}
