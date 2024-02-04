using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Deux
{
    internal class Program
    {


        static void Main(string[] args)
        {
            while (true)
            {
                int potentialPrime = askForInt("Hey! give me number you believe to be prime: ");

                if (isAPrime(potentialPrime)) 
                {
                    Console.WriteLine("Thank you...");
                    
                } else
                {
                    Console.WriteLine("...");
                }

                Thread.Sleep(1000);
                Console.Clear();
            }

            int askForInt(string msg)
            {
                Console.Write(msg);

                int givenInt;
                try
                {
                    givenInt = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("...");
                    return askForInt(msg);
                }
                return givenInt;
            }

        }

        static bool isAPrime(int toCheck)
        {
            if (toCheck % 2 == 0) return false;
            if (toCheck <= 1) return false;
            if (toCheck == 2) return true;

            var highestRoot = (int) Math.Floor(Math.Sqrt(toCheck));

            for (int i = 3; i <= highestRoot; i += 2)
                    if (toCheck % i == 0)
                        return false;

            return true;
        }
    }
}
