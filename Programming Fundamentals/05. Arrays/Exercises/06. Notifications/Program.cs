using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Notifications
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			for (int i = 0; i < n; i++)
			{
				string status = Console.ReadLine();
				if (status == "success" || status == "error")
				{
					string operation = Console.ReadLine();
					string message = Console.ReadLine();
					RunOperation(status, operation, message);
				}
			}
		}

		static void RunOperation(string status, string operation, string message)
		{
			if (status == "success")
			{
				Console.WriteLine(
					$"Successfully executed {operation}.\n" +
					"==============================\n" +
					$"Message: {message}."
				);
			}
			else
			{
				Console.WriteLine(
					$"Error: Failed to execute {operation}.\n" +
					"==============================\n" +
					$"Error Code: {message}."
				);
				if (int.Parse(message) >= 0)
				{
					Console.WriteLine("Reason: Invalid Client Data.");
				}
				else
				{
					Console.WriteLine("Reason: Internal System Failure.");
				}
			}
		}
	}
}