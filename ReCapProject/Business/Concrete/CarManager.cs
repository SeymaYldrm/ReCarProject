using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Cars car)
        {
            if (car.DailyPrice > 0)
            {
                _carDal.Add(car);
                Console.WriteLine("Yeni Arabanız Listeye Başarıyla Eklenmiştir.");
            }
            else
            {
                Console.WriteLine($"Lütfen Aracın Günlük Fiyatını 0'dan Büyük Giriniz. Girdiğiniz Fiyat : {car.DailyPrice}");
            }
        }

        public void Delete(Cars car)
        {
            _carDal.Delete(car);
            Console.WriteLine("Arabanız Listeden Başarıyla Silinmiştir");
        }

        public List<Cars> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Cars> GetAllByBrandId(int id)
        {
            return _carDal.GetAll(p => p.BrandID == id);
        }

        public List<Cars> GetAllByColorId(int id)
        {
            return _carDal.GetAll(p => p.ColorID == id);
        }

        public List<Cars> GetByDailyPrice(decimal min, decimal max)
        {
            return _carDal.GetAll(p => p.DailyPrice >= min && p.DailyPrice <= max);
        }

        public Cars GetById(int id)
        {
            return _carDal.Get(p => p.Id == id);
        }

        public List<Cars> GetByModelYear(string year)
        {
            return _carDal.GetAll(p => p.ModelYear == year);
        }

        public void Update(Cars car)
        {
            _carDal.Update(car);
            Console.WriteLine("Arabanız Başarıyla Güncellenmiştir.");
        }
    }
}
