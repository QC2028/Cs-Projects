using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            numbers[0] = 12;
            numbers[1] = 3;
            numbers[2] = 5;

            Console.WriteLine(numbers[1]);

            Console.ReadKey();
        }
    }
}
