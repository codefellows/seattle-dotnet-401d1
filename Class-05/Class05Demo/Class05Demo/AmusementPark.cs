using System;
using System.Collections.Generic;
using System.Text;

namespace Class05Demo
{
   abstract class AmusementPark : Park
    {
        //add properties
        public string Food { get; set; }

        public bool AcceptsPet()
        {
            return true;
        }
        public sealed override int CollectFees()
        {
          return base.CollectFees() + 30;
        }

    }
}
