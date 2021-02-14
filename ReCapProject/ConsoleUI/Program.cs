using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());

            //Console.WriteLine("Markası BMW olan arabalar: \nId\tColor Name\tBrand Name\tModel Year\tDaily Price");
            //foreach (var car in carManager.GetAllByBrandId(1))
            //{
            //    Console.WriteLine($"{car.Id}\t{colorManager.GetById(car.ColorID).ColorName}\t\t{brandManager.GetById(car.BrandID).BrandName}\t\t{car.ModelYear}\t\t{car.DailyPrice}");
            //}

            //Console.WriteLine("\n\nId'si 4 olan araba: \nId\tColor Name\tBrand Name\tModel Year\tDaily Price");
            //Car carById = carManager.GetById(4);
            //Console.WriteLine($"{carById.Id}\t{colorManager.GetById(carById.ColorID).ColorName}\t\t{brandManager.GetById(carById.BrandID).BrandName}\t\t{carById.ModelYear}\t\t{carById.DailyPrice}");

            //Console.WriteLine("\n\nGünlük fiyat aralığı 1000 ile 1500 olan arabalar: \nId\tColor Name\tBrand Name\tModel Year\tDaily Price");
            //foreach (var car in IDataResult<List<Car>>(carManager.GetByDailyPrice(1000, 1500))
            //{
            //    Console.WriteLine($"{car.Id}\t{colorManager.GetById(car.ColorID).ColorName}\t\t{brandManager.GetById(car.BrandID).BrandName}\t\t{car.ModelYear}\t\t{car.DailyPrice}");
            //}

            Console.WriteLine("\n");

            carManager.Add(new Car { BrandID = 1, ColorID = 2, DailyPrice = -300, ModelYear = 2021 });
            brandManager.Add(new Brand { BrandName = "a" });

        }
    }
}
