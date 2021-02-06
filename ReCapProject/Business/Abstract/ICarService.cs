using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ICarService
    {
        void Add(Cars car);
        void Update(Cars car);
        void Delete(Cars car);
        List<Cars> GetAll();
        Cars GetById(int id);
        List<Cars> GetAllByColorId(int id);
        List<Cars> GetAllByBrandId(int id);
        List<Cars> GetByDailyPrice(decimal min, decimal max);
        List<Cars> GetByModelYear(string year);
    }
}
