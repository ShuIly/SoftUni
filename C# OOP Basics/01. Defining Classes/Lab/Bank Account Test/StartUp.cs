using System;
using System.Collections.Generic;

class StartUp
{
    static void Main(string[] args)
    {
        var bankAccounts = new Dictionary<int, BankAccount>();

        while (true)
        {
            string command = Console.ReadLine();
            if (command == "End")
            {
                break;
            }

            string[] cmdArgs = command
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string cmdType = cmdArgs[0];
            switch (cmdType)
            {
                case "Create":
                    Create(cmdArgs, bankAccounts);
                    break;
                case "Deposit":
                    Deposit(cmdArgs, bankAccounts);
                    break;
                case "Withdraw":
                    Withdraw(cmdArgs, bankAccounts);
                    break;
                case "Print":
                    Print(cmdArgs, bankAccounts);
                    break;
            }
        }
    }

    static void Create(string[] cmdArgs, Dictionary<int, BankAccount> bankAccounts)
    {
        int id = int.Parse(cmdArgs[1]);
        if (bankAccounts.ContainsKey(id))
        {
            Console.WriteLine("Account already exists");
            return;
        }

        BankAccount acc = new BankAccount();
        acc.Id = id;
        bankAccounts.Add(id, acc);
    }

    static void Deposit(string[] cmdArgs, Dictionary<int, BankAccount> bankAccounts)
    {
        int id = int.Parse(cmdArgs[1]);
        if (!bankAccounts.ContainsKey(id))
        {
            Console.WriteLine("Account does not exist");
            return;
        }

        double amount = double.Parse(cmdArgs[2]);
        bankAccounts[id].Deposit(amount);
    }

    static void Withdraw(string[] cmdArgs, Dictionary<int, BankAccount> bankAccounts)
    {
        int id = int.Parse(cmdArgs[1]);
        if (!bankAccounts.ContainsKey(id))
        {
            Console.WriteLine("Account does not exist");
            return;
        }

        double amount = double.Parse(cmdArgs[2]);
        if (amount > bankAccounts[id].Balance)
        {
            Console.WriteLine("Insufficient balance");
            return;
        }

        bankAccounts[id].Withdraw(amount);
    }

    static void Print(string[] cmdArgs, Dictionary<int, BankAccount> bankAccounts)
    {
        int id = int.Parse(cmdArgs[1]);
        if (!bankAccounts.ContainsKey(id))
        {
            Console.WriteLine("Account does not exist");
            return;
        }

        Console.WriteLine(bankAccounts[id]);
    }
}
