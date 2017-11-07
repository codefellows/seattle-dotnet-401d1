using System;
using System.Collections.Generic;
using System.Text;

namespace Class41Demo.Classes
{
    class PizzaParadizeFactory
    {
       public static Pizza CreatePizza(string pizzaType)
        {
            Pizza pizza = new Pizza();

            switch (pizzaType)
            {
                case "Supreme":
                    Console.WriteLine("Supreme is on the way");
                    pizza = new SupremePizza();
                    break;

                default:
                    break;
            }

            return pizza;
        }
    }
}
