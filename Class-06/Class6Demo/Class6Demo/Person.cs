using System;
using System.Collections.Generic;
using System.Text;

namespace Class6Demo
{
    class Person : IDrive , IPerson
    {
        public int Name { get; set; }

        public int Age
        {
            get
            {
                return Age;
            }
            set
            {
                if (IsValidAge(value))
                    Age = value;
                else
                    throw new ArgumentOutOfRangeException("value", "You are not old enough");
            }
        }

        string IPerson.Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        private bool IsValidAge(int age)
        {
            return (age < minDriversAge);
        }

        public bool Licence()
        {
            Console.WriteLine("I meet the license requirements");
            return true;
        }

        public void StartCar()
        {
            Console.WriteLine("Please ensure you have your seat belt buckled");

        }

        public void AdjustMirrors()
        {
            Console.WriteLine("Make sure you can see");
        }


        public void StopCar()
        {
            Console.WriteLine("STOP!"); 
        }

        public void Eat()
        {
            Console.WriteLine("I eat");

        }

        public void Sleep()
        {
            Console.WriteLine($"{Name} sleeps!");

        }

        public bool DrinkCoffee()
        {
            Console.WriteLine("this person drinks coffee!");

            return true;

        }

        private const int minDriversAge = 16;


    }
}
