using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;
        public InMemoryCarDal()
        {
            _car = new List<Car>
            {
                new Car{Id =1, BrandID =1, ColorID = 1, ModelYear ="2000",DailyPrice =  2000},
                new Car{Id =2, BrandID =1, ColorID = 2, ModelYear ="2005",DailyPrice =  4000},
                new Car{Id =3, BrandID =2, ColorID = 2, ModelYear ="2010",DailyPrice =  6000},
                new Car{Id =4, BrandID =3, ColorID = 3, ModelYear ="2015",DailyPrice =  8000},
                new Car{Id =5, BrandID =3, ColorID = 3, ModelYear ="2020",DailyPrice =  10000},
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

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(Car car)
        {
            return _car.Where(p => p.Id == car.Id).ToList();
        }

        public List<CarDetailDto> GetCarDetails(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            var updateCar = _car.FirstOrDefault(p => p.Id == car.Id);
            updateCar.ModelYear = car.ModelYear;
        }
    }
}
