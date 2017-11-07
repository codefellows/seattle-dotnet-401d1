using System;
using System.Collections.Generic;
using System.Text;

namespace Class41Demo.Classes
{
   public abstract class PizzaStore
    {
        // No longer needed after createing new stores
        //SimplePizzaFactory Factory { get; set; }

        //public PizzaStore(SimplePizzaFactory factory)
        //{
        //    this.Factory = factory;
        //}

         //Factory method. Requiring this to be implemented/overridden in derived classes
        protected abstract Pizza CreatePizza(string pizzaType);
        

        public Pizza OrderPizza( string pizzaType)
        {
            Pizza pizza = null;

            pizza = CreatePizza(pizzaType);
            //pizza = Factory.CreatePizza(pizzaType);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}
