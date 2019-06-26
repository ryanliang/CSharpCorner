using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var bar1 = new Bar("bar1");
            Console.WriteLine(bar1.ToString());
            Console.ReadLine();
        }
    }
}
