using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Distance_Between_Points
{
	class Point
	{
		public double X { get; set; }
		public double Y { get; set; }

		public static Point ReadPoint()
		{
			double[] coords = Console.ReadLine().Split().Select(double.Parse).ToArray();
			Point p = new Point() { X = coords[0], Y = coords[1] };

			return p;
		}

		public static double CalcDistance(Point a, Point b)
		{
			double sideA = Math.Abs(a.X - b.X);
			double sideB = Math.Abs(a.Y - b.Y);
			double minDistance = Math.Sqrt(sideA * sideA + sideB * sideB);

			return minDistance;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Point a = Point.ReadPoint();
			Point b = Point.ReadPoint();

			double minDist = Point.CalcDistance(a, b);

			Console.WriteLine($"{minDist:F3}");
		}
	}
}
