using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Blanc_Receipt
{
	class Program
	{
		static void Main(string[] args)
		{
			GetReceipt();
		}
		static void ReceiptHeader()
		{
			Console.WriteLine("CASH RECEIPT");
			Console.WriteLine("------------------------------");
		}
		static void ReceiptBody()
		{
			Console.WriteLine("Charged to____________________");
			Console.WriteLine("Received by___________________");
		}
		static void ReceiptFooter()
		{
			Console.WriteLine("------------------------------");
			Console.WriteLine("© SoftUni");
		}
		static void GetReceipt()
		{
			ReceiptHeader();
			ReceiptBody();
			ReceiptFooter();
		}
	}
}
