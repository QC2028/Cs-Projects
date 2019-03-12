using System;

namespace ConsoleApp4
{
    class Program
    {
        class Animal
        {
            public string name;
            public int age;
            public float happiness;

        }

        class Dog : Animal
        {
            public void Print()
            {
                Console.WriteLine("name: " + name);
                Console.WriteLine("age: " + age);
                Console.WriteLine("happiness: " + happiness);
            }
        }

        static void Main(string[] args)
        {

            Console.ReadKey();
        }
    }
}
