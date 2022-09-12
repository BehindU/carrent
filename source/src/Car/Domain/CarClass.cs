namespace CarRent.Car.Domain
{
    using CarRent.Common.Domain;

    public class CarClass : Entity, IAggregateRoot
    {
        public string Name { get; }

        public decimal DailyPrice { get; }
    }
}
