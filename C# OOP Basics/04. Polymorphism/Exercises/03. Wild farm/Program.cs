using System;
using System.Collections.Generic;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            string animalInput = Console.ReadLine();
            if (animalInput == "End")
            {
                break;
            }

            string[] animalArgs = animalInput
                .Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            string[] foodArgs = Console.ReadLine()
                .Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            Animal animal = null;

            switch (animalArgs[0])
            {
                case "Cat":
                    animal = new Cat(animalArgs[1], double.Parse(animalArgs[2]), animalArgs[3], animalArgs[4]);
                    break;
                case "Tiger":
                    animal = new Tiger(animalArgs[1], double.Parse(animalArgs[2]), animalArgs[3]);
                    break;
                case "Zebra":
                    animal = new Zebra(animalArgs[1], double.Parse(animalArgs[2]), animalArgs[3]);
                    break;
                case "Mouse":
                    animal = new Mouse(animalArgs[1], double.Parse(animalArgs[2]), animalArgs[3]);
                    break;
            }

            Console.WriteLine(animal.MakeSound());

            try
            {
                switch (foodArgs[0])
                {
                    case "Vegetable":
                        animal.Eat(new Vegetable(int.Parse(foodArgs[1])));
                        break;
                    case "Meat":
                        animal.Eat(new Meat(int.Parse(foodArgs[1])));
                        break;
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine(animal);
        }
    }
}
