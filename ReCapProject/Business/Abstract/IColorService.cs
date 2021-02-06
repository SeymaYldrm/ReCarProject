using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IColorService
    {
        void Add(Colors color);
        void Update(Colors color);
        void Delete(Colors color);
        List<Colors> GetAll();
        Colors GetById(int id);
    }
}
