using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Debit_Card_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int debitNum1 = int.Parse(Console.ReadLine());
            int debitNum2 = int.Parse(Console.ReadLine());
            int debitNum3 = int.Parse(Console.ReadLine());
            int debitNum4 = int.Parse(Console.ReadLine());

            Console.WriteLine("{0:D4} {1:D4} {2:D4} {3:D4}", debitNum1, debitNum2, debitNum3, debitNum4);
        }
    }
}
