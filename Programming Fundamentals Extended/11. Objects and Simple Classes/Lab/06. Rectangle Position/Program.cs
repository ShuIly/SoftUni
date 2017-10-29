using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Rectangle_Position
{
	class Rectangle
	{
		public int Left { get; set; }
		public int Top { get; set; }
		public int Width { get; set; }
		public int Height { get; set; }

		public static bool IsInside(Rectangle first, Rectangle second)
		{
			int firstRight = first.Left + first.Width;
			int secondRight = second.Left + second.Width;
			int firstBottom = first.Top + first.Height;
			int secondBottom = second.Top + second.Height;

			bool isInside =
				first.Left >= second.Left &&
				firstRight <= secondRight &&
				firstBottom <= secondBottom &&
				first.Height <= second.Height;

			return isInside;
		}

		public static Rectangle ReadRectangle()
		{
			int[] rectToken = Console.ReadLine().Split().Select(int.Parse).ToArray();
			Rectangle rect = new Rectangle()
			{
				Left = rectToken[0],
				Top = rectToken[1],
				Width = rectToken[2],
				Height = rectToken[3]
			};

			return rect;
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			Rectangle rect1 = Rectangle.ReadRectangle();
			Rectangle rect2 = Rectangle.ReadRectangle();

			if (Rectangle.IsInside(rect1, rect2))
			{
				Console.WriteLine("Inside");
			}
			else
			{
				Console.WriteLine("Not inside");
			}
		}
	}
}
