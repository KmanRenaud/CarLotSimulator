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


            CarLot carLot1 = new CarLot();

            carLot1.CarList.Add(Car1);

            foreach (var car in carLot1.CarList)
            {
                Console.WriteLine($"The first car was made in {Car1.Year}");
                Console.WriteLine();
                Console.WriteLine($"The brand of the first car is {Car1.Make}");
                Console.WriteLine();
                Console.WriteLine($"The model of the first car is {Car1.Model}");
                Console.WriteLine();
                Console.WriteLine($"Is the first car driveable? {Car1.IsDriveable}");
                Console.WriteLine();


            }



            Car1.MakeEngineNoise($"{Car1.EngineNoise}");
            Console.WriteLine();
            Car1.MakeEngineNoise($"{Car1.HonkNoise}");
            Console.WriteLine();




            Console.WriteLine();
            Console.WriteLine(CarLot.carsInLot);
            Console.WriteLine();



            Cars Car2 = new Cars()
            {
                Year = 2013,
                Make = "Nissan",
                Model = "Altima",
                EngineNoise = "Sputter-put-put",
                HonkNoise = "MEEBEHP",
                IsDriveable = false
            };



            CarLot carLot2 = new CarLot();

            carLot2.CarList.Add(Car2);

            foreach (var car in carLot2.CarList)
            {
                Console.WriteLine($"The second car was made in {Car2.Year}");
                Console.WriteLine();
                Console.WriteLine($"The second brand of the car is {Car2.Make}");
                Console.WriteLine();
                Console.WriteLine($"The second model of the car is {Car2.Model}");
                Console.WriteLine();
                Console.WriteLine($"Is the second car driveable? {Car2.IsDriveable}");
                Console.WriteLine();


            }

            Car2.MakeEngineNoise($"{Car2.EngineNoise}");
            Console.WriteLine();
            Car2.MakeEngineNoise($"{Car2.HonkNoise}");
            Console.WriteLine();



            Console.WriteLine();
            Console.WriteLine(CarLot.carsInLot);
            Console.WriteLine();


            var car3 = new Cars(2023, "Chevorlet", "Tahoe", "Vroom", "BEEP", true);



            CarLot carLot3 = new CarLot();

            carLot3.CarList.Add(car3);

            foreach (var car in carLot1.CarList)
            {
                Console.WriteLine($"The third car was made in {car3.Year}");
                Console.WriteLine();
                Console.WriteLine($"The brand of third the car is {car3.Make}");
                Console.WriteLine();
                Console.WriteLine($"The model of the third car is {car3.Model}");
                Console.WriteLine();
                Console.WriteLine($"Is the third car driveable? {car3.IsDriveable}");
                Console.WriteLine();

            }


            car3.MakeEngineNoise($"{car3.EngineNoise}");
            Console.WriteLine();
            car3.MakeEngineNoise($"{car3.HonkNoise}");
            Console.WriteLine();


            Console.WriteLine();
            Console.WriteLine(CarLot.carsInLot);
            Console.WriteLine();


        }
    }
}
