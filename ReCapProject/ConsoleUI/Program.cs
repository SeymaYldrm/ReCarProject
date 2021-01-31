using Business.Concrete;
using DataAccess.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            var carList = carManager.GetAll();

            foreach (var car in carList)
            {
                Console.WriteLine("Id: " + car.Id);
                Console.WriteLine("Model Yılı: " + car.ModelYear);
                Console.WriteLine("Günlük Ücret: " + car.DailyPrice + " tl");
            }
        }
    }
}
