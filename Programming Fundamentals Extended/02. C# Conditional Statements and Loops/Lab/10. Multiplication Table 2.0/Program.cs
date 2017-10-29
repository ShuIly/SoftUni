using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int var = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());
            if (multiplier <= 10)
            {
                while (multiplier <= 10)
                {
                    Console.WriteLine($"{var} X {multiplier} = {var * multiplier}");
                    multiplier++;
                }
            }
            else
            {
                Console.WriteLine($"{var} X {multiplier} = {var * multiplier}");
            }
        }
    }
}