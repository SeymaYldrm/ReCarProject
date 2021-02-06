using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }
        public void Add(Colors color)
        {
            _colorDal.Add(color);
            Console.WriteLine("Araba Renginiz Başarıyla Eklenmiştir.");
        }

        public void Delete(Colors color)
        {
            _colorDal.Delete(color);
            Console.WriteLine("Araba Renginiz Başarıyla Silinmiştir.");
        }

        public List<Colors> GetAll()
        {
            return _colorDal.GetAll();
        }

        public Colors GetById(int id)
        {
            return _colorDal.Get(p => p.ColorID == id);
        }

        public void Update(Colors color)
        {
            _colorDal.Update(color);
            Console.WriteLine("Araba Renginiz Başarıyla Güncellenmiştir.");
        }
    }
}
