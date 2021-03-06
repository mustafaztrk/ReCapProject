﻿using Core.DateAccess.EntityFramework;
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
            using (RentaCarContex context = new RentaCarContex())
            {
                var result = from car in context.Cars
                             join brand in context.Brands
                             on car.BranId equals brand.Id
                             join color in context.Colors
                             on car.ColorId equals color.Id
                             select new CarDetailDto
                             {
                                 CarId = car.Id,
                                 BrandName = brand.BrandName,
                                 ColorName = color.ColorName,
                                 DailyPrice = car.DailyPrice,
                               
                             };

                return result.ToList();
            }
        }
    }
}
