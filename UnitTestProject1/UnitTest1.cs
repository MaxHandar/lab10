using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryLab10;
using System;
using System.Diagnostics;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            Vehicle expected = new Vehicle();
            //Actual
            Vehicle actual = new Vehicle();
            //Assert
            Assert.AreEqual(expected.Brand, actual.Brand);
            Assert.AreEqual(expected.Year, actual.Year);
            Assert.AreEqual(expected.Color, actual.Color);
            Assert.AreEqual(expected.Price, actual.Price);
            Assert.AreEqual(expected.GroundClearance, actual.GroundClearance);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            Vehicle expected = new Vehicle("1", 2 , "3", 4 , 5, 6);
            //Actual
            Vehicle actual = new Vehicle("1", 2, "3", 4, 5, 6);
            //Assert
            Assert.AreEqual(expected.Brand, actual.Brand);
            Assert.AreEqual(expected.Year, actual.Year);
            Assert.AreEqual(expected.Color, actual.Color);
            Assert.AreEqual(expected.Price, actual.Price);
            Assert.AreEqual(expected.GroundClearance, actual.GroundClearance);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            PassengerCar expected = new PassengerCar("1", 2 , "3", 4 , 5, 6, 7, 8);
            //Actual
            PassengerCar actual = new PassengerCar("1", 2, "3", 4, 5, 6, 7, 8);
            //Assert
            Assert.AreEqual(expected.Brand, actual.Brand);
            Assert.AreEqual(expected.Year, actual.Year);
            Assert.AreEqual(expected.Color, actual.Color);
            Assert.AreEqual(expected.Price, actual.Price);
            Assert.AreEqual(expected.GroundClearance, actual.GroundClearance);
            Assert.AreEqual(expected.NumOfSeats, actual.NumOfSeats);
            Assert.AreEqual(expected.MaxSpeed, actual.MaxSpeed);

        }
        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
            PassengerCar expected = new PassengerCar();
            //Actual
            PassengerCar actual = new PassengerCar();
            //Assert
            Assert.AreEqual(expected.Brand, actual.Brand);
            Assert.AreEqual(expected.Year, actual.Year);
            Assert.AreEqual(expected.Color, actual.Color);
            Assert.AreEqual(expected.Price, actual.Price);
            Assert.AreEqual(expected.GroundClearance, actual.GroundClearance);
            Assert.AreEqual(expected.NumOfSeats, actual.NumOfSeats);
            Assert.AreEqual(expected.MaxSpeed, actual.MaxSpeed);
        }
        [TestMethod]
        public void TestMethod5()
        {
            //Arrange
            OffRoad expected = new OffRoad("1", 2, "3", 4, 5, 6, 7, 8, true, "10");
            //Actual
            OffRoad actual = new OffRoad("1", 2, "3", 4, 5, 6, 7, 8, true, "10");
            //Assert
            Assert.AreEqual(expected.Brand, actual.Brand);
            Assert.AreEqual(expected.Year, actual.Year);
            Assert.AreEqual(expected.Color, actual.Color);
            Assert.AreEqual(expected.Price, actual.Price);
            Assert.AreEqual(expected.GroundClearance, actual.GroundClearance);
            Assert.AreEqual(expected.NumOfSeats, actual.NumOfSeats);
            Assert.AreEqual(expected.MaxSpeed, actual.MaxSpeed);
            Assert.AreEqual(expected.AllWD, actual.AllWD);
            Assert.AreEqual(expected.GroundType, actual.GroundType);

        }
        [TestMethod]
        public void TestMethod6()
        {
            //Arrange
            OffRoad expected = new OffRoad();
            //Actual
            OffRoad actual = new OffRoad();
            //Assert
            Assert.AreEqual(expected.Brand, actual.Brand);
            Assert.AreEqual(expected.Year, actual.Year);
            Assert.AreEqual(expected.Color, actual.Color);
            Assert.AreEqual(expected.Price, actual.Price);
            Assert.AreEqual(expected.GroundClearance, actual.GroundClearance);
            Assert.AreEqual(expected.NumOfSeats, actual.NumOfSeats);
            Assert.AreEqual(expected.MaxSpeed, actual.MaxSpeed);
            Assert.AreEqual(expected.AllWD, actual.AllWD);
            Assert.AreEqual(expected.GroundType, actual.GroundType);
        }

        [TestMethod]
        public void TestMethod7()
        {
            //Arrange
            Truck expected = new Truck("1", 2, "3", 4, 5, 6, 7);
            //Actual
            Truck actual = new Truck("1", 2, "3", 4, 5, 6, 7);
            //Assert
            Assert.AreEqual(expected.Brand, actual.Brand);
            Assert.AreEqual(expected.Year, actual.Year);
            Assert.AreEqual(expected.Color, actual.Color);
            Assert.AreEqual(expected.Price, actual.Price);
            Assert.AreEqual(expected.GroundClearance, actual.GroundClearance);
        }
        [TestMethod]
        public void TestMethod8()
        {
            //Arrange
            Truck expected = new Truck();
            //Actual
            Truck actual = new Truck();
            //Assert
            Assert.AreEqual(expected.Brand, actual.Brand);
            Assert.AreEqual(expected.Year, actual.Year);
            Assert.AreEqual(expected.Color, actual.Color);
            Assert.AreEqual(expected.Price, actual.Price);
            Assert.AreEqual(expected.GroundClearance, actual.GroundClearance);
        }
        [TestMethod]
        public void TestMethod9()
        {
            //Arrange
            Truck expected = new Truck();
            //Actual
            Truck actual = new Truck();
            //Assert
            Assert.AreEqual(expected.Brand, actual.Brand);
            Assert.AreEqual(expected.Year, actual.Year);
            Assert.AreEqual(expected.Color, actual.Color);
            Assert.AreEqual(expected.Price, actual.Price);
            Assert.AreEqual(expected.GroundClearance, actual.GroundClearance);
        }
        [TestMethod]
        public void TestMethod10()
        {
            //Arrange
            Truck expected = new Truck();
            //Actual
            Truck actual = new Truck();
            //Assert
            bool equals = Truck.Equals(expected, actual);
            Assert.IsTrue(equals);
        }
        [TestMethod]
        public void TestMethod11()
        {
            //Arrange
            IDNumber IDExpected = new IDNumber(-13);
            //Actual
            IDNumber IDActual = new IDNumber(0);
            //Assert
            bool equals = IDNumber.Equals(IDExpected, IDActual);
            Assert.IsTrue(equals);
        }
        [TestMethod]
        public void TestMethod12()
        {
            //Arrange
            Random rnd = new Random();
            Vehicle[] vehicles = new Vehicle[3];
            Vehicle[] vehiclesClone = new Vehicle[3];
            for (int i = 0; i< vehicles.Length; i++)
            {
                vehicles[i] = new Vehicle();
                vehicles[i].RandomInit(rnd);
                vehiclesClone[i] = vehicles[i].Clone() as Vehicle;
            }
            Array.Sort(vehiclesClone);
            Array.Sort(vehicles, new SortByYear());
            bool isSortedByYear=true, isSortedByBrand=true;
            //Actual
            for (int i = 0;i<vehicles.Length-1;i++)
            {
                isSortedByYear = (isSortedByYear && (vehicles[i].Year <= vehicles[i + 1].Year));
                isSortedByBrand = (isSortedByYear && (vehiclesClone[i].Brand.CompareTo(vehiclesClone[i + 1].Brand)<=0));
            }
            //Assert
            
            Assert.IsTrue(isSortedByYear&&isSortedByBrand);
        }
        [TestMethod]
        public void TestMethod13()
        {
            //Arrange
            PassengerCar expected = new PassengerCar();
            //Actual
            PassengerCar actual = new PassengerCar();
            //Assert
            bool equals = PassengerCar.Equals(expected, actual);
            Assert.IsTrue(equals);
        }
        [TestMethod]
        public void TestMethod14()
        {
            //Arrange
            Vehicle expected = new Vehicle();
            //Actual
            Vehicle actual = new Vehicle();
            //Assert
            bool equals = Vehicle.Equals(expected, actual);
            Assert.IsTrue(equals);
        }
        [TestMethod]
        public void TestMethod15()
        {
            //Arrange
            OffRoad expected = new OffRoad();
            //Actual
            OffRoad actual = new OffRoad();
            //Assert
            bool equals = OffRoad.Equals(expected, actual);
            Assert.IsTrue(equals);
        }
        [TestMethod]
        public void TestMethod16()
        {
            //Arrange
            string VehicleToStr = $"бренд={"1"}, год={1800}, цвет={"3"}, цена={0}, просвет={0}, id={0}";
            string PCToStr = VehicleToStr + $", сидений={1}, макс.скорость={0}";
            string ORToStr = PCToStr + $", Полный привод={true}, Тип бездорожья={"10"}";
            string TruckToStr = VehicleToStr + $", грузопод-сть={0}";

            //Actual
            OffRoad expectedOR = new OffRoad("1", 2, "3", -4, -5, -6, -7, -8, true, "10");
            PassengerCar expectedPC = new PassengerCar("1", 2, "3", -4, -5, -6, -7, -8);
            Truck expectedTruck = new Truck("1", 2, "3", -4, -5, -6, -50);
            Vehicle expectedVehicle = new Vehicle("1", 2, "3", -4, -5, -6);

            //Assert
            Assert.AreEqual(expectedOR.ToString(), ORToStr);
            Assert.AreEqual(expectedPC.ToString(), PCToStr);
            Assert.AreEqual(expectedTruck.ToString(), TruckToStr);
            Assert.AreEqual(expectedVehicle.ToString(), VehicleToStr);
        }

        //[TestMethod]
        //public void TestMethod3()
        //{
        //    //Arrange
        //    //Actual
        //    //Assert
        //}
        //    [TestMethod]
        //    public void TestMethod1()
        //    {
        //        //Arrange
        //        //Actual
        //        //Assert
        //    }
    }
}
