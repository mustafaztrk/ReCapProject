using Core.DateAccess.EntityFramework;
using DateAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DateAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentaCarContex>, ICarDal
    {
        public List<CarDetailDto> GetCarDetail()
        {
            using (RentaCarContex context=new RentaCarContex())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.Id equals b.Id
                             join co in context.Colors
                             on c.ColorId equals co.Id
                             select new CarDetailDto
                             {
                                 CarId = c.Id,
                                 BrandName = b.BrandName,
                                 ColorName = co.ColorName
                             };

                return result.ToList();
            }
        }
    }
}
