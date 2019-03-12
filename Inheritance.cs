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

            public void PrintBase()
            {
                Console.WriteLine("Name " + name);
                Console.WriteLine("Age " + age);
                Console.WriteLine("Happiness " + happiness);
            }
        }

        class Dog : Animal
        {
            public int spotCount;

            public void Bark()
            {
                Console.WriteLine("woof");
                base.happiness += 0.1f;
            }
        }

        class Cat : Animal
        {
            public float cuteness;

            public void Meow()
            {
                Console.WriteLine("meow");
            }
        }

        static void Main(string[] args)
        {
            Dog spotty = new Dog();
            spotty.name = "spotty";
            spotty.age = 4;
            spotty.happiness = 0.8f;
            spotty.spotCount = 25;
            spotty.PrintBase();
            spotty.Bark();
            Console.WriteLine("new happiness: " + spotty.happiness);

            Cat ezio = new Cat();
            ezio.name = "Ezio";
            ezio.age = 4;
            ezio.happiness = 0.5f;
            ezio.cuteness = 0.9f;
            ezio.PrintBase();
            ezio.Meow();

            Console.ReadKey();
        }
    }
}
