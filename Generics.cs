using System;

namespace ConsoleApp6
{
    class Program
    {      
        static void Main(string[] args)
        {
            //KeyValuePair<string, int> meaning = new KeyValuePair<string, int>("Life", 42);
            //meaning.Print();

            //Console.ReadKey();

            //Dictionary<string, int> prices = new Dictionary<string, int>(5);
            //prices.Add("Watermelon", 5);
            //prices.Add("car", 1000000);
            //Console.WriteLine(prices["Watermelon"]);

            Console.WriteLine(Utility.CompareValues(10, 3));



            Console.ReadKey();
        }
    }

    class Utility
    {
        public static bool CompareValues<T01, T02> (T01 value01, T02 value02)
        {
            return value01.Equals(value02);
        }
    }


    //class KeyValuePair<TKey, TValue>
    //{
    //    public TKey key;
    //    public TValue value;

    //    public KeyValuePair(TKey _key, TValue _value)
    //    {
    //        key = _key;
    //        value = _value;
    //    }

    //    public void Print()
    //    {
    //        Console.WriteLine("Key: " + key.ToString());
    //        Console.WriteLine("Value: " + value.ToString());
    //    }
    //}
}
