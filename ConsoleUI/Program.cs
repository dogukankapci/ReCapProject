using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            Console.WriteLine("Araç Id'leri: \n");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Araç ID: " + car.CarId);
            }

            Console.WriteLine("\n\nMarkası '1' kategorine ait olan araçların Id'leri: \n");

            foreach (var car in carManager.GetById(1))
            {
                Console.WriteLine("Araç ID: " + car.CarId);
            }

            Console.WriteLine("\n\nMarkası '2' kategorine ait olan araçların Id'leri: \n");

            foreach (var car in carManager.GetById(2))
            {
                Console.WriteLine("Araç ID: " + car.CarId);
            }

        }
    }
}
