using Class41Demo.Classes;
using System;

namespace Class41Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Pizza amandasPizza = new Pizza();
            //amandasPizza.OrderPizza("Cheese");


            PizzaStore amandasPizzaStore = new PizzaPlanet();
            amandasPizzaStore.OrderPizza("Galactic");

            Console.WriteLine();

            PizzaStore pp = new PizzaParadize();
            pp.OrderPizza("Supreme");
        }
    }
}
