using System;

namespace CarsProject // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the year of the vehicle:");
            Car car = new Car();
            int year = int.Parse(Console.ReadLine());
            car.year = year;
            Console.WriteLine("Enter the make of the vehicle:");
            string make = Console.ReadLine();
            car.make = make;
            Console.WriteLine("Enter the model of the vehicle:");
            string model =Console.ReadLine();
            car.model = model;
            Console.WriteLine("Enter the number of doors on the vehicle:");
            int numOfDoors = int.Parse(Console.ReadLine());
            car.numberOfDoors = numOfDoors;
            Console.WriteLine("Enter the price of the vehicle:");
            double price = double.Parse(Console.ReadLine());
            car.price = price;

            Console.WriteLine("Your car is:" + car.year.ToString() + " " + car.make + " " + car.model);

        }
    }
}
