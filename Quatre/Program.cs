using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Quatre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double askForDouble(string msg)
            {
                Console.Write(msg);

                double givenDouble;
                try
                {
                    givenDouble = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("...");
                    return askForDouble(msg);
                }
                return givenDouble;
            }

            int getYearsPaid(double capital, double yearlyWithdrawal, double interest)
            {
                int years = 0;

                while (capital - yearlyWithdrawal >= 0)
                {
                    capital *= 1.0 + interest;
                    capital -= yearlyWithdrawal;
                    years++;
                }

                return years;
            }


            double startCapital = 1000000;
            double interestRate = 0.04; // screw 4

            double withdrawal = 50000;

            if(withdrawal < startCapital *  interestRate)
            {
                Console.WriteLine("You don't need to work anymore");
            } else
            {
                int paidYears = getYearsPaid(startCapital, withdrawal,interestRate);
                Console.WriteLine($"For a starting Capital of \t{startCapital} \n" +
                    $"And a yearly interest rate of \t{interestRate}\n" +
                    $"And a yearly withdrawal of \t{withdrawal}\n\n" +
                    $"You won't have to work for \t{paidYears} years");
            }

            Console.ReadLine();
        }

    }
}
