namespace CarManager.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class CarManagerTests
    {
        private Car car;

        [SetUp]
        public void SetUp() 
        {
            car = new("BMW", "E60", 3.5, 40.0);
        }


        //Overall
        [Test]
        public void CarCreationShouldBeCorrect()
        {
            string expectedMake = "BMW";
            string expectedModel = "E60";
            double expectedConsumption = 3.5;
            double expectedFuelCapacity = 40.0;

            Assert.AreEqual(expectedMake, car.Make);
            Assert.AreEqual(expectedModel, car.Model);
            Assert.AreEqual(expectedConsumption, car.FuelConsumption);
            Assert.AreEqual(expectedFuelCapacity, car.FuelCapacity);
        }

        [Test]
        public void EmptyCarConstructorReturnsZeroFuelAmount()
        {
            Assert.AreEqual(0, car.FuelAmount);
        }

        //Properties
        [TestCase("")]
        [TestCase(null)]
        public void CarMakeShouldThrowExceptionIfNullOrEmpty(string make)
        {
            ArgumentException exception = Assert.Throws<ArgumentException>(()
                => car = new(make, "E60", 3.5, 40.0));

            Assert.AreEqual("Make cannot be null or empty!", exception.Message);
        }

        [TestCase("")]
        [TestCase(null)]
        public void CarModelShouldThrowExceptionIfNullOrEmpty(string model)
        {
            ArgumentException exception = Assert.Throws<ArgumentException>(()
                => car = new("BMW", model , 3.5, 40.0));

            Assert.AreEqual("Model cannot be null or empty!", exception.Message);
        }

        [TestCase(-20)]
        [TestCase(0)]
        public void CarConsumptionShouldThrowExceptionIfZeroOrNegative(double fuelConsumption)
        {
            ArgumentException exception = Assert.Throws<ArgumentException>(()
                => car = new("BMW", "E60", fuelConsumption, 40.0));

            Assert.AreEqual("Fuel consumption cannot be zero or negative!", exception.Message);
        }

        [Test]
        public void CarFuelAmountShouldThrowExceptionIfNegative()
        {
            Assert.Throws<InvalidOperationException>(()
            => car.Drive(12), "Fuel amount cannot be negative!");
        }

        [TestCase(-20)]
        [TestCase(0)]
        public void CarFuelCapacityShouldThrowExceptionIfZeroOrNegative(double fuelCapacity)
        {
            ArgumentException exception = Assert.Throws<ArgumentException>(()
                => car = new("BMW", "E60", 3.5, fuelCapacity));

            Assert.AreEqual("Fuel capacity cannot be zero or negative!", exception.Message);
        }

        //Refuel
        [Test]
        public void CarRefuelShouldAddFuelAmount()
        {
            int expectedResilt = 12;

            car.Refuel(12);

            Assert.AreEqual(expectedResilt, car.FuelAmount);
        }

        [TestCase(0)]
        [TestCase(-20)]
        public void CarRefuelShouldThrowExceptionIfZeroOrNegative(double fuelToRefuel)
        {
            Assert.Throws<ArgumentException>(()
                => car.Refuel(fuelToRefuel), "Fuel amount cannot be zero or negative!");
        }

        [Test]
        public void CarFuelAmountShouldNotBeMoreThanFuelCapacity()
        {
            double expectedResult = 40.0;

            car.Refuel(50.0);

            Assert.AreEqual(expectedResult, car.FuelAmount);
        }

        //Drive
        [Test]
        public void CarDriveShouldDecreaseFuelAmount()
        {
            double expectedResult = 16.5;

            car.Refuel(20.0);
            car.Drive(100.0);

            Assert.AreEqual(expectedResult, car.FuelAmount);
        }

        [Test]
        public void CarDriveThrowsExceptionIfFuelAmountIsNotEnough()
        {
            Assert.Throws<InvalidOperationException>(()
                => car.Drive(100.0), "You don't have enough fuel to drive!");
        }
    }
}