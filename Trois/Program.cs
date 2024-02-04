using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trois
{
    internal class Program
    {
        static void Main(string[] args)
        {
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


            int a = askForInt("For a is: ");
            int b = askForInt("For b is: ");

            int greatestSharedDivider = getGreatesSharedDivider(a, b);

            Console.WriteLine($"s is: { greatestSharedDivider}");

            Console.ReadLine();
        }

        static int getGreatesSharedDivider(int a, int b)
        {
            while (a != b) 
            { 
                if(a > b)
                {
                    a -= b;
                } else
                {
                    b -= a;
                }
            }
            return a;
        }
    }
}
