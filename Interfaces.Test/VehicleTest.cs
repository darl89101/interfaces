using NSubstitute;
using NUnit.Framework;
using System;

namespace Interfaces.Test
{
    public class VehicleTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Verify_Mazda_Instance()
        {
            var model = 2020;
            var vechicleName = "Mazda";
            VehicleCreatorFactory vehicle = GetVehicle(vechicleName, model);

            Assert.AreEqual(vechicleName, vehicle.CreateInstance().GetType().Name);
            Assert.AreEqual(model, vehicle.CreateInstance().Model);
        }

        [Test]
        public void Verify_Mercedes_Instance()
        {
            var model = 2020;
            var vechicleName = "Mercedes";
            VehicleCreatorFactory vehicle = GetVehicle(vechicleName, model);

            Assert.AreEqual(vechicleName, vehicle.CreateInstance().GetType().Name);
            Assert.AreEqual(model, vehicle.CreateInstance().Model);
        }

        [Test]
        public void Verify_Chevrolet_Instance()
        {
            var model = 2020;
            var vechicleName = "Chevrolet";
            VehicleCreatorFactory vehicle = GetVehicle(vechicleName, model);

            Assert.AreEqual(vechicleName, vehicle.CreateInstance().GetType().Name);
            Assert.AreEqual(model, vehicle.CreateInstance().Model);
        }

        [Test]
        public void Verify_Mazda_Instance_NSubstitute()
        {
            var model = 2020;
            var vechicleName = "Mazda";
            VehicleCreatorFactory vehicle = Substitute.For<VehicleCreatorFactory>();
            vehicle.CreateInstance().Returns(new Mazda(model));

            Assert.AreEqual(vechicleName, vehicle.CreateInstance().GetType().Name);
            Assert.AreEqual(model, vehicle.CreateInstance().Model);
        }

        private VehicleCreatorFactory GetVehicle(string vehicleName, int model)
            => vehicleName switch
            {
                "Mazda" => new MazdaFactory(model),
                "Mercedes" => new MercedesFactory(model),
                "Chevrolet" => new ChevroletFactory(model),
                _ => throw new NotImplementedException($"Opción no implementada: {vehicleName}")
            };
    }
}