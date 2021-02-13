using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();  // Tüm araçları getir.
        List<Car> GetCarsByBrandId(int id);  // Marka id'sine göre getirecek.
        List<Car> GetCarsByColorId(int id);  // Renk id'sine göre getirecek.
        List<CarDetailDto> GetCarDetails();
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
        
    }
}
