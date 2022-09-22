using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    internal class Cars
    {


        public Cars()
        {

        }


        public Cars(int Year, string Make, string Model, string EngineNoise, string HonkNoise, bool IsDriveable)
        {

        }

    
    


    public void MakeEngineNoise(string noise)
        {
            Console.WriteLine($"The engine noise is {noise}");
        }
        public void MakeHonkNoise(string noise)
        {
            Console.WriteLine($"The honk noise is {noise}");
        }

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }






    }
}
