using System;

namespace UnrealProject
{
    class Program
    {
        public static void GreetBlack()
        {
            Console.WriteLine("hello black");
        }
        public static void GreetWhite()
        {
            Console.WriteLine("hello white");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("hello everyone");
            GreetBlack();
            GreetWhite();
        }
    }
}
