using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int iterations = int.Parse(Console.ReadLine());
            int oddNum = 1;
            int sum = 0;
            for (int i = 0; i < iterations; i++)
            {
                Console.WriteLine(oddNum);
                sum += oddNum;
                oddNum += 2;
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
