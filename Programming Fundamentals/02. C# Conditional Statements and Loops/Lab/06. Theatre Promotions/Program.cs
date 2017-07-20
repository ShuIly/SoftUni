using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Theatre_Promotions
{
    class Program
    {
        static void Main(string[] args)
        {
            string week = Console.ReadLine().ToLower();
            int age = int.Parse(Console.ReadLine());
            int price = 0;

            switch (week)
            {
                case "weekday":
                    if (age >= 0 && age <= 18)
                    {
                        price = 12;
                        Console.WriteLine("{0}$\n", price);
                    }
                    else if (age > 18 && age <= 64)
                    {
                        price = 18;
                        Console.WriteLine("{0}$\n", price);
                    }
                    else if (age > 64 && age <= 122)
                    {
                        price = 12;
                        Console.WriteLine("{0}$\n", price);
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                    break;
                    
                case "weekend":
                    if (age >= 0 && age <= 18)
                    {
                        price = 15;
                        Console.WriteLine("{0}$\n", price);
                    }
                    else if (age > 18 && age <= 64)
                    {
                        price = 20;
                        Console.WriteLine("{0}$\n", price);
                    }
                    else if (age > 64 && age <= 122)
                    {
                        price = 15;
                        Console.WriteLine("{0}$\n", price);
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                    break;
                    
                case "holiday":
                    if (age >= 0 && age <= 18)
                    {
                        price = 5;
                        Console.WriteLine("{0}$\n", price);
                    }
                    else if (age > 18 && age <= 64)
                    {
                        price = 12;
                        Console.WriteLine("{0}$\n", price);
                    }
                    else if (age > 64 && age <= 122)
                    {
                        price = 10;
                        Console.WriteLine("{0}$\n", price);
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                    break;
                   
                default:
                    Console.WriteLine("Error!");
                    break;
            }
        }
    }
}
