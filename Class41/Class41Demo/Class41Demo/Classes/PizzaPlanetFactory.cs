using System;
using System.Collections.Generic;
using System.Text;

namespace Class41Demo.Classes
{
    class PizzaPlanetFactory
    {
        public static Pizza CreatePizza(string pizzaType)
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
                case "Galactic":
                    // Create Pepperoni pizza
                    Console.WriteLine("Galactic Pizza has been created");
                    pizza = new GalacticMeatLovers();
                    break;
                default:
                    break;
            }

            return pizza;
        }
    }
}
