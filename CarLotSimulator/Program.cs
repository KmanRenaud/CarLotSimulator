using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            Cars Car1 = new Cars();

            Car1.Year = 2007;
            Car1.Make = "Honda";
            Car1.Model = "Civic";
            Car1.EngineNoise = "POP BANG POP";
            Car1.HonkNoise = "YeeHaw";
            Car1.IsDriveable = true;

            Car1.MakeEngineNoise(Car1.EngineNoise);
            Car1.MakeHonkNoise(Car1.HonkNoise);



            Cars Car2 = new Cars()
            {
                Year = 2013,
                Make = "Nissan",
                Model = "Altima",
                EngineNoise = "Sputter-put-put",
                HonkNoise = "MEEBEHP",
                IsDriveable = false
            };

            Car2.MakeEngineNoise(Car2.EngineNoise);
            Car2.MakeHonkNoise(Car2.HonkNoise);



            var car3 = new Cars(2023, "Chevorlet", "Tahoe", "Vroom", "BEEP", true);



            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            CarLot carLot1 = new CarLot();

            carLot1.CarList.Add(Car1);

            for (int i = 0; i < carLot1.CarList.Count - 1; i++)
            {
                Console.WriteLine(Car1.Year);
                Console.WriteLine(Car1.Make);
                Console.WriteLine(Car1.Model);
                Console.WriteLine(Car1.EngineNoise);
                Console.WriteLine(Car1.HonkNoise);
                Console.WriteLine(Car1.IsDriveable);

            }







        }
    }
}
