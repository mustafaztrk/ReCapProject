using Business.Abstract;
using DateAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManeger : ICarService
    {
        ICarDal _carDal;
        public CarManeger(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            //Araba ismi minimum 2 karakter olmalıdır
            //Araba günlük fiyatı 0'dan büyük olmalıdır
            if (car.DailyPrice>0&&car.Description.Length>=2)
            {
                _carDal.Add(car);
                Console.WriteLine("ok");
            }
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }
        public void Update(Car car)
        {
            _carDal.Update(car);
        }
        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetAllByBrandId(int id)
        {
            return _carDal.GetAll(p => p.BranId == id);
        }

        public List<Car> GetAllByColorId(int id)
        {
            return _carDal.GetAll(p => p.ColorId == id);
        }

        public List<Car> GetByDailyPrice(int min, int max)
        {
            return _carDal.GetAll(p => p.DailyPrice>=min&&p.DailyPrice<=max);
        }

        public Car GeyById(int id)
        {
            return _carDal.Get(p => p.Id == id);
        }

        public List<CarDetailDto> GetCarDetail()
        {
            return _carDal.GetCarDetail();
        }
    }
}
