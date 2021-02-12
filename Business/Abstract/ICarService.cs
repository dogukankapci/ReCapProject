using Entities.Concrete;
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
        void Add(Car car);
        
    }
}
