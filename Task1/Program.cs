using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your age");
            int age = Console.ReadLine();

            Console.WriteLine($"Your name is {name} and age is {age}");

        }


    }
}
