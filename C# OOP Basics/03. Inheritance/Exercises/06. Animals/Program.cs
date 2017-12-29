using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var soundProducibles = new List<IProduceSound>();
        while (true)
        {
            string animal = Console.ReadLine();
            if (animal == "Beast!")
            {
                break;
            }

            string[] animalArgs = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            try
            {
                soundProducibles.Add(AnimalFactory.GetAnimal(animal, animalArgs[0], int.Parse(animalArgs[1]), animalArgs[2]));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        foreach (var soundProducible in soundProducibles)
        {
            Console.WriteLine(soundProducible + "\n" + soundProducible.ProduceSound());
        }
    }
}
