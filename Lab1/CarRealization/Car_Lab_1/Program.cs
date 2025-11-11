using System;
using System.Drawing;

namespace Car_Lab_1
{
    internal class Program
    {
        private const string _cargoSection = "CARGO";

        private const string _vehicleSection = "VEHICLES";

        private const string _tankSection = "TANKS";
        static void Main(string[] args)
        {
            var display = DisplayManager.Instance;

            VehicleFactory vehicleFactory = new VehicleFactory();
            CargoFactory cargoFactory = new CargoFactory();
            TankFactory tankFactory = new TankFactory();

            display.ShowSection(_vehicleSection);
            Transport audi = vehicleFactory.CreateTransport(1500, 4.5f, 240, Color.Red, 1, 2);
            Transport honda = vehicleFactory.CreateTransport(1400, 4.4f, 220, Color.Blue, 2, 1);
            Transport tesla = vehicleFactory.CreateTransport(1800, 4.7f, 260, Color.Black, 1, 3);
            display.ShowTransport(audi, honda, tesla);

            display.ShowSection(_cargoSection);
            Transport volvo = cargoFactory.CreateTransport(8000, 7.5f, 140, 20, 600, 3);
            Transport man = cargoFactory.CreateTransport(7500, 7.0f, 130, 18, 550, 3);
            Transport scania = cargoFactory.CreateTransport(8200, 7.8f, 150, 22, 650, 4);
            display.ShowTransport(volvo, man, scania);

            display.ShowSection(_tankSection);
            Transport abrams = tankFactory.CreateTransport(62000, 9.8f, 72, 120f, 10, 4);
            Transport merkava = tankFactory.CreateTransport(65000, 9.5f, 64, 120f, 8, 4);
            Transport tiger = tankFactory.CreateTransport(57000, 8.6f, 45, 88f, 6, 5);
            display.ShowTransport(abrams, merkava, tiger);
        }
    }
}
