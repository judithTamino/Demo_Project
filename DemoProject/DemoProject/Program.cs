using System;
namespace DemoProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calc calc = new Calc();
            string print = calc.Check(15, 15).ToString();
            string print2 = calc.Check(15, 5).ToString();

            Console.WriteLine(print);
           
      
            Console.Read();
        }
    }
}
