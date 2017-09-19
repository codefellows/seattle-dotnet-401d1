using System;
using System.Collections.Generic;
using System.Text;

namespace Class6Demo
{
    class Compact : Vehicle
    {

        public void Drive(IDrive driver)
        {
            driver.StartCar();
        }

    }
}
