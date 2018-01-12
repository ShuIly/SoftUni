using System;

class Program
{
    static void Main(string[] args)
    {
        MyList<IComparable> list = new MyList<IComparable>();

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "END")
            {
                break;
            }

            CommandInterpreter.PerformAction(list, input
                .Split(new [] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
        }
    }
}
