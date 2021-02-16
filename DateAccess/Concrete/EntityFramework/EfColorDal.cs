using DateAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DateAccess.Concrete.EntityFramework
{
    class EfColorDal : IColorDal
    {
        public void Add(Color entity)
        {
            using (RentaCarContex contex=new RentaCarContex())
            {
                var addedColor = contex.Entry(entity);
                addedColor.State = EntityState.Added;
                contex.SaveChanges();
            }
        }

        public void Delete(Color entity)
        {
            using (RentaCarContex contex=new RentaCarContex())
            {
                var deletedColor = contex.Entry(entity);
                deletedColor.State = EntityState.Deleted;
                contex.SaveChanges();
            }
        }

        public Color Get(Expression<Func<Color, bool>> fitler)
        {
            using (RentaCarContex contex = new RentaCarContex())
            {
                return contex.Set<Color>().SingleOrDefault(fitler);
            }
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            using (RentaCarContex contex = new RentaCarContex())
            {
                return filter == null ? contex.Set<Color>().ToList() : contex.Set<Color>().Where(filter).ToList();
            }
        }

        public void Update(Color entity)
        {
            using (RentaCarContex contex = new RentaCarContex())
            {
                var updatedColor = contex.Entry(entity);
                updatedColor.State = EntityState.Modified;
                contex.SaveChanges();
            }
        }
    }
}
