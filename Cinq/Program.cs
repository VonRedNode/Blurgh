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
            drawField(field);

            double speedInSand = 5.0;
            double speedInWater = 2.5;

            double submergingLine = 50.0;
            double b = 50.0;
            double e = 50.0;

            double shortestTime = 0.0;
            double shortestPath = 0.0;
            
            
            while(submergingLine <= 100)  
            {
                double a = submergingLine;
                double d = 100.0 - submergingLine;

                double distanceToRun = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
                double distanceToSwim = Math.Sqrt(Math.Pow(d, 2) + Math.Pow(e, 2));
                double distanceTotal = distanceToRun + distanceToSwim;

                double timeToRun = distanceToSubmergingLine/speedInSand;
                double timeToSwim = distanceToDrowningDwarf/speedInWater;
                double timeTotal = timeToRun + timeToSwim;


                if(timeTotal > shortestTime) 
                {
                    shortestTime = timeTotal
                    shortestPath = distanceTotal
                }

                submergingLine += 0.01;
            }


            Console.WriteLine("Congrats, you decided to save the poor dwarf drowning");
            Console.WriteLine($"It took you a total of \t{shortestTime} seconds");
            Console.WriteLine($"It took you \t{shortestPath} meters");

            Console.Read();
            /*
            double sandC = Math.Sqrt(Math.Pow(sandA,2) + Math.Pow(sandB,2))
            double waterC =  Math.Sqrt(Math.Pow(sandA,2) + Math.Pow(sandB,2))

            double secondsTakenForSand = sandC/speedInSand
            double secondsTakenForWater = waterC/speedInWater
            double secondsTakenTotal = secondsTakenForSand + secondsTakenForWater


            Console.WriteLine("Congrats, you decided to save the poor dwarf drowning")
            Console.WriteLine($"It took you a total of \t{secondsTakenTotal} seconds")
            Console.WriteLine($"It took you \t{secondsTakenForSand} seconds in sand")
            Console.WriteLine($"It took you \t{secondsTakenForWater} seconds in water")
            */
        }
    }
}