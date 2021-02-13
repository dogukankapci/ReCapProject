﻿using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1,BrandId=1,ColorId=1, DailyPrice=80, Description="Ekonomik araç isteyenlere en ideal önerimiz.",ModelYear="2016"},
                new Car{CarId=2,BrandId=1,ColorId=1, DailyPrice=90, Description="Otomatik Vites",ModelYear="2017"},
                new Car{CarId=3,BrandId=1,ColorId=1, DailyPrice=100, Description="Bu aracı tercih ettiğinizde yakıt masraflarınız bizden!",ModelYear="2018"},
                new Car{CarId=4,BrandId=2,ColorId=2, DailyPrice=200, Description="Lüks araç kategorimizde uygun fiyatlı aracımız.",ModelYear="2019"},
                new Car{CarId=5,BrandId=2,ColorId=2, DailyPrice=500, Description="Konfor ve kalite arayanların tercihi",ModelYear="2020"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
