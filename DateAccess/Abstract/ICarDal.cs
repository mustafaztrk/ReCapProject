using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DateAccess.Abstract
{
    public interface ICarDal
    {
        List<Car> GetAllByBrandID(int brandID);
        List<Car> GetAll();
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
    }
}
