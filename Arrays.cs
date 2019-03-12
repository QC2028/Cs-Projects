using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = new int[5];
            //numbers[0] = 12;
            //numbers[1] = 3;
            //numbers[2] = 5;



            //foreach (int number in numbers)
            //{
            //    console.write(number + ", ");
            //}

            //string[] names = new string[3]
            //{
            //    "Tom", "Mark","Matt"
            //};
            //foreach (string name in names)
            //{
            //    Console.Write(name + ", ");
            //}


            //lists - use a list when you dont know how many items you are dealing with

            //List<int> numbers = new List<int> ();

            //numbers.Add(13);
            //numbers.Add(4);
            //numbers.Add(8);

            //for (int i = 0; i < numbers.Count; i++) //use count instead of length for lists
            //{
            //    Console.Write(numbers[i] + ", ");
            //}

            //Console.WriteLine();

            //numbers.RemoveAt(1);

            //for (int i = 0; i < numbers.Count; i++) //use count instead of length for lists
            //{
            //    Console.Write(numbers[i] + ", ");
            //}

            //multidimentional arrays
            CreateGrid();


            Console.ReadKey();
        }

        static void CreateGrid()
        {
            int width = 5;
            int height = 5;

            //int[,] grid = new int[5, 5];
            //grid[2, 3] = 5;

            //for (int x = 0; x < width; x++)
            //{
            //    for (int y = 0; y < height; y++)
            //    {
            //        Console.Write(grid[x, y] + " ");
            //    }
            //    Console.WriteLine();

            //jagged arrays
            int[][] grid = new int[width][height];                     

        }
    }
}
