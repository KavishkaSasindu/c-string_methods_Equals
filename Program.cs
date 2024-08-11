using System;

namespace MyApp2
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.Write("Enter your name :");
            string name = Console.ReadLine();

            if (name.Equals("Kavishka Sasindu"))
            {
                Console.WriteLine($"Hello {name}");
            }
            else
            {
                Console.WriteLine("You are not Kavishka Sasindu");
            }

            string message = "Hello Kavishka";

            for (int i = 0; i < message.Length; i++)
            {
                Console.WriteLine(message[i]);
            }
        }
    }
}