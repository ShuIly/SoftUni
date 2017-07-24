using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Photo_Gallery
{
	class Program
	{
		static void Main(string[] args)
		{
			int imageNum = int.Parse(Console.ReadLine());
			int dayTaken = int.Parse(Console.ReadLine());
			int monthTaken = int.Parse(Console.ReadLine());
			int yearTaken = int.Parse(Console.ReadLine());
			int hourTaken = int.Parse(Console.ReadLine());
			int minuteTaken = int.Parse(Console.ReadLine());
			double sizeInBytes = int.Parse(Console.ReadLine());
			int imageWidth = int.Parse(Console.ReadLine());
			int imageHeight = int.Parse(Console.ReadLine());

			string properSize;
			if (sizeInBytes / 1000000 >= 1)
			{
				properSize = $"{sizeInBytes / 1000000}MB";
			}
			else if (sizeInBytes / 1000 >= 1)
			{
				properSize = $"{sizeInBytes / 1000}KB";
			}
			else
			{
				properSize = $"{sizeInBytes}B";
			}

			string orientation;
			if (imageWidth > imageHeight)
			{
				orientation = "landscape";
			}
			else if (imageWidth < imageHeight)
			{
				orientation = "portrait";
			}
			else
			{
				orientation = "square";
			}

			Console.WriteLine(
				$"Name: DSC_{imageNum:D4}.jpg\n" +
				$"Date Taken: {dayTaken:D2}/{monthTaken:D2}/{yearTaken} {hourTaken:D2}:{minuteTaken:D2}\n" +
				$"Size: {properSize}\n" +
				$"Resolution: {imageWidth}x{imageHeight} ({orientation})\n"
			);
		}
	}
}
