﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Cars> _car;
        public InMemoryCarDal()
        {
            _car = new List<Cars>
            {
                new Cars{Id =1, BrandID =1, ColorID = 1, ModelYear ="2000",DailyPrice =  2000},
                new Cars{Id =2, BrandID =1, ColorID = 2, ModelYear ="2005",DailyPrice =  4000},
                new Cars{Id =3, BrandID =2, ColorID = 2, ModelYear ="2010",DailyPrice =  6000},
                new Cars{Id =4, BrandID =3, ColorID = 3, ModelYear ="2015",DailyPrice =  8000},
                new Cars{Id =5, BrandID =3, ColorID = 3, ModelYear ="2020",DailyPrice =  10000},
            };
        }
        public void Add(Cars car)
        {
            _car.Add(car);
        }

        public void Delete(Cars car)
        {
            var deleteCar = _car.Where(p => p.Id == car.Id).FirstOrDefault();
            _car.Remove(deleteCar);
        }

        public Cars Get(Expression<Func<Cars, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Cars> GetAll()
        {
            return _car;
        }

        public List<Cars> GetAll(Expression<Func<Cars, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Cars> GetById(Cars car)
        {
            return _car.Where(p => p.Id == car.Id).ToList();
        }

        public void Update(Cars car)
        {
            var updateCar = _car.FirstOrDefault(p => p.Id == car.Id);
            updateCar.ModelYear = car.ModelYear;
        }
    }
}