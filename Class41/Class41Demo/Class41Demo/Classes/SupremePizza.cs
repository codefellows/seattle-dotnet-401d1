using System;
using System.Collections.Generic;
using System.Text;

namespace Class41Demo.Classes
{
    class SupremePizza : Pizza
    {
        public SupremePizza()
        {
            Name = "Supremo Pizza";
            Sauce = "Red Sauce";
            Dough = "Glutenful";
            Toppings.Add("Onions");
            Toppings.Add("Peppers");
            Toppings.Add("Pepperoni");
            Toppings.Add("Sausage");
            Toppings.Add("Bacon");

        }
    }
}
