using System;
namespace DemoProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calc calc = new Calc();
            string print = calc.Check(10, 15).ToString();
            string print2 = calc.Check(10, 10).ToString();

            Console.WriteLine(print);
            Console.WriteLine(print2);
            Console.Read();
        }
    }
}
