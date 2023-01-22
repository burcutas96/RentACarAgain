using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>()
            {
                new Car{Id = 1, BrandId = 2, ColorId = 1, DailyPrice = 600, ModelYear = "2015", Description = "Hyundai Acente"},
                new Car{Id = 2, BrandId = 1, ColorId = 2, DailyPrice = 1600, ModelYear = "2020", Description = "Mercedes AMG"},
                new Car{Id = 3, BrandId = 3, ColorId = 2, DailyPrice = 500, ModelYear = "2016", Description = "Toyota Corolla"},
                new Car{Id = 4, BrandId = 2, ColorId = 3, DailyPrice = 450, ModelYear = "2012", Description = "Hyundai i20"},
                new Car{Id = 5, BrandId = 4, ColorId = 1, DailyPrice = 700, ModelYear = "2014", Description = "Ford Focus"}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            var carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);

            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllCars()
        {
            return _cars;
        }

        public Car GetById(int carId)
        {
            return _cars.SingleOrDefault(c => c.Id == carId);
        }

        public void Update(Car car)
        {
            var carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);

            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;

        }
    }
}
