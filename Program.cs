using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int j = 5;
            j = 10;
            Console.WriteLine("Hello World!");
            string name = Console.ReadLine();
            
            string name2 = Console.ReadLine();
            Console.WriteLine("Welcome {1},{0}", name, name2);
            Console.WriteLine("Welcome "+name+" ,"+name2);
            Console.ReadLine();

        }
    }
}
