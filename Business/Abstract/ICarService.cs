using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {

        List<Car> GetAll();
        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);
        Car GeyById(int id);
        List<Car> GetAllByColorId(int id);
        List<Car> GetAllByBrandId(int id);
        List<Car> GetByDailyPrice(int min, int max);
        List<CarDetailDto> GetCarDetail();

    }
}
