using System;
using System.Collections.Generic;
using System.Text;

namespace Class41Demo.Classes
{
    public class PizzaPlanet : PizzaStore
    {
        protected override Pizza CreatePizza(string pizzaType)
        {
            Console.WriteLine("Welcome to Pizza Plant");
            return PizzaPlanetFactory.CreatePizza(pizzaType);
        }
    }
}
