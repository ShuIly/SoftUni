using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Re_Directory
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] filePaths = Directory.GetFiles("input");
			string lastExtention = null;

			// Sort filepaths by extension
			filePaths = filePaths.OrderBy(s => Path.GetExtension(s)).ToArray();

			for (int i = 0; i < filePaths.Length; i++)
			{
				string extension = Path.GetExtension(filePaths[i]);

				// If there's a file with no extention ignore it
				if (string.IsNullOrEmpty(extension))
				{
					continue;
				}

				string dirName = extension.Substring(1);
				string fileName = Path.GetFileName(filePaths[i]);

				if (lastExtention != extension)
				{
					Directory.CreateDirectory($"input\\{dirName}s");
					lastExtention = extension;
				}

				// Move file to the directory
				File.Move(filePaths[i], $"input\\{dirName}s\\{fileName}");
			}
		}
	}
}
