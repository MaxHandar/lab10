using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLab10
{
    public class PassengerCar : Vehicle, IComparable, ICloneable
    {
        protected int numOfSeats;
        protected int maxSpeed;

        public int NumOfSeats
        {
            get => numOfSeats;
            set
            {
                if (value < 1)
                    numOfSeats = 1;
                else
                    numOfSeats = value;
            }
        }
        public int MaxSpeed
        {
            get => maxSpeed;
            set
            {
                if (value < 0)
                    maxSpeed = 0;
                else
                    maxSpeed = value;
            }
        }
        public PassengerCar() : base()
        {
            NumOfSeats = 5;
            MaxSpeed = 100;
        }
        public PassengerCar(string brand,
                            int year,
                            string color,
                            double price,
                            double groundClearance,
                            int id,
                            int numOfSeats,
                            int maxSpeed) : base(brand,
                                                year,
                                                color,
                                                price,
                                                groundClearance,
                                                id)
        {
            NumOfSeats = numOfSeats;
            MaxSpeed = maxSpeed;
        }
        public new void Show()
        {
            base.Show();
            Console.WriteLine($"PassengerCar Кол-во сидений = {NumOfSeats}");
            Console.WriteLine($"PassengerCar Макс. скорость = {MaxSpeed}");
        }
        public override void ShowVirt()
        {
            Console.WriteLine($"PassengerCar Бренд - {Brand}");
            Console.WriteLine($"PassengerCar Год - {Year}");
            Console.WriteLine($"PassengerCar Цвет - {Color}");
            Console.WriteLine($"PassengerCar Стоимость - {Price}");
            Console.WriteLine($"PassengerCar Дорожный просвет - {GroundClearance}");
            Console.WriteLine($"PassengerCar ID = {id}");
            Console.WriteLine($"PassengerCar Кол-во сидений = {NumOfSeats}");
            Console.WriteLine($"PassengerCar Макс. скорость = {MaxSpeed}");
        }
        public new void Init()
        {
            base.Init();
            NumOfSeats = InputData.NumInput("Количество сидений?");
            MaxSpeed = InputData.NumInput("Макс. скорость?");
        }
        public override string ToString()
        {
            return base.ToString() + $", сидений={NumOfSeats}, макс.скорость={MaxSpeed}";
        }
        public new void RandomInit(Random rnd)
        {
            base.RandomInit(rnd);
            NumOfSeats = rnd.Next(1, 5);
            MaxSpeed = rnd.Next(300);
        }
        public override bool Equals(object obj)
        {
            if (obj is string)
                return Brand == obj as string;
            if (obj is int)
                return Year == (int)obj;
            Vehicle PCar = obj as Vehicle;
            
            if (PCar != null)
                return this.Price == PCar.Price &&
                    this.GroundClearance == PCar.GroundClearance &&
                    this.Color == PCar.Color &&
                    this.Year == PCar.Year &&
                    this.Brand == PCar.Brand &&
                    this.id.Number == PCar.id.Number;
            else
                return false;
        }
        //public new int CompareTo(object obj)
        //{
        //    if (obj != null && !(obj is PassengerCar)) return -1;
        //    if (obj is int)
        //        return Year - (int)obj;
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
        //public override bool Equals(string brand)
        //{
        //    if (brand == null) return false;

        //    return this.Brand == brand;
        //}
        public new object Clone() //глубокое копирование
        {
            return new PassengerCar(Brand, Year, Color, Price, GroundClearance, id.Number, NumOfSeats, MaxSpeed);
        }
        public Vehicle BaseVehicle() //для 11 лабы
        {
            return new Vehicle(Brand, Year, Color, Price, GroundClearance, id.Number);
        }

        public override int GetHashCode()
        {
            int hashCode = -1989757314;
            hashCode = hashCode * -1521134295 + base.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<IDNumber>.Default.GetHashCode(id);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Brand);
            hashCode = hashCode * -1521134295 + Year.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Color);
            hashCode = hashCode * -1521134295 + Price.GetHashCode();
            hashCode = hashCode * -1521134295 + GroundClearance.GetHashCode();
            hashCode = hashCode * -1521134295 + NumOfSeats.GetHashCode();
            hashCode = hashCode * -1521134295 + MaxSpeed.GetHashCode();
            return hashCode;
        }
        //public override int GetHashCode()
        //{
        //    //return base.GetHashCode();
        //    int hash = 100;
        //    hash = hash * 20 + Brand.GetHashCode();
        //    hash = hash * 20 + Year.GetHashCode();
        //    hash = hash * 20 + Color.GetHashCode();
        //    hash = hash * 20 + GroundClearance.GetHashCode();
        //    hash = hash * 20 + id.Number.GetHashCode();
        //    hash = hash * 20 + NumOfSeats.GetHashCode();
        //    hash = hash * 20 + MaxSpeed.GetHashCode();
        //    return hash;
        //}

        //public override bool Equals(object obj)
        //{
        //    return Equals(obj as PassengerCar);
        //}
    }
}
