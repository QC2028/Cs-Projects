using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {

            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            Random numberGenerator = new Random();

            int numberOfAttempts = 0;
            int attempt = 0;
            while (attempt != 6)
            {
                attempt = numberGenerator.Next(1, 7);
                Console.WriteLine("Tom rolled " + attempt + ".");
                numberOfAttempts++;
            }

            //this is a while loop, which checks the condition before running the loop, however a do while loop does the 'do' first, and then if the condition still holds, runs the 'do' again

            //do while loop:
            //do
            //{

            //} while (condition);

            Console.WriteLine("It took " + numberOfAttempts + " attempts to roll a six.");



            Console.ReadKey();
        }
    }
}
