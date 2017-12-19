using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        MethodInfo oldestMemberMethod = typeof(Family).GetMethod("GetOldestMember");
        MethodInfo addMemberMethod = typeof(Family).GetMethod("AddMember");
        if (oldestMemberMethod == null || addMemberMethod == null)
        {
            throw new Exception();
        }

        Family family = new Family();

        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] inputArgs = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            string name = inputArgs[0];
            int age = int.Parse(inputArgs[1]);
            
            family.AddMember(new Person(name ,age));
        }

        Console.WriteLine(family.GetOldestMember());
    }
}
