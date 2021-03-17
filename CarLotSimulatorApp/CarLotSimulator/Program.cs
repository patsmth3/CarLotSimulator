using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            var lot = new CarLot();

            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars

            //*************BONUS*************//
            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //Dot notation method
            var patsCar = new Car();
            patsCar.Year = 2017;
            patsCar.Make = "Porsche";
            patsCar.Model = "Cayenne Turbo";
            patsCar.EngineNoise = "quiet";
            patsCar.HonkNoise = "beep";
            patsCar.IsDriveable = true;

            //adding patsCar to carLot
            lot.Cars.Add(patsCar);

            //Object initializer method
            var khyresCar = new Car()
            {
                Year = 2019,
                Make = "Jeep",
                Model = "Compass",
                EngineNoise = "vroom",
                HonkNoise = "beep beep",
                IsDriveable = true
            };

            //adding khyresCar to carLot
            lot.Cars.Add(khyresCar);

            //Constructor method
            var sarahsCar = new Car(2018, "Honda", "Accord", "vroom vroom",
                "honk honk", true);

            //adding sarahsCar to carLot
            lot.Cars.Add(sarahsCar);

            //Call each of the methods for each car
            patsCar.MakeEngineNoise(patsCar.EngineNoise);
            patsCar.MakeHonkNoise(patsCar.HonkNoise);

            khyresCar.MakeEngineNoise(khyresCar.EngineNoise);
            khyresCar.MakeHonkNoise(khyresCar.HonkNoise);

            sarahsCar.MakeEngineNoise(sarahsCar.EngineNoise);
            sarahsCar.MakeHonkNoise(sarahsCar.HonkNoise);

            //*************BONUS X 2*************//
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            foreach (var car in lot.Cars)
            {
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model: {car.Model}");
            }
        }
    }
}
