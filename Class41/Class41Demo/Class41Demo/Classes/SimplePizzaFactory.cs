using System;
using System.Collections.Generic;
using System.Text;

namespace Class41Demo.Classes
{
   public class SimplePizzaFactory
    {
        public Pizza CreatePizza(string pizzaType)
        {
            Pizza pizza = new Pizza();

            switch (pizzaType)
            {
                case "Cheese":
                    Console.WriteLine("Cheese is on the way");
                    pizza = new CheesePizza();
                    break;
                case "Veggie":
                    Console.WriteLine("Veggie Pizza has been created");
                    pizza = new VeggiePizza();
                    break;
                case "Pepperoni":
                    // Create Pepperoni pizza
                    Console.WriteLine("Pepperoni Pizza has been created");
                    pizza = new PepperoniPizza();
                    break;
                default:
                    break;
            }

            return pizza;
        }
    }
}
