using class04demo;
using System;

namespace class04_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int test = 10;

            /*
             * commented code
             * 
             */

            // dotnet401d1 is an instantiation of the Party class
            Graduation dotNet401d1 = new Graduation("red", 15, "black");
            //Party miyasParty = new Party(3000, 20);

          //  Console.WriteLine(miyasParty.People); //get 
            //miyasParty.People = 50; //set

            //miyasParty.PartyBudget();
            //miyasParty.GetPeopleCount();

            dotNet401d1.BadDecisions();



            Graduation collegeGrad = new Graduation("green", 10, "blue");

            collegeGrad.Games();
            collegeGrad.Budget = 200;
            collegeGrad.PartyBudget(); 



            Console.Read();
        }
    }
}
