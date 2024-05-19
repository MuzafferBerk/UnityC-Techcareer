using System.Collections.Generic;
using System.Linq;
using OOP_Uygulama1.Models;
using OOP_Uygulama1.Exceptions;

namespace OOP_Uygulama1.Repositories
{
    public class CarRepository
    {
        private List<Car> _cars;

        public CarRepository()
        {
            _cars = new List<Car>();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car GetById(int id)
        {
            Car? car = _cars.Find(x => x.Id == id);
            if (car == null)
            {
                throw new NotFoundException(id);
            }
            return car;
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Update(int id, Car updatedCar)
        {
            Car? car = _cars.Find(x => x.Id == id);
            if (car == null)
            {
                throw new NotFoundException(id);
            }

            car.Model = updatedCar.Model;
            car.Brand = updatedCar.Brand;
            car.ColorName = updatedCar.ColorName;
            car.DailyPrice = updatedCar.DailyPrice;
            car.CreatedTime = updatedCar.CreatedTime;
        }

        public void Delete(int id)
        {
            Car? car = _cars.Find(x => x.Id == id);
            if (car == null)
            {
                throw new NotFoundException(id);
            }
            _cars.Remove(car);
        }
    }
}