using System;
using System.Collections.Generic;
using System.Text;

namespace Class41Demo.Classes
{
    class PizzaParadize : PizzaStore
    {
        protected override Pizza CreatePizza(string pizzaType)
        {
            Console.WriteLine("Welcome to Pizza Paradize");
            return PizzaParadizeFactory.CreatePizza(pizzaType);
        }
    }
}
