using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Closest_Two_Points
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
		
		public static Point[] ReadPointArr()
		{
			int n = int.Parse(Console.ReadLine());
			Point[] points = new Point[n];

			for (int i = 0; i < n; i++)
			{
				points[i] = ReadPoint();
			}

			return points;
		}

		public static double CalcDistance(Point a, Point b)
		{
			double sideA = Math.Abs(a.X - b.X);
			double sideB = Math.Abs(a.Y - b.Y);
			double minDistance = Math.Sqrt(sideA * sideA + sideB * sideB);

			return minDistance;
		}

		public static Point[] GetClosestTwo(Point[] points)
		{
			int pointsCount = points.Length;
			double minDist = double.MaxValue;
			Point[] closestPoints = null;

			for (int i = 0; i < pointsCount; i++)
			{
				for (int j = i + 1; j < pointsCount; j++)
				{
					double currDist = CalcDistance(points[i], points[j]);
					if (minDist > currDist)
					{
						minDist = currDist;
						closestPoints = new Point[] { points[i], points[j] };
					}
				}
			}

			return closestPoints;
		}

		public override string ToString()
		{
			return String.Format("({0}, {1})", this.X, this.Y);
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Point[] points = Point.ReadPointArr();
			Point[] closestTwoPoints = Point.GetClosestTwo(points);
			double closestDist = Point.CalcDistance(closestTwoPoints[0], closestTwoPoints[1]);
			Console.WriteLine($"{closestDist:F3}");
			Console.WriteLine(closestTwoPoints[0]);
			Console.WriteLine(closestTwoPoints[1]);
		}
	}
}
