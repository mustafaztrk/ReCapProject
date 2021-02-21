using Business.Abstract;
using DateAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
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
            }
            else
            {
                Console.WriteLine("Günlük ücret 0'dan büyük olmalı ve Araba ismi en az iki karakterden oluşmalıdır !");
            }
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }
        public void Update(Car car)
        {
            if (car.Description.Length >= 2 && car.DailyPrice > 0)
            {
                _carDal.Update(car);
                Console.WriteLine("Araba güncellendi");
            }
            else
            {
                Console.WriteLine("Günlük ücret 0'dan büyük olmalı ve Araba ismi en az iki karakterden oluşmalıdır !");
            }
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
