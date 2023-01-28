using System;

namespace CSharp_Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                // Menu
                Console.WriteLine("");
                Console.WriteLine("------------Calculator------------");
                Calculator calculator = new Calculator();
                calculator.Menu();
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
