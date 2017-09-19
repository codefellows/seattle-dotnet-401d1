using System;

namespace Class6Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Compact duanesCar = new Compact();

            //Robot bender = new Robot();
            //duanesCar.Drive(bender);

            //IDrive c3po = new Robot();
            //c3po.StartCar();
            //duanesCar.Drive(c3po);

            //IDrive amanda = c3po;

            Cyborg kyle = new Cyborg();

            duanesCar.Drive(kyle);
           


        }
    }
}
