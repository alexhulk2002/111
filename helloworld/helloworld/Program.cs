using System;

namespace helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("boss");
            int a = 2;
            int b = 3;
            Console.WriteLine(a + b);
            double c = 1.5;

            Console.WriteLine(Convert.ToString(c));
            string x = Console.ReadLine();
            Console.WriteLine(x);
            string result=(c>2) ? "yes" : "no";
            Console.WriteLine(result);
            string[] name = { "in", "vff", "rfvr" };
            foreach(string i in name)
            { Console.WriteLine(i); }
        }
    }
}
