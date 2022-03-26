using System;
using Type;

namespace Console_Task_9
{
    public class Program
    {
        static void Main(string[] args)
        {
            var car1 = new Car();
            var car2 = new Car() { Price = 5000 };
            var car3 = new Car() { Name = "mercedes", Type = "sedan", Price = 8000 };

            var moto1 = new Motorcycle();
            var moto2 = new Motorcycle() { Price = 1000 };
            var moto3 = new Motorcycle() { Name = "Java", Type = "Two tick", Price = 3000 };
            Console.WriteLine(moto3.TransportInfo()); 

            var garage = new MyGarage<Transport>();
            Console.WriteLine(garage.Count);  //0
            garage.AddElement(car1);
            garage.AddElement(car2);
            garage.AddElement(car3);
            garage.AddElement(moto1);
            garage.AddElement(moto2);
            garage.AddElement(moto3);

            Console.WriteLine(garage.Count); //6
            Console.WriteLine(garage.InfoElement(10)); //  ArgumentOutOfRangeException
            Console.WriteLine(garage.InfoElement(4));

            Console.WriteLine(garage.PrintElement()); //All element
        }
    }
}