namespace Interfaces
{
    public interface IVehicle
    {
        public int Model { get; set; }
        string ShowInfo();
    }

    public class Mazda : IVehicle
    {
        public int Model { get; set; }

        public Mazda(int model)
        {
            Model = model;
        }

        public string ShowInfo() => $"Vehículo mazda modelo {Model}";
    }

    public class Chevrolet : IVehicle
    {
        public int Model { get; set; }

        public Chevrolet(int model)
        {
            Model = model;
        }

        public string ShowInfo() => $"Vehículo Chevrolet modelo {Model}";
    }

    public class Mercedes : IVehicle
    {
        public int Model { get; set; }

        public Mercedes(int model)
        {
            Model = model;
        }

        public string ShowInfo() => $"Vehículo Mercedes modelo {Model}";
    }

    public abstract class VehicleCreatorFactory
    {
        public abstract int Model { get; set; }
        public abstract IVehicle CreateInstance();

        public string PrintInfo()
        {
            var product = CreateInstance();
            var result = $"Información del vehículo: {product.ShowInfo()}";

            return result;
        }
    }

    public class MazdaFactory : VehicleCreatorFactory
    {
        public override int Model { get; set; }

        public MazdaFactory(int model)
        {
            Model = model;
        }

        public override IVehicle CreateInstance()
            => new Mazda(Model);
    }

    public class ChevroletFactory : VehicleCreatorFactory
    {
        public override int Model { get; set; }

        public ChevroletFactory(int model)
        {
            Model = model;
        }

        public override IVehicle CreateInstance()
            => new Chevrolet(Model);
    }

    public class MercedesFactory : VehicleCreatorFactory
    {
        public override int Model { get; set; }

        public MercedesFactory(int model)
        {
            Model = model;
        }

        public override IVehicle CreateInstance()
            => new Mercedes(Model);
    }
}
