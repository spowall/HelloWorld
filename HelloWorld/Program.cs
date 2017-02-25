using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //print hello world 
            Console.WriteLine("What is your name");
            string input = Console.ReadLine();
            Console.WriteLine("You typed: " + input);

            Console.ReadLine();
        }
    }
}
