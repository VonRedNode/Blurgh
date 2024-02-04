using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Un
{
    internal class Program
    {


        static double forceNumberForN(String inputMessage, String wrongInoputMessage)
        {
            Console.Write(inputMessage);
            double n = Convert.ToDouble(Console.ReadLine());
            if(n > 1.0) { Console.WriteLine($"For {n} is greathen than 1"); return n; }
            Console.WriteLine(wrongInoputMessage);
            return forceNumberForN(inputMessage, wrongInoputMessage);
        }


        static void Main(string[] args)
        {
            Console.WriteLine("For this is the equation: \n x = √1/(n-1)");
            double nth = forceNumberForN("What value may n hold?: ", "...");
            double x = Math.Sqrt(1 / (nth - 1));
            Console.WriteLine($"Your answer for x shall be {x}");
            Console.ReadLine();
        }
    }
}
