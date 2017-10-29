using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Optimized_Banking_System
{
	class BankAccount
	{
		public string Bank { get; set; }
		public string AccountName { get; set; }
		public decimal Balance { get; set; }

		public static BankAccount CreateBankAccount(string input)
		{
			string[] inputTokens = input
				.Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries);
			string bankName = inputTokens[0];
			string accountName = inputTokens[1];
			decimal balance = decimal.Parse(inputTokens[2]);

			BankAccount account = new BankAccount()
			{
				Bank = bankName,
				AccountName = accountName,
				Balance = balance
			};

			return account;
		}

		public static List<BankAccount> CreateBankAccountList()
		{
			var bankAccountList = new List<BankAccount>();
			string input = Console.ReadLine();

			while (input != "end")
			{
				bankAccountList.Add(CreateBankAccount(input));
				input = Console.ReadLine();
			}

			return bankAccountList;
		}

		public override string ToString()
		{
			string bankName = this.Bank;
			string accountName = this.AccountName;
			decimal balance = this.Balance;
			string result = string.Format($"{accountName} -> {balance} ({bankName})");

			return result;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			var bankAccountList = BankAccount.CreateBankAccountList();

			foreach (var bankAccount in bankAccountList
				.OrderByDescending(a => a.Balance)
				.ThenBy(a => a.Bank.Length))
			{
				Console.WriteLine(bankAccount);
			}
		}
	}
}
