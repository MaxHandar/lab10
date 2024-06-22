using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    public class OffRoad:PassengerCar
    {
        public bool AllWD { get; set; }
        public string GroundType { get; set; }

        public OffRoad() : base()
        {
            AllWD = true;
            GroundType = "mood";
        }
        public OffRoad(string brand,
                        int year,
                        string color,
                        double price,
                        double groundClearance,
                        int numOfSeats,
                        int maxSpeed,
                        bool allWD,
                        string groundType) : base(brand,
                                                year,
                                                color,
                                                price,
                                                groundClearance,
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
        }
        public new void Init()
        {
            base.Init();
            AllWD = InputData.BoolInput();
            GroundType = InputData.StringInput();
        }
        public new void RandomInit(Random rnd)
        {
            base.RandomInit(rnd);
            string[] groundTypes = { "mood", "ice", "snow" };
            AllWD = rnd.Next(0, 1) == 1;
            GroundType = groundTypes[rnd.Next(groundTypes.Length)];
        }
        //public bool Equals(OffRoad car1, OffRoad car2)
        //{
        //    return base.Equals(car1, car2) &&
        //        car1.AllWD == car2.AllWD &&
        //        car1.GroundType == car2.GroundType;
        //}
        public override bool Equals(object obj)
        {
            OffRoad offRoad = obj as OffRoad;
            if (offRoad != null)
                return this.Price == offRoad.Price &&
                    this.GroundClearance == offRoad.GroundClearance &&
                    this.Color == offRoad.Color &&
                    this.Year == offRoad.Year &&
                    this.Brand == offRoad.Brand &&
                    this.NumOfSeats == offRoad.NumOfSeats &&
                    this.MaxSpeed == offRoad.MaxSpeed &&
                    this.AllWD == offRoad.AllWD &&
                    this.GroundType == offRoad.GroundType;
            else
                return false;
        }
    }
}
