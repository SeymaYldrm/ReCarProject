using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal : IBrandDal
    {
        public void Add(Brands entity)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var addedBrand = context.Entry(entity);
                addedBrand.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Brands entity)
        {
           using(RentACarContext context = new RentACarContext())
            {
                var deletedBrand = context.Entry(entity);
                deletedBrand.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Brands Get(Expression<Func<Brands, bool>> filter)
        {
            using (RentACarContext context = new RentACarContext())
            {
                return context.Set<Brands>().SingleOrDefault(filter);
            }
        }

        public List<Brands> GetAll(Expression<Func<Brands, bool>> filter = null)
        {
            using (RentACarContext context = new RentACarContext())
            {
                return filter == null
                     ? context.Set<Brands>().ToList()
                     : context.Set<Brands>().Where(filter).ToList();
            }
        }

        public void Update(Brands entity)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var updatedBrand = context.Entry(entity);
                updatedBrand.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
