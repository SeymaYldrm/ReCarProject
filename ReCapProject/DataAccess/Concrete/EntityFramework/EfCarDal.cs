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
                var result = from c in context.Cars
                             join co in context.Colors
                             on c.ColorID equals co.ColorID
                             join br in context.Brands
                             on c.BrandID equals br.BrandID
                             select new CarDetailDto
                             {
                                 Id = c.Id,
                                 BrandId = br.BrandID,
                                 BrandName = br.BrandName,
                                 Name = c.CarName,
                                 ColorId = co.ColorID,
                                 ColorName = co.ColorName,
                                 DailyPrice = c.DailyPrice,
                                 ModelYear = c.ModelYear
                             };

                return result.ToList();
            }
        }
    }
}
