using System;
using System.Drawing;

namespace Car_Lab_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VehicleFactory vehicleFactory = new VehicleFactory();

            Console.WriteLine("=== VEHICLES ===");
            Transport audi = vehicleFactory.CreateTransport(1500, 4.5f, 240, Color.Red, 1, 2);   // sedan, front
            Transport honda = vehicleFactory.CreateTransport(1400, 4.4f, 220, Color.Blue, 2, 1); // hatchback, back
            Transport tesla = vehicleFactory.CreateTransport(1800, 4.7f, 260, Color.Black, 1, 3); // coupe, front
            Console.WriteLine(audi);
            Console.WriteLine(honda);
            Console.WriteLine(tesla);
            Console.WriteLine();

            CargoFactory cargoFactory = new CargoFactory();
            Transport volvo = cargoFactory.CreateTransport(8000, 7.5f, 140, 20, 600, 3);
            Transport man = cargoFactory.CreateTransport(7500, 7.0f, 130, 18, 550, 3);
            Transport scania = cargoFactory.CreateTransport(8200, 7.8f, 150, 22, 650, 4);
            Console.WriteLine("=== CARGO ===");
            Console.WriteLine(volvo);
            Console.WriteLine(man);
            Console.WriteLine(scania);
            Console.WriteLine();

            TankFactory tankFactory = new TankFactory();
            Transport abrams = tankFactory.CreateTransport(62000, 9.8f, 72, 120f, 10, 4);
            Transport merkava = tankFactory.CreateTransport(65000, 9.5f, 64, 120f, 8, 4);
            Transport tiger = tankFactory.CreateTransport(57000, 8.6f, 45, 88f, 6, 5);
            Console.WriteLine("=== TANKS ===");
            Console.WriteLine(abrams);
            Console.WriteLine(merkava);
            Console.WriteLine(tiger);
            Console.WriteLine();
        }
    }
}
