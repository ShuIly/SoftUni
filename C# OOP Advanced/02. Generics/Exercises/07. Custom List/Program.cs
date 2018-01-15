using System;

class Program
{
    static void Main()
    {
        MyList<IComparable> list = new MyList<IComparable>();

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "END")
            {
                break;
            }

            CommandInterpreter.PerformAction(ref list, input
                .Split(new [] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
        }
    }
}
