using System;
using System.ComponentModel;

namespace FastConApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string fastNumStr = Console.ReadLine();
            int fast = Convert.ToInt32(fastNumStr);
            string secondNumStr = Console.ReadLine();
            int second = Convert.ToInt32(secondNumStr);

            int total = Add(fast, second);
            Console.WriteLine(total);

            int sub = Subtract(fast, second);

            Console.WriteLine(sub);
            
            //int result = fast + second;
            //Console.WriteLine(result);

            Console.ReadKey();
        }

        public static int Add(int fast, int second)
        {
            return fast + second;
        }

        public static int Subtract(int fast, int second)
        {
            return fast - second;
        }
    }

}
