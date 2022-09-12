namespace CarRent.Car.Domain
{
    using CarRent.Common.Domain;

    public class Car : Entity, IAggregateRoot
    {
        public string CarNumber { get; }

        public CarClass CarClass { get; }

        public Brand Brand { get; }
        
        public Type Type { get; }
    }
}
