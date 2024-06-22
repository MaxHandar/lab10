using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    public class Truck:Vehicle
    {
        protected int tonnage;
        public int Tonnage
        {
            get => tonnage;
            set
            {
                if (tonnage < 0)
                    tonnage = 0;
                else
                    tonnage = value;
            }
        }
        public Truck() : base()
        {
            Tonnage = 5;
        }
        public Truck(string brand,
                            int year,
                            string color,
                            double price,
                            double groundClearance,
                            int tonnage) : base(brand,
                                                year,
                                                color,
                                                price,
                                                groundClearance)
        {
            Tonnage = tonnage;
        }
        public new void Show()
        {
            base.Show();
            Console.WriteLine($"Truck грузоподъемность = {Tonnage}");
        }
        public override void ShowVirt()
        {
            Console.WriteLine($"Truck Бренд - {Brand}");
            Console.WriteLine($"Truck Год - {Year}");
            Console.WriteLine($"Truck Цвет - {Color}");
            Console.WriteLine($"Truck Стоимость - {Price}");
            Console.WriteLine($"Truck Дорожный просвет - {GroundClearance}");
            Console.WriteLine($"Truck грузоподъемность = {Tonnage}");
        }
        public new void Init()
        {
            base.Init();
            Tonnage = InputData.NumInput();
        }
        public new void RandomInit(Random rnd)
        {
            base.RandomInit(rnd);
            Tonnage = rnd.Next(1, 50);
        }
        //public bool Equals(Truck car1, Truck car2)
        //{
        //    return base.Equals(car1, car2) &&
        //        car1.Tonnage == car2.Tonnage;
        //}
        public override bool Equals(object obj)
        {
            Truck truck = obj as Truck;
            if (truck != null)
                return this.Price == truck.Price &&
                    this.GroundClearance == truck.GroundClearance &&
                    this.Color == truck.Color &&
                    this.Year == truck.Year &&
                    this.Brand == truck.Brand &&
                    this.Tonnage == truck.Tonnage;
            else
                return false;
        }
    }
}