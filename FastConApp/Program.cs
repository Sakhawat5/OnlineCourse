using System;
using System.ComponentModel;

namespace FastConApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the fast input:");
            string fastNumStr = Console.ReadLine();
            int fast = Convert.ToInt32(fastNumStr);
            Console.WriteLine("Enter the second input:");
            string secondNumStr = Console.ReadLine();
            int second = Convert.ToInt32(secondNumStr);

            int total = Calculate.Add(fast, second);
            
            Console.WriteLine("Addition : "+total);

            int sub = Calculate.Subtract(fast, second);

            Console.WriteLine("subtraction : " + sub);
            
            //int result = fast + second;
            //Console.WriteLine(result);

            Console.ReadKey();
        }
    }

}
