using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = Add(2, 8);
            if (result > 10)
            {
                Console.WriteLine("result is larger than 10");
            } else
            {
                Console.WriteLine("result is smaller or equal to 10");
            }
            Console.ReadKey();
        }
        static int Add(int num01, int num02)
        {
            return num01 + num02;
        }
    }
}
