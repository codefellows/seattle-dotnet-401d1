using System;
using System.Collections.Generic;

namespace Class07Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Car car = new Car();

            Console.WriteLine((int)Color.Cobalt);

            List<string> myList = new List<string>();
            myList.Add("George");
            myList.Add("Brian");
            myList.Add("Brandon");
            myList.Add("Kyle");
            myList.Add("Erik");
            myList.Add("Austin");
            myList.Add("Duane");
            myList.Add("Adam");
            myList.Add("Miya");
            myList.Add("Tom");
            myList.Add("Greg");
            myList.Add("Cam");
            myList.Add("Amanda");
            myList.Add("Lynn");
            myList.Add("Amy");

            foreach(string name in myList)
            {
                Console.WriteLine(name);
            }


            List<string> carNames = new List<string> { "prelude", "accord", "civic", "element", "pilot", "metro" };


            foreach(string c in carNames)
            {
                Console.WriteLine(c);
            }

            carNames.Remove("element");

            Console.WriteLine();

            foreach (string c in carNames)
            {
                Console.WriteLine(c);
            }

            carNames.RemoveAt(4);

            foreach (string c in carNames)
            {
                Console.WriteLine(c);
            }

            carNames.RemoveAt(carNames.IndexOf("pilot"));

            Console.WriteLine();

            foreach (string c in carNames)
            {
                Console.WriteLine(c);
            }

            //  Console.WriteLine(carNames.IndexOf("pilot"));



            Garage<Car> parkingGarage = new Garage<Car>();

            parkingGarage.Add(car);
            parkingGarage.Add(new Car { CarColor = Color.Plum });
            parkingGarage.Add(new Car { CarColor = Color.Mahogany });

            foreach(Car c in parkingGarage)
            {
                Console.WriteLine(c.CarColor);
            }

            Console.Read();
        }
    }
}
