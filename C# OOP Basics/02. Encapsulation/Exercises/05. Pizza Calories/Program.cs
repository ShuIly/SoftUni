using System;

class Program
{
    static void Main(string[] args)
    {
        Pizza pizza = null;
        Dough dough = null;
        Topping topping = null;
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "END")
            {
                break;
            }

            string[] inputArgs = input
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (inputArgs[0] == "Pizza")
            {
                string pizzaName = inputArgs[1];
                int toppingsCount = int.Parse(inputArgs[2]);

                try
                {
                    pizza = new Pizza(pizzaName, toppingsCount);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }
            }
            else if (inputArgs[0] == "Dough")
            {
                string flourType = inputArgs[1];
                string bakingTechnique = inputArgs[2];
                int doughWeight = int.Parse(inputArgs[3]);

                try
                {
                    dough = new Dough(flourType, bakingTechnique, doughWeight);

                    if (pizza != null)
                    {
                        pizza.Dough = dough;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }
            }
            else
            {
                string toppingType = inputArgs[1];
                int toppingWeight = int.Parse(inputArgs[2]);

                try
                {
                    topping = new Topping(toppingType, toppingWeight);
                    pizza?.AddTopping(topping);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }
            }
        }

        if (pizza != null)
        {
            Console.WriteLine(pizza);
        }
        else if (topping == null)
        {
            Console.WriteLine($"{dough.Calories:F2}");
        }
        else
        {
            Console.WriteLine($"{dough.Calories:F2}");
            Console.WriteLine($"{topping.Calories:F2}");
        }
    }
}
