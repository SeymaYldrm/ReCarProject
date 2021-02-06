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
    public class EfColorDal : IColorDal
    {
        public void Add(Colors entity)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var addedColor = context.Entry(entity);
                addedColor.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Colors entity)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var deleteColor = context.Entry(entity);
                deleteColor.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Colors Get(Expression<Func<Colors, bool>> filter)
        {
            using (RentACarContext context = new RentACarContext())
            {
                return context.Set<Colors>().SingleOrDefault(filter);
            }
        }

        public List<Colors> GetAll(Expression<Func<Colors, bool>> filter = null)
        {
            using (RentACarContext context = new RentACarContext())
            {
                return filter == null
                     ? context.Set<Colors>().ToList()
                     : context.Set<Colors>().Where(filter).ToList();
            }
        }

        public void Update(Colors entity)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var updatedColor = context.Entry(entity);
                updatedColor.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
