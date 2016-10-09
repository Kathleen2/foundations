using System;


namespace HelloWashington
{
    class HelloWashington
    {
        static void Main()
        {
            Console.WriteLine("Hello, I live in Olympia.");
            Console.WriteLine("Where do you live?");
            Console.WriteLine("My name is Toshiba. What's your name?");
            string Input = Console.ReadLine();
            Console.WriteLine("Hi " + Input + "! It's nice to meet you.");
            Console.ReadLine();
        }
    }
}
