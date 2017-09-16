using System;
using System.Collections.Generic;
using System.Text;

namespace Class05Demo
{
    abstract class Park
    {
        protected int Hours { get; set; }
        protected string Location { get; set; }

        protected int AddToLot()
        {
            int parkingLot = 0;
            return parkingLot;
        }

        public virtual int CollectFees()
        {
            //Console.WriteLine("Fee is $20");
            return 20;
        }
    }
}
