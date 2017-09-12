using System;

namespace Class01Demo
{
    class Program
    {
        //string x = "seventy-two";

        static void Main(string[] args)
        {
            string myMainVariable;

            myMainVariable = "This is my Varaible";
            Console.WriteLine("Hello World!");
            Console.WriteLine(myMainVariable);

            SayHello("Hello");
            SayHello(72);
            //string words = Console.ReadLine();

            //Console.WriteLine(Console.ReadLine());
            IterationStatements();
            SelectiveStatements();
            Console.Read();
        }

       static void SayHello(string greeting)
        {

            Console.WriteLine("This is my greeting " + greeting);
            Console.WriteLine($"This is the new standard {greeting}");
        }

        static void SayHello(int greeting)
        {
            Console.WriteLine("This is my greeting " + greeting);
            Console.WriteLine($"This is the new standard {greeting}");
        }


        static void IterationStatements()
        {
            for(int x=0; x < 10; x++)
            {
                Console.WriteLine(x);
            }

            int[] numberArray = new int[] { 72, 42, 21, 38 };
            foreach(int number in numberArray)
            {
                Console.WriteLine(number);
            }

            int z = 0;
            while(z < 10)
            {
                Console.WriteLine(z);
                z++;
            }

            int n = 0;
            do
            {
                Console.WriteLine(n);
                n++;
            }
            while (n < 5);

        }

        static void SelectiveStatements()
        {

            Console.WriteLine("What is your name?");
            string userInput = Console.ReadLine();

            //Console.Write("First Name");

            if (string.IsNullOrEmpty(userInput.Trim()))
            {
                Console.WriteLine("Please type a name!!!!");

                SelectiveStatements();
            }
            else
            {
                Console.WriteLine($"Welcome {userInput}");
            }
        }

    }
}
