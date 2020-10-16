using System;
namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string myname;
            Console.Write("Please enter your name: ");
            myname = Console.ReadLine();
            Console.WriteLine($"Your name starts with letter {myname[0]}");
        }
    }
}







