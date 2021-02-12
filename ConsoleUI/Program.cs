using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());


            //carManager.Add(new Car
            //{
            //    BrandId = 2,
            //    ColorId = 1,
            //    DailyPrice = 85,
            //    Description = "Günlük işleriniz için ideal.",
            //    ModelYear = "2012",
            //    Name = "Toyota Yaris"
            //});

            //carManager.Add(new Car
            //{
            //    BrandId = 1,
            //    ColorId = 4,
            //    DailyPrice = 60,
            //    ModelYear = "2011",
            //    Name = "Renault Symbol"
            //});


            foreach (var car in carManager.GetCarsByColorId(4))
            {
                Console.WriteLine(car.Name);
            }



            //foreach (var car in carManager.GetCarsByBrandId(1))
            //{
            //    Console.WriteLine(car.ModelYear);
            //}

            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.Name);
            //}

        }
    }
}
