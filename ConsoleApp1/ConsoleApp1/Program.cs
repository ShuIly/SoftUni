using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        List<int> sequence = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse).ToList();

        int initialIndexOfDonald = sequence[sequence.Count - 1];

        sequence.RemoveAt(sequence.Count - 1);
        List<int> initialGameField = new List<int>(sequence);

        int countSteps = 0;

        for (int i = 0; i < sequence.Count; i++)
        {
            sequence[i]--;
        }

        for (int i = 0; i < sequence.Count; i++)
        {
            if (sequence[i] == 0)
            {
                sequence[i] = initialGameField[i];
            }
        }

        if (sequence[initialIndexOfDonald] != 0)
        {
            while (true)
            {
                for (int i = 0; i < sequence.Count; i++)
                {
                    sequence[i]--;
                }

                int nextIndexOfDonald = int.Parse(Console.ReadLine());


                if (sequence[nextIndexOfDonald] == 0)
                {
                    countSteps++;
                    break;
                }

                for (int i = 0; i < sequence.Count; i++)
                {
                    if (sequence[i] == 0)
                    {
                        sequence[i] = initialGameField[i];
                    }
                }

                countSteps++;
            }

            Console.WriteLine(string.Join(" ", sequence));
            Console.WriteLine(countSteps);
        }
    }
}