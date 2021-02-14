using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentACarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails(Expression<Func<Car, bool>> filter = null)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from car in filter is null ? context.Cars : context.Cars.Where(filter)
                             join color in context.Colors
                             on car.ColorID equals color.ColorID
                             join brand in context.Brands
                             on car.BrandID equals brand.BrandID
                             select new CarDetailDto
                             {
                                 Id = car.Id,
                                 BrandId = brand.BrandID,
                                 BrandName = brand.BrandName,
                                 Name = car.CarName,
                                 ColorId = co.Id,
                                 ColorName = co.Name,
                                 DailyPrice = car.DailyPrice,
                                 Description = car.Description,
                                 ModelYear = car.ModelYear
                             };

                return result.ToList();
            }
        }
    }
}
