using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Note_Statistics
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<decimal, string> notes = new Dictionary<decimal, string>()
			{
				{261.63M,"C"},
				{277.18M,"C#"},
				{293.66M,"D"},
				{311.13M,"D#"},
				{329.63M,"E"},
				{349.23M,"F"},
				{369.99M,"F#"},
				{392M,"G"},
				{415.3M,"G#"},
				{440M,"A"},
				{466.16M,"A#"},
				{493.88M,"B"},
			};

			decimal[] frequency = Console.ReadLine().Split().Select(decimal.Parse).ToArray();
			List<string> naturalNotes = new List<string>();
			List<string> sharpNotes = new List<string>();
			List<string> seenNotes = new List<string>();

			decimal naturalSum = 0; 
			decimal sharpSum = 0; 

			int frequencyCount = frequency.Length;

			for (int i = 0; i < frequencyCount; i++)
			{
				decimal currFrequency = frequency[i];

				// check if frequency maches the dictionary notes
				if (notes.ContainsKey(currFrequency))
				{
					string currNote = notes[currFrequency];
					seenNotes.Add(currNote);

					// if note has length of 1 (for example C, G, B, A, etc.) 
					// add it to naturalNotes
					if (currNote.Length == 1)
					{
						naturalNotes.Add(currNote);
						naturalSum += currFrequency;
					}
					else 
					{
						// if it has length > 1, it must be sharp note (D#, F#, G#, A#, etc.)
						sharpNotes.Add(currNote);
						sharpSum += currFrequency;
					}
				}
			}

			Console.WriteLine("Notes: {0}", string.Join(" ", seenNotes));
			Console.WriteLine("Naturals: {0}", string.Join(", ", naturalNotes));
			Console.WriteLine("Sharps: {0}", string.Join(", ", sharpNotes));
			Console.WriteLine("Naturals sum: {0}", string.Join(" ", naturalSum));
			Console.WriteLine("Sharps sum: {0}", string.Join(" ", sharpSum));
		}
	}
}