using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ra_zadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int initialIndexOfDonald = sequence[sequence.Count - 1];
            sequence.RemoveAt(sequence.Count - 1);

            //here we save the initial values of the game field
            List<int> initialGameField = new List<int>();
            initialGameField.AddRange(sequence);

            int countSteps = 0;
            while (true)
            {
                //decreasing all values of the sequence by 1
                for (int j = 0; j < sequence.Count; j++)
                {
                    sequence[j]--;
                }

                if (sequence[initialIndexOfDonald] == 0)
                {
                    break;
                }

                for (int j = 0; j < sequence.Count; j++)
                {
                    if (sequence[j] == 0)
                    {
                        sequence[j] = initialGameField[j];
                    }
                }

                int nextIndexOfDonald = int.Parse(Console.ReadLine());
                initialIndexOfDonald = nextIndexOfDonald;

                countSteps++;
            }

            //OUTPUT = it works
            Console.WriteLine(string.Join(" ", sequence));
            Console.WriteLine(countSteps);
        }
    }
}