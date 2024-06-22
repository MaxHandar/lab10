using System;
using System.Diagnostics;
using ClassLibraryLab10;

namespace Laba10
{
    internal class Program
    {
        public static int ChooseType(string question = "")
        {
            do
            {
                Console.WriteLine(question);
                Console.WriteLine("1. Vehicle");
                Console.WriteLine("2. PassengerCar");
                Console.WriteLine("3. Off-Road");
                Console.WriteLine("4. Truck");
                int answer = InputData.NumInput();

                if (answer>=1 || answer<=4)
                {
                    return answer;
                }
                else
                {
                    Console.WriteLine("Неправильно задан пункт меню");
                }
            } while (true);
        }
        public static Vehicle VehicleInput(int chosenType)
        {
            switch (chosenType)
            {
                case 1:
                    {
                        Vehicle vehicle = new Vehicle();
                        vehicle.Init();
                        return vehicle;
                    }
                case 2:
                    {
                        PassengerCar vehicle = new PassengerCar();
                        vehicle.Init();
                        return vehicle;
                    }
                case 3:
                    {
                        OffRoad vehicle = new OffRoad();
                        vehicle.Init();
                        return vehicle;
                    }
                case 4:
                    {
                        Truck vehicle = new Truck();
                        vehicle.Init();
                        return vehicle;
                    }
            }
            return null;
        }
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
            return (double)speedSum / numOfCars;
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
            //int seed = (int)DateTime.Now.Ticks; // обновление рандомного ввода
            Random rnd = new Random();

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

            Console.WriteLine("\nЗадания второй части:");
            Console.WriteLine("самый дорогой внедорожник");
            MostExpensiveOffRoad(vehicles).Show();
            Console.WriteLine("------------------------------------------------------");

            Console.WriteLine("средняя скорость легкового автомобиля");
            Console.WriteLine(AverageSpeedOfPassengerCar(vehicles));
            Console.WriteLine("------------------------------------------------------");

            Console.WriteLine("грузовики превышающие заданную грузоподъемность");
            int tonnageLimit = 0;
            TrucksExceeedingTonnageLimit(vehicles, tonnageLimit);
            Console.WriteLine("------------------------------------------------------");

            Console.WriteLine("3 часть");
            int answer = 0;
            do
            {
                Console.WriteLine("Меню сортировки и поиска");
                Console.WriteLine("1.SortByBrand");
                Console.WriteLine("2.SortByYear");
                Console.WriteLine("3.BinarySearch");
                Console.WriteLine("4.PrintArray");
                Console.WriteLine("5.End");
                bool isSorted = false, isSortedByBrand = false;
                answer = InputData.NumInput("Введите пункт");
                switch (answer)
                {
                    case 1:
                        {
                            Array.Sort(vehicles);
                            Console.WriteLine("Массив отсортирован по бренду");
                            break;
                        }
                    case 2:
                        {
                            Array.Sort(vehicles, new SortByYear());
                            Console.WriteLine("Массив отсортирован по году");
                            break;
                        }
                    case 3:
                        {
                            if (isSorted)
                            {
                                Vehicle vehicle = VehicleInput(ChooseType());
                                if (isSortedByBrand)
                                {
                                    int pos = Array.BinarySearch(vehicles, vehicle);
                                    if (pos < 0)
                                        Console.WriteLine("Нет такого элемента");
                                    else
                                        Console.WriteLine($"Позиция: {pos + 1}");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Not Sorted");
                            }
                            break;
                        }
                    case 4:
                        {
                            foreach (Vehicle vehicle in vehicles)
                            {
                                Console.WriteLine(vehicle.ToString());
                                Console.WriteLine("------------------------------------------------------");
                            }
                            break;
                        }

                }
            } while (answer != 5);
            Console.WriteLine("Вы вышли из меню");

            Console.WriteLine("\nМассив из элементов созданной иерархиии и 9 лаб.работы:");
            
            IInit[] array = new IInit[10];
            for (int i = 0; i < 5; i++)
            {
                Vehicle vehicle = new Vehicle();
                vehicle.RandomInit(rnd);
                array[i] = vehicle as IInit;
            }
            for (int i = 0; i < 5; ++i)
            {
                DialClock dc = new DialClock();
                dc.RandomInit(rnd);
                array[i + 5] = dc;
            }
            foreach (IInit item in array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("копирование");
            Vehicle vehicle2 = new Vehicle();
            vehicle2.RandomInit(rnd);
            Vehicle copy = vehicle2.ShallowCopy() as Vehicle;
            Vehicle clone = vehicle2.Clone() as Vehicle;
            Console.WriteLine(vehicle2);
            Console.WriteLine(copy);
            Console.WriteLine(clone);
            Console.WriteLine();
            
            clone.Brand = "clone" + vehicle2.Brand;
            copy.Brand = "copy" + vehicle2.Brand;
            clone.id.Number = 100;
            copy.id.Number = 200;
            Console.WriteLine("После изменения");
            Console.WriteLine(vehicle2);
            Console.WriteLine(copy);
            Console.WriteLine(clone);
        }
    }
}
