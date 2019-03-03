using System;

namespace FirstConsoleProject
{
    class MainClass
    {
        static void Main(string[] args)  //this it the method called 'Main'. It's called when the program starts.
        {
            //var num01 = 10;  this is 'implicit variable declaration', meaning that the code assumes what form the data is in, in this case an integer 'int'
            //int num01; //variable declared
            //num01 = 20; //variable initialised
            //float decimalpoint = 10.1; float is a decimal value
            //double decimalpoint = 10.111; like a float but with more precision
            //bool bool1 = true; //boolean - true or false
            //string sentence = "Hello world";

            int num01;
            int num02;

            Console.Write("Type a number to be multiplied: ");
            num01 = Convert.ToInt32 (Console.ReadLine ());
            Console.Write("Type another number: ");
            num02 = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("The Result is " + num01 * num02);
            //ReadKey();

            //challenge - make a calculator for division

            Console.Write("Type a number to be divided: ");
            num01 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Type another number: ");
            num02 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The result is " + num01 / num02);
            Console.ReadKey();

            
        }
    }
}
