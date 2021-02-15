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
            #region Daha Sonra Düzenlenecek!
            //Console.WriteLine(" Araç Kiralama - Menü");
            //Console.WriteLine(" 1- Tüm araçları getir");
            //Console.WriteLine(" 2- Tüm renk seçeneklerini getir");
            //Console.WriteLine(" 3- Tüm markaları getir");
            //Console.WriteLine(" 4- Yeni Araç Ekle");
            //Console.WriteLine(" 5- Yeni Marka Ekle");
            //Console.WriteLine(" 6- Yeni Renk Ekle");
            //Console.WriteLine(" 7- Araç Detay Getir");
            #endregion


            CarDetail();


            // araç güncelleme
            //carManager.Update(new Car
            //{
            //    BrandId = 1,
            //    CarId = 6,
            //    ColorId = 4,
            //    ModelYear = "2013",
            //    DailyPrice = 65,
            //    Name = "Renault Symbol",
            //    Description = "Manuel vites. Dizel."
            //});

            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine("{0}-{1}-{2}-{3}", car.Name, car.ModelYear, car.DailyPrice, car.Description);
            //}

            // araç ekleme
            //carManager.Add(new Car
            //{
            //    BrandId = 2,
            //    ColorId = 1,
            //    DailyPrice = 20,
            //    Description = "Silinecek araç",
            //    ModelYear = "2012",
            //    Name = "Suzuki"
            //});

            // araç silme
            //carManager.Delete(new Car
            //{
            //    CarId = 7,
            //    BrandId = 2,
            //    ColorId = 1,
            //    DailyPrice = 20,
            //    Description = "Silinecek araç",
            //    ModelYear = "2012",
            //    Name = "Suzuki"
            //});

            //carManager.Add(new Car
            //{
            //    BrandId = 1,
            //    ColorId = 4,
            //    DailyPrice = 60,
            //    ModelYear = "2011",
            //    Name = "Renault Symbol"
            //});


            //foreach (var car in carManager.GetCarsByColorId(4))
            //{
            //    Console.WriteLine(car.Name);
            //}



            //foreach (var car in carManager.GetCarsByBrandId(1))
            //{
            //    Console.WriteLine(car.ModelYear);
            //}

            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.Name);
            //}

        }

        private static void CarDetail()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            Console.WriteLine("\nAraç\t\tMarka\t Renk\tÜcret\tAçıklama");
            Console.WriteLine("------------------------------------------------");

            var result = carManager.GetCarDetails();

            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarName + "\t" + car.BrandName + "\t" + car.ColorName + "\t " + car.DailyPrice + "\t" + car.Description);
                }
                Console.WriteLine("\n" + result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
            }

        }
    }
}
