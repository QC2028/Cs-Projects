using System;

namespace ConsoleApp5
{
    class Program
    {
        class Player
        {
            private int _health = 100;
            public int health
            {
                get
                {
                    return _health;
                }
                set
                {
                    if (value <= 0)
                    {
                        _health = 0;
                    } else if (value >= 100)
                    {
                        _health = 100;
                    } else
                    {
                        _health = value;
                    }
                }
            }

            public void Damage (int _dmg)
            {
                _health -= _dmg;
            }
        }
        static void Main(string[] args)
        {
            //properties
            Player tom = new Player();
            tom.Damage(75);
            Console.WriteLine(tom.health);

            Console.ReadKey();
        }
    }
}
