using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currHp = int.Parse(Console.ReadLine());
            int fullHp = int.Parse(Console.ReadLine());
            int currEnergy = int.Parse(Console.ReadLine());
            int fullEnergy = int.Parse(Console.ReadLine());



            string hpBar = string.Format("|{0}{1}|", new string('|', currHp), new string('.', fullHp - currHp));
            string energyBar = string.Format("|{0}{1}|", new string('|', currEnergy), new string('.', fullEnergy - currEnergy));

            Console.WriteLine(
                $"Name: {name}\n" +
                $"Health: {hpBar}\n" +
                $"Energy: {energyBar}\n"
                );

        }
    }
}
