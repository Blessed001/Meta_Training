using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //Printing list elements by foreach
            foreach(int i in Array)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            //Printing list elments by for
            for(int i = 0; i<Array.Length; i++)
            {
                Array[i] *= 2;
                Console.WriteLine(Array[i]);
            }
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            //Printig array in order by ij
            int[,] Arrays = { { 1, 2, 5, 6 }, { 3, 4, 6, 8 }, { 5, 6, 7, 8 } };

            int rows = Arrays.GetUpperBound(0) + 1;
            int columns = Arrays.Length / rows;

            for(int i= 0; i < rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    Console.Write($"{Arrays[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            //Oders arrays  
            int[][] NewArray = new int[6][]
            {
                new int[]  { 1, 2, 3 },
                new int[]  { 5, 6, 7, 8 },
                new int[]  { 8, 7, 6, 5, 0 },
                new int[]  { 8, 7, 6, 5, 4, 6 },
                new int[]  { 8, 7, 6, 5, 4, 7, 1},
                new int[]  { 8, 7, 6, 5, 3, 4, 5, 6}
            };

            //Printing by for
            for(int i = 0; i < NewArray.Length; i++)
            {
                for(int j = 0; j < NewArray[i].Length; j++)
                {
                    Console.Write($"{NewArray[i][j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            //Pinting by foreach
            foreach (int [] i in NewArray)
            {
                foreach(int j in i)
                {
                    Console.Write($"{j} \t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
