using System;

namespace ConsoleApp4
{
    class Animal
    {
        //class variables
        public static int Count = 0;

        public string name = "spotty";
        public int age = 6;
        public float happiness = 0.5f;

        //class constructors

        public Animal()
        {
            name = "spotty";
            age = 6;
            happiness = 0.5f;

            Count++;
        }

        public Animal (string _name, int _age, float _happiness)
        {
            name = _name;
            age = _age;
            happiness = _happiness;

            Count++;
        }

        //class methods

        public void Print()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Happiness: " + happiness);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Animal();
            dog.Print();
            Console.WriteLine();

            Animal cat = new Animal("Mr Beans", 10, 0.8f);
            cat.Print();
            Console.WriteLine();
            Console.WriteLine("num of animals: " + Animal.Count);


            Console.ReadKey();
        }
    }
}
