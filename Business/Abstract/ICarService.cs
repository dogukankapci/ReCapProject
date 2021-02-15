using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();  // Tüm araçları getir.
        IDataResult<Car> Get(int id);  // Tüm araçları getir.
        IDataResult<List<Car>> GetCarsByBrandId(int id);  // Marka id'sine göre getirecek.
        IDataResult<List<Car>> GetCarsByColorId(int id);  // Renk id'sine göre getirecek.
        IDataResult<List<CarDetailDto>> GetCarDetails();
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);
        
    }
}
