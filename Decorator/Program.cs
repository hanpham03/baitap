using System;

namespace Decorator.RealWorld
{
    /// <summary>
    /// Decorator Design Pattern Example: Pizza with Toppings
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create plain pizza
            Pizza pizza = new PlainPizza();
            Console.WriteLine("Plain Pizza:");
            pizza.Display();

            // Decorate pizza with cheese
            Console.WriteLine("\nAdding Cheese:");
            Pizza cheesePizza = new CheeseDecorator(pizza);
            cheesePizza.Display();

            // Decorate pizza with cheese and pepperoni
            Console.WriteLine("\nAdding Pepperoni:");
            Pizza pepperoniPizza = new PepperoniDecorator(cheesePizza);
            pepperoniPizza.Display();

            // Wait for user
            Console.ReadKey();
        }
    }
}
