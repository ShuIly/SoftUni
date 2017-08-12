using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Boxes
{
	class Point
	{
		public int X { get; set; }
		public int Y { get; set; }

		public static Point ReadPoint(string input)
		{
			string[] inputTokens = input.Split(':');
			int x = int.Parse(inputTokens[0]);
			int y = int.Parse(inputTokens[1]);

			Point point = new Point()
			{
				X = x,
				Y = y
			};

			return point;
		}

	}

	class Box
	{
		public int Width { get; set; }
		public int Height { get; set; }
		public int Perimeter { get; set; }
		public int Area { get; set; }

		public static int CalcWidth(Point a, Point b)
		{
			int result = Math.Abs(a.X - b.X);
			return result;
		}

		public static int CalcHeight(Point a, Point b)
		{
			int result = Math.Abs(a.Y - b.Y);
			return result;
		}

		public static int CalcPerimeter(int width, int height)
		{
			int result = width * 2 + height * 2;
			return result;
		}

		public static int CalcArea(int width, int height)
		{
			int result = width * height;
			return result;
		}

		// Use the four points to create a box (0:2, 2:2, 0:0, 2:0).
		public static Box CreateBox(List<Point> pointsList)
		{
			int width = CalcWidth(pointsList[0], pointsList[1]);
			int height = CalcHeight(pointsList[0], pointsList[2]);
			int perimeter = CalcPerimeter(width, height);
			int area = CalcArea(width, height);

			Box box = new Box()
			{
				Width = width,
				Height = height,
				Perimeter = perimeter,
				Area = area
			};

			return box;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			var boxList = new List<Box>();

			while (input != "end")
			{
				string[] inputTokens = input
					.Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries);

				// Create list of points that will be used to create a box.
				var pointsList = new List<Point>();

				for (int i = 0; i < 4; i++)
				{
					pointsList.Add(Point.ReadPoint(inputTokens[i]));
				}

				// Create the box from the four points in pointsList.
				boxList.Add(Box.CreateBox(pointsList));
				input = Console.ReadLine();
			}

			foreach (var box in boxList)
			{
				Console.WriteLine($"Box: {box.Width}, {box.Height}");
				Console.WriteLine($"Perimeter: {box.Perimeter}");
				Console.WriteLine($"Area: {box.Area}");
			}
		}
	}
}