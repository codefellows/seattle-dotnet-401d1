using System;
using System.Collections.Generic;
using System.Text;

namespace Class6Demo
{
    class Cyborg : Robot, IDrive, IPerson
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void AdjustMirrors()
        {
            Console.WriteLine("Robots adjust mirrors");

        }

        public bool Licence()
        {
            Console.WriteLine("Robots have licenses!");

            return true;

        }
        public bool DrinkCoffee()
        {
            Console.WriteLine("Robots have licenses!");
            return true;
        }

        public void Eat()
        {
            Console.WriteLine("Robots have licenses!");
        }

        public void Sleep()
        {
            Console.WriteLine("Robots have licenses!");
        }

   
    }
}
