using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Exercises
{
	class Exercises
	{
		public string Topic { get; set; }
		public string Course { get; set; }
		public string JudgeLink { get; set; }
		public List<string> Problems { get; set; }

		public static Exercises ReadExercises(string input)
		{
			string[] inputTokens = input
				.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
			string topicName = inputTokens[0];
			string courseName = inputTokens[1];
			string judgeLink = inputTokens[2];
			List<string> problems = inputTokens[3]
				.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();


			Exercises exercise = new Exercises()
			{
				Topic = topicName,
				Course = courseName,
				JudgeLink = judgeLink,
				Problems = problems
			};

			return exercise;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			List<Exercises> exercisesList = new List<Exercises>();
			string input = Console.ReadLine();

			while (input != "go go go")
			{
				exercisesList.Add(Exercises.ReadExercises(input));
				input = Console.ReadLine();
			}

			foreach (Exercises exercise in exercisesList)
			{
				Console.WriteLine($"Exercises: {exercise.Topic}");
				Console.WriteLine($"Problems for exercises and homework for the \"{exercise.Course}\" course @ SoftUni.");
				Console.WriteLine($"Check your solutions here: {exercise.JudgeLink}");

				int problemIndex = 1;
				foreach (string problem in exercise.Problems)
				{
					Console.WriteLine("{0}. {1}", problemIndex, problem);
					problemIndex++;
				}
			}
		}
	}
}
