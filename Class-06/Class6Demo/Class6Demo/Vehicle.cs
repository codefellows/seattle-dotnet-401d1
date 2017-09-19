using System;
using System.Collections.Generic;
using System.Text;

namespace Class6Demo
{
   abstract class Vehicle
    {

        public int NumberOfWheels { get; set; }

        public void ContactFactory()
        {
            Console.WriteLine("I will contact the factory");
        }

       
    }
}
