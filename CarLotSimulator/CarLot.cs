using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    internal class CarLot
    {


        public List<Cars> CarList { get; set; } = new List<Cars>();



        public static int carsInLot = 0;



        public CarLot()
        {
            carsInLot++;
        }


    }
}
