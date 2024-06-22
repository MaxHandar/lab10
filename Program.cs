using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    internal class Program
    {

        //самый дорогой внедорожник
        static OffRoad MostExpensiveOffRoad(Vehicle[] vehicles)
        {
            double maxPrice = 0;
            Vehicle mostExpensiveOffRoad = null;
            foreach (Vehicle vehicle in vehicles)
            {
                if (vehicle is OffRoad && vehicle.Price > maxPrice)
                {
                    maxPrice = vehicle.Price;
                    mostExpensiveOffRoad = vehicle;
                }
            }
            return mostExpensiveOffRoad as OffRoad; 
        }

        //средняя скорость легкового автомобиля
        static double AverageSpeedOfPassengerCar(Vehicle[] vehicles)
        {
            int speedSum = 0;
            int numOfCars = 0;
            foreach (Vehicle vehicle in vehicles)
            {
                if (vehicle is PassengerCar PCar)
                {
                    speedSum += PCar.MaxSpeed;
                    numOfCars++;
                }
            }
            return (double)speedSum/numOfCars; 
        }

        //грузовики превышающие заданную грузоподъемность
        static void TrucksExceeedingTonnageLimit(Vehicle[] vehicles, int givenTonnage)
        {
            foreach (Vehicle vehicle in vehicles)
            {
                if (vehicle is Truck truck && truck.Tonnage > givenTonnage)
                {
                    truck.Show();
                    Console.WriteLine("------------------------------------------------------");
                }
            }
        }
        static void Main(string[] args)
        {
            int seed = (int)DateTime.Now.Ticks; // обновление рандомного ввода
            Random rnd = new Random(seed);

            Vehicle vehicle1 = new Vehicle();
            PassengerCar car1 = new PassengerCar();
            OffRoad offRoad1 = new OffRoad();
            Truck truck1 = new Truck();

            Vehicle[] vehicles = new Vehicle[20];
            vehicles[0] = vehicle1;
            vehicles[1] = car1;
            vehicles[2] = offRoad1;
            vehicles[3] = truck1;

            for (int i = 4; i < 20; i++)
            {
                switch (rnd.Next(1, 4))
                {
                    case 1:
                        {
                            Vehicle vehicle = new Vehicle();
                            vehicle.RandomInit(rnd);
                            vehicles[i] = vehicle;
                            break;
                        }
                    case 2:
                        {
                            PassengerCar car = new PassengerCar();
                            car.RandomInit(rnd);
                            vehicles[i] = car;
                            break;
                        }
                    case 3:
                        {
                            OffRoad offRoad = new OffRoad();
                            offRoad.RandomInit(rnd);
                            vehicles[i] = offRoad;
                            break;
                        }
                    case 4:
                        {
                            Truck truck = new Truck();
                            truck.RandomInit(rnd);
                            vehicles[i] = truck;
                            break;
                        }
                }
            }

            foreach (Vehicle vehicle in vehicles)
            {
                Console.WriteLine("Невиртуальный метод");
                vehicle.Show();
                Console.WriteLine("Виртуальный метод");
                vehicle.ShowVirt();
                Console.WriteLine("------------------------------------------------------");
            }

            Console.WriteLine("Trucks");
            foreach (Vehicle vehicle in vehicles)
            {
                if (vehicle is Truck)
                    vehicle.Show();
            }
            Console.WriteLine("самый дорогой внедорожник");
            MostExpensiveOffRoad(vehicles).Show();
            
            Console.WriteLine("средняя скорость легкового автомобиля");
            Console.WriteLine(AverageSpeedOfPassengerCar(vehicles));
            
            Console.WriteLine("грузовики превышающие заданную грузоподъемность");
            int tonnageLimit = 8;
            TrucksExceeedingTonnageLimit(vehicles, tonnageLimit);
        }
    }
}
