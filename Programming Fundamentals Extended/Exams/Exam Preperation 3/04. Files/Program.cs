using System;

namespace _04.Files
{
    class Program
    {
        static void Main(string[] args)
        {
	        string regex =
		        @"^(?<root>.+?)\\(?<folder>.+?\\(?:.+?\\)*)(?<filename>.+)\.(?<extension>.+);(?<filesize>\d+)$";
        }
    }
}