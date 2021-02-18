using DateAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DateAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car{Id=1,BranId=2,ColorId=1,DailyPrice=100,Description="Ford Focus 2012" },
                new Car{Id=2,BranId=2,ColorId=2,DailyPrice=150,Description="Ford Fiesta 2020" },
                new Car{Id=3,BranId=3,ColorId=1,DailyPrice=250,Description="Reno Clio 2020" },
                new Car{Id=4,BranId=3,ColorId=1,DailyPrice=200,Description="Reno Clio  2018" },
                new Car{Id=5,BranId=5,ColorId=4,DailyPrice=350,Description="BMW 520d 2020" },
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> fiter = null)
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

        public List<Car> GetAllByBrandID(int brandID)//markaya göre filitreleme
        {
            return _cars.Where(p => p.BranId == brandID).ToList();
        }

        public List<CarDetailDto> GetCarDetail()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BranId = car.BranId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
