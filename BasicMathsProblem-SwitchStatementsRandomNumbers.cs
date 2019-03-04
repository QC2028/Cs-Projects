using System;


namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //challenge: make an application for users to solve maths problems
            //Random operationGenerator = new Random();
            //int operationRandomNumber = operationGenerator.Next(1, 5);
            //if (operationRandomNumber == 4)
            //{
            //    String operatorString = "multiplied by";
            //} else if (operationRandomNumber == 3)
            //{
            //    String operatorString = "divided by";
            //}
            //else if (operationRandomNumber == 2)
            //{
            //    String operatorString = "added to";
            //}
            //else
            //{
            //    String operatorString = "minus";
            //}

            Random numberGenerator = new Random();

            double num01;
            double num02;
            double num03;

            Console.Write("Choose a number: ");
            num01 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Choose another number: ");
            num02 = Convert.ToInt32(Console.ReadLine());

            Start:
            Console.Write("What is " + num01 + " + " + num02 + "?\n");
            num03 = Convert.ToInt32(Console.ReadLine());
            if (num03 == num01 + num02)
            {
                Console.WriteLine("That is correct!");
                Console.ReadKey();
            } else
            {
                int responseIndex = numberGenerator.Next(1, 4);

                switch (responseIndex)
                {
                    case 1:
                        Console.WriteLine("Thats incorrect, try again!");
                        break;
                    case 2:
                        Console.WriteLine("Are you even trying?");
                        break;
                    default:
                        Console.WriteLine("You can do better than that!");
                        break;
                }

                goto Start;
            }



            //Console.ReadKey();
        }
    }
}
