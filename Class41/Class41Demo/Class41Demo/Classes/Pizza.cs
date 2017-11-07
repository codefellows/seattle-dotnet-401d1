using System;
using System.Collections.Generic;
using System.Text;

namespace Class41Demo.Classes
{
    public class Pizza
    {

        public string Name { get; set; }
        public string Dough { get; set; }
        public string Sauce { get; set; }
        public List<string> Toppings = new List<string>();

        public String getName()
        {
            return Name;
        }


        public void Prepare()
        {
            Console.WriteLine($"Preparing the Pizza {Name}");

            foreach(string top in Toppings)
            {
                Console.WriteLine(top);
            }
        }

        public void Bake()
        {
            Console.WriteLine("Baking the Pizza");


        }

        public void Cut()
        {
            Console.WriteLine("Cutting the Pizza");


        }

        public void Box()
        {
            Console.WriteLine("Boxing the Pizza");

        }
    }
}
