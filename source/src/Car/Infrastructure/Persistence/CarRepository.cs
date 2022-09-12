namespace CarRent.Car.Persistence
{
    using System;
    using System.Collections.Generic;

    using CarRent.Car.Domain;
    using CarRent.Car.Infrastructure.Persistence;

    public class CarRepository : ICarRepository
    {
        //private readonly List<Car> _cars;
        private readonly CarContext _carContext;

        public CarRepository(CarContext carContext)
        {
            _carContext = carContext;
        }

        public void Add(Car car)
        {
            _carContext.Cars.Add(car);
        }

        public IEnumerable<Car> GetAll()
        {
            return _carContext.Cars.ToList();
        }

        public Car GetByCarNumber(string carNumber)
        {
            throw new NotImplementedException();
        }

        public Car GetById(Guid id)
        {
            var car = _carContext.Cars.Find(id);
            return car;
        }

        public void Remove(Car car)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
