using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {


            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }


            Console.ReadKey();
        }
    }
}
