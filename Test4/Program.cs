using System;

namespace Test4
{
    class Car
    {
        public string type;
        public string brand;
        public string color;
        public int ammountOfWheels;
        public string hornSound;
        public int year;


    }
    
    
    class Program
    {
        static void Main(string[] args)
        {

            Car myFirstCar = new Car();
            myFirstCar.type = "S40";
            myFirstCar.brand = "Volvo";
            myFirstCar.ammountOfWheels = 4;
            myFirstCar.year = 2001;
            myFirstCar.hornSound = "Toot Toot";
            myFirstCar.color = "Red";

            Console.WriteLine(myFirstCar.color);
            Console.WriteLine(myFirstCar.hornSound);

            Car mySecondCar = new Car();

        }
    }
}
