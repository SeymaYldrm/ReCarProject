using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }
        public void Add(Brands brand)
        {
            if (brand.BrandName.Length > 2)
            {
                _brandDal.Add(brand);
                Console.WriteLine("Marka başarıyla eklendi.");
            }
            else
            {
                Console.WriteLine($"Lütfen marka isminin uzunluğunu 2 karakterden fazla giriniz. Girdiğiniz marka ismi : {brand.BrandName}");
            }
        }

        public void Delete(Brands brand)
        {
            _brandDal.Delete(brand);
            Console.WriteLine("Marka başarıyla silindi.");
        }

        public List<Brands> GetAll()
        {
            return _brandDal.GetAll();
        }

        public Brands GetById(int id)
        {
            return _brandDal.Get(p => p.BrandID == id);
        }

        public void Update(Brands brand)
        {
            if (brand.BrandName.Length >= 2)
            {
                _brandDal.Update(brand);
                Console.WriteLine("Marka başarıyla Güncellendi.");
            }
            else
            {
                Console.WriteLine($"Lütfen marka isminin uzunluğunu 1 karakterden fazla giriniz. Girdiğiniz marka ismi : {brand.BrandName}");
            }
        }
    }
}
