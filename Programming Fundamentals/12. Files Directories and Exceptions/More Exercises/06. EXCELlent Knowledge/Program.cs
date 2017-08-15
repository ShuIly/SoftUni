using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace _06.EXCELlent_Knowledge
{
	class Program
	{
		static void Main(string[] args)
		{
			Excel.Application xlApp = new Excel.Application();
			Excel.Workbook xlWorkbook = xlApp.Workbooks
				.Open(@"D:\Programming\Git-repositories\softuni\Programming Fundamentals\12. Files Directories and Exceptions\More Exercises\06. EXCELlent Knowledge\bin\Debug\sample_table.xlsx");
			Excel.Worksheet xlWorksheet = xlWorkbook.Sheets[1];
			Excel.Range xlRange = xlWorksheet.UsedRange;

			for (int i = 1; i <= 5; i++)
			{
				for (int j = 1; j <= 5; j++)
				{
					if (j == 1 && i != 1)
					{
						Console.WriteLine();
					}

					Console.Write(xlRange.Cells[i, j].Value + "|");
				}
			}
		}
	}
}
