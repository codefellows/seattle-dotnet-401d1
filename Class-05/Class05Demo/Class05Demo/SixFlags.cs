using System;
using System.Collections.Generic;
using System.Text;

namespace Class05Demo
{
    class SixFlags : AmusementPark
    {
        public int NumberOfBathrooms { get; set; }

        public void WalkThisPath()
        {
            Console.WriteLine("Stay on the Path!!!!!");
        }

        //public override int CollectFees()
        //{
        //    //Console.WriteLine("I require $50");
        //    return 10;
        //}
    }
}
