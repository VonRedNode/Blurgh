using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinq
{
    internal class Program
    {
        enum Tiles
        {
            WATER = 0,
            SAND = 1,
            A = 2,
            B = 3
        }


        static void drawField(int[,] field)
        {
            for (int y = 0; y < field.GetLength(0); y++)
            {
                for (int x = 0; x < field.GetLength(1); x++)
                {
                    int value = field[y, x];
                    ConsoleColor foreGroundColor = ConsoleColor.Black;
                    char charToPrint = ' ';
                    
                    switch (value)
                    {
                        case (int)Tiles.WATER: foreGroundColor = ConsoleColor.Blue; charToPrint = '≈'; break;
                        case (int)Tiles.SAND: foreGroundColor = ConsoleColor.DarkYellow; charToPrint = '~'; break;
                        case (int)Tiles.A: foreGroundColor = ConsoleColor.Green; charToPrint = '☺'; break;
                        case (int)Tiles.B: foreGroundColor = ConsoleColor.Red; charToPrint = '☺'; break;
                    }

                    Console.ForegroundColor = foreGroundColor;
                    Console.Write(charToPrint);
                }
                Console.WriteLine();
            }
        }


        static void Main(string[] args)
        {
            int[,] field =
            {
                { 0,0,0,0,0,0,0,0,0,3 },
                { 0,0,0,0,0,0,0,0,0,0 },
                { 0,0,0,0,0,0,0,0,0,0 },
                { 0,0,0,0,0,0,0,0,0,0 },
                { 0,0,0,0,0,0,0,0,0,0 },
                { 1,1,1,1,1,1,1,1,1,1 },
                { 1,1,1,1,1,1,1,1,1,1 },
                { 1,1,1,1,1,1,1,1,1,1 },
                { 1,1,1,1,1,1,1,1,1,1 },
                { 2,1,1,1,1,1,1,1,1,1 },
            };

            Console.WriteLine(field);
            Console.WriteLine(field.GetLength(0));
            Console.WriteLine(field.GetLength(1));

            Console.WriteLine(field[0,0]);

            drawField(field);


            Console.Read();
        }
    }
}
