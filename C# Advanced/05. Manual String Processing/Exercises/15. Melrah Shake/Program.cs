using System;
using System.Text;

namespace _15.Melrah_Shake
{
    class Program
    {
        static void Main(string[] args)
        {
	        StringBuilder strSb = new StringBuilder(Console.ReadLine());
	        StringBuilder patternSb = new StringBuilder(Console.ReadLine());

	        while (patternSb.Length != 0)
	        {
		        string str = strSb.ToString(); 
		        string pattern = patternSb.ToString(); 

		        int indexStart = str.IndexOf(pattern);
		        if (indexStart == -1)
		        {
			        break;
		        }

		        int indexEnd = str.LastIndexOf(pattern);

		        if (indexStart != indexEnd)
		        {
			        strSb = strSb.Remove(indexEnd, patternSb.Length)
				        .Remove(indexStart, patternSb.Length);

			        Console.WriteLine("Shaked it.");
		        }

		        patternSb = patternSb.Remove(patternSb.Length / 2, 1);
	        }

	        Console.WriteLine("No shake.\n" + strSb);
        }
    }
}