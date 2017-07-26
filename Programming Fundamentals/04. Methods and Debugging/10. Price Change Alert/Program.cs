using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Price_Change_Alert
{
	class Program
	{
		static void Main()
		{
			int n = int.Parse(Console.ReadLine());
			double threshold = double.Parse(Console.ReadLine());
			double lastPrice = double.Parse(Console.ReadLine());

			for (int i = 0; i < n - 1; i++)
			{
				double currPrice = double.Parse(Console.ReadLine());
				double div = Proc(lastPrice, currPrice);
				bool isSignificantDifference = isThereDiff(div, threshold);
				string message = Get(currPrice, lastPrice, div, isSignificantDifference);

				Console.WriteLine(message);
				lastPrice = currPrice;
			}
		}

		private static string Get(double currPrice, double lastPrice, double razlika, bool etherTrueOrFalse)
		{
			string to = "";
			if (razlika == 0)
			{
				to = string.Format("NO CHANGE: {0}", currPrice);
			}
			else if (!etherTrueOrFalse)
			{
				to = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)",
					lastPrice, currPrice, razlika * 100);
			}
			else if (etherTrueOrFalse && (razlika > 0))
			{
				to = string.Format("PRICE UP: {0} to {1} ({2:F2}%)",
					lastPrice, currPrice, razlika * 100);
			}
			else if (etherTrueOrFalse && (razlika < 0))
				to = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)",
					lastPrice, currPrice, razlika * 100);
			return to;
		}

		private static bool isThereDiff(double threshold, double isDiff)
		{
			if (Math.Abs(threshold) >= isDiff)
			{
				return true;
			}
			return false;
		}

		// I can't bring myself to understand this method...
		private static double Proc(double lastPrice, double currPrice)
		{
			double result = (currPrice - lastPrice) / lastPrice;
			return result;
		}
	}
}
