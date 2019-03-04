using System;


namespace ConsoleProject
{
    class MainClass
    {
        static void Main(string[] args)
        {
            //age confirmation message
            Console.WriteLine("How old are you? ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age < 18) //this is the criteria for the if statement
            {
                Console.WriteLine("That's too bad! you will have to wait a couple of years."); //this is what is called when the criteria is met for the if statement
            } else if (age == 18) //this is called if the criteria is not met, and then sets ANOTHER criteia to be met
            {
                Console.WriteLine("Barely made it!");
            } else 
            {
                Console.WriteLine("You are allowed to enter."); //this is called if the OTHER criteria cannot be met
            }
            Console.ReadKey();

        }
    }
}
