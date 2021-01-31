using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;
        public InMemoryCarDal()
        {
            _car = new List<Car>
            {
                new Car{Id =1, BrandId =1, ColorId = 1, ModelYear =2000,DailyPrice =  2000},
                new Car{Id =2, BrandId =1, ColorId = 2, ModelYear =2005,DailyPrice =  4000},
                new Car{Id =3, BrandId =2, ColorId = 2, ModelYear =2010,DailyPrice =  6000},
                new Car{Id =4, BrandId =3, ColorId = 3, ModelYear =2015,DailyPrice =  8000},
                new Car{Id =5, BrandId =3, ColorId = 3, ModelYear =2020,DailyPrice =  10000},
            };
        }
        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            var deleteCar = _car.Where(p => p.Id == car.Id).FirstOrDefault();
            _car.Remove(deleteCar);
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetById(Car car)
        {
            return _car.Where(p => p.Id == car.Id).ToList();
        }

        public void Update(Car car)
        {
            var updateCar = _car.FirstOrDefault(p => p.Id == car.Id);
            updateCar.ModelYear = car.ModelYear;
        }
    }
}
