using Business.Concrete;
using Core.Entities.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(new Brand { BrandName = "Alfa Romeo" });
            brandManager.GetAll();
            brandManager.GetById(1);

            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Add(new Color { ColorName = "Sarı" });
            colorManager.GetAll();
            colorManager.GetById(3);

            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car { CarName = "Aston Martin", BrandID = 1, ColorID = 1, DailyPrice = 1200, ModelYear = 2015 });
            carManager.GetAll();
            carManager.GetCarDetails();
            carManager.GetAllByBrandId(2);

            UserManager userManager = new UserManager(new EfUserDal());
            userManager.Add(new User { Email = "sena@gmail.com", FirstName = "Sena", LastName = "Kahveci"});

            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            customerManager.Add(new Customer { UserID = 2, CompanyName = "Doğuş Holding" });

            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            rentalManager.Add(new Rental { CarId = 1, CustomerId = 1, RentDate = DateTime.Now, ReturnDate = DateTime.Now });
        }
    }
}
