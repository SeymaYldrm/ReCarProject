using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : ICarDal
    {
        public void Add(Cars entity)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var addedCar = context.Entry(entity);
                addedCar.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Cars entity)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var deletedCar = context.Entry(entity);
                deletedCar.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Cars Get(Expression<Func<Cars, bool>> filter)
        {
            using (RentACarContext context = new RentACarContext())
            {
                return context.Set<Cars>().SingleOrDefault(filter);
            }
        }

        public List<Cars> GetAll(Expression<Func<Cars, bool>> filter = null)
        {
            using (RentACarContext context = new RentACarContext())
            {
                return filter == null ? context.Set<Cars>().ToList() : context.Set<Cars>().Where(filter).ToList();
            }
        }

        public void Update(Cars entity)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var updatedCar = context.Entry(entity);
                updatedCar.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
