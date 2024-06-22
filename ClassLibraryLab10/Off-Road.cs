using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLab10
{
    public class OffRoad : PassengerCar, IComparable, ICloneable
    {
        public bool AllWD { get; set; }
        public string GroundType { get; set; }

        public OffRoad() : base()
        {
            AllWD = true;
            GroundType = "mud";
        }
        public OffRoad(string brand,
                        int year,
                        string color,
                        double price,
                        double groundClearance,
                        int id,
                        int numOfSeats,
                        int maxSpeed,
                        bool allWD,
                        string groundType) : base(brand,
                                                year,
                                                color,
                                                price,
                                                groundClearance,
                                                id,
                                                numOfSeats,
                                                maxSpeed)
        {
            AllWD = allWD;
            GroundType = groundType;
        }
        public new void Show()
        {
            base.Show();
            Console.WriteLine($"OffRoad Полный привод = {AllWD}");
            Console.WriteLine($"OffRoad Тип бездорожья = {GroundType}");
        }
        public override void ShowVirt()
        {
            Console.WriteLine($"OffRoad Бренд - {Brand}");
            Console.WriteLine($"OffRoad Год - {Year}");
            Console.WriteLine($"OffRoad Цвет - {Color}");
            Console.WriteLine($"OffRoad Стоимость - {Price}");
            Console.WriteLine($"OffRoad Дорожный просвет - {GroundClearance}");
            Console.WriteLine($"OffRoad Кол-во сидений = {NumOfSeats}");
            Console.WriteLine($"OffRoad Макс. скорость = {MaxSpeed}");
            Console.WriteLine($"OffRoad Полный привод = {AllWD}");
            Console.WriteLine($"OffRoad Тип бездорожья = {GroundType}");
            Console.WriteLine($"OffRoad ID = {id}");
        }
        public new void Init()
        {
            base.Init();
            AllWD = InputData.BoolInput("Полный привод?");
            GroundType = InputData.StringInput("Тип бездорожья?");
        }
        public override string ToString()
        {
            return base.ToString() + $", Полный привод={AllWD}, Тип бездорожья={GroundType}";
        }
        public new void RandomInit(Random rnd)
        {
            base.RandomInit(rnd);
            string[] groundTypes = { "mud", "ice", "snow" };
            AllWD = rnd.Next(2) == 1;
            GroundType = groundTypes[rnd.Next(groundTypes.Length)];
        }
        public override bool Equals(object obj)
        {
            if (obj is string)
                return Brand == obj as string;
            if (obj is int)
                return Year == (int)obj;
            Vehicle offRoad = obj as Vehicle;
            if (offRoad != null)
                return this.Price == offRoad.Price &&
                    this.GroundClearance == offRoad.GroundClearance &&
                    this.Color == offRoad.Color &&
                    this.Year == offRoad.Year &&
                    this.Brand == offRoad.Brand &&
                    this.id.Number == offRoad.id.Number;
            else
                return false;
        }
        //public override bool Equals(string brand)
        //{

        //    if (brand == null) return false;

        //    return this.Brand == brand;
        //}
        //public new int CompareTo(object obj)
        //{
        //    if (obj != null && !(obj is OffRoad)) return -1;
        //    if (obj is int)
        //        return Year - (int)obj/*(int)obj*/;
        //    if (obj is PassengerCar pCar)
        //        return Year - pCar.Year;
        //    if (obj is OffRoad offRoad)
        //        return Year - offRoad.Year;
        //    if (obj is Truck truck)
        //        return Year - truck.Year;
        //    if (obj is Vehicle vehicle)
        //        return Year - vehicle.Year;
        //    return String.Compare(this.Brand, obj as String);
        //}
        public override int CompareTo(object obj)
        {
            if (obj == null) return 1; // Vehicle is greater than null
            if (!(obj is Vehicle)) return -1; // Vehicle is not comparable with other types

            Vehicle otherVehicle = (Vehicle)obj;
            return this.Year.CompareTo(otherVehicle.Year);
        }
        public new object Clone() //глубокое копирование
        {
            return new OffRoad(Brand, Year, Color, Price, GroundClearance, id.Number, NumOfSeats, MaxSpeed, AllWD, GroundType);
        }
    }
}
