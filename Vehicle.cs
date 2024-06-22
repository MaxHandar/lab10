using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    public class Vehicle
    {
        protected string brand;
        protected int year;
        protected string color;
        protected double price;
        protected double groundClearance;

        string[] brands = { "Ауди", "Пежо", "Лада" };
        string[] colors = { "black", "white", "green", "yellow" };

        public string Brand
        {
            get => brand;
            set => brand = value;
        }
        public int Year
        {
            get => year;
            set
            {
                if (year < 1800)
                    year = 1800;
                else 
                    year = value;
            }
        }
        public string Color
        {
            get => color;
            set => color = value;
        }
        public double Price
        {
            get => price;
            set
            {
                if (price < 0)
                    price = 0;
                else
                    price = value;
            }
        }
        public double GroundClearance
        {
            get => groundClearance;
            set
            {
                if (groundClearance < 0) 
                    groundClearance = 0;
                else
                    groundClearance = value;
            }
        }
        public Vehicle()
        {
            Brand = "Lada";
            Year = 1980;
            Color = "Cherry";
            Price = 1000;
            GroundClearance = 170;
        }
        public Vehicle(string brand, int year, string color, double price, double groundClearance)
        {
            Brand = brand;
            Year = year;
            Color = color;
            Price = price;
            GroundClearance = groundClearance;
        }
        public void Show()
        {
            Console.WriteLine($"Vehicle Бренд - {Brand}");
            Console.WriteLine($"Vehicle Год - {Year}");
            Console.WriteLine($"Vehicle Цвет - {Color}");
            Console.WriteLine($"Vehicle Стоимость - {Price}");
            Console.WriteLine($"Vehicle Дорожный просвет - {GroundClearance}");
        }
        public virtual void ShowVirt()
        {
            Console.WriteLine($"Vehicle Бренд - {Brand}");
            Console.WriteLine($"Vehicle Год - {Year}");
            Console.WriteLine($"Vehicle Цвет - {Color}");
            Console.WriteLine($"Vehicle Стоимость - {Price}");
            Console.WriteLine($"Vehicle Дорожный просвет - {GroundClearance}");
        }
        public void Init()
        {
            Brand = InputData.StringInput("Введите бренд");
            Year = InputData.NumInput("Введите год");
            Color = InputData.StringInput("Введите цвет");
            Price = InputData.NumInput("Введите цену");
            GroundClearance = InputData.NumInput("Введите дорожный просвет");
        }
        public void RandomInit(Random rnd)
        {
            Brand = brands[rnd.Next(brands.Length)];
            Year = rnd.Next(1950, 2024);
            Color = colors[rnd.Next(colors.Length)];
            Price = rnd.Next(1000);
            GroundClearance = rnd.Next(1000);
        }
        //public bool Equals(Vehicle car1, Vehicle car2)
        //{
        //    return car1.Price == car2.Price &&
        //        car1.GroundClearance == car2.GroundClearance &&
        //        car1.Color == car2.Color &&
        //        car1.Year == car2.Year &&
        //        car1.Brand == car2.Brand;
        //}
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj is Vehicle vehicle)
                return this.Price == vehicle.Price &&
                    this.GroundClearance == vehicle.GroundClearance &&
                    this.Color == vehicle.Color &&
                    this.Year == vehicle.Year &&
                    this.Brand == vehicle.Brand;
            else
                return false;
        }
    }
}
