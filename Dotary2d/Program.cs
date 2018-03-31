using System;

namespace Dotary2d
{
    class Dotary2d
    {
        static void Main(string[] args)
        {
            int[][] letterA = 
            {
                new[] {0, 0, 1, 1, 0, 0},
                new[] {0, 1, 0, 0, 1, 0},
                new[] {1, 0, 0, 0, 0, 1},
                new[] {1, 1, 1, 1, 1, 1},
                new[] {1, 0, 0, 0, 0, 1},
                new[] {1, 0, 0, 0, 0, 1}
            };


            foreach (int[] line in letterA)
            {
                foreach (int dot in line)
                {
                    if (dot == 1)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
