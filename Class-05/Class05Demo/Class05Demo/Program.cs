using System;

namespace Class05Demo
{
    class Program : Park
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            SixFlags california = new SixFlags();

            Console.WriteLine(california.CollectFees());
            
            Console.Read();
        }
    }
}
