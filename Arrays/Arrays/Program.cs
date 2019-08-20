using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare 2D array
            string[,] matrix;

            //declare 3D array
            string[,,] threeD;

            //two dimensional array
            int[,] array2D = new int[,]
            {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };

            Console.WriteLine("Central Value is {0}", array2D[1,1]);

            string[,,] array3D = new string[,,]
            {
                {
                    {"a","ab" },
                    {"b","ba" }
                },
                {
                    {"c", "cd" },
                    {"d", "dc" }
                }
            };

            Console.WriteLine("Central value is {0}", array3D[1,1,0]);

        }
    }
}
