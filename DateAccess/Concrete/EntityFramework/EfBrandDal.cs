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
    public class EfBrandDal : IBrandDal
    {
        public void Add(Brand entity)
        {
            using (RentaCarContex contex=new RentaCarContex())
            {
                var AddEntity = contex.Entry(entity);
                AddEntity.State = EntityState.Added;
                contex.SaveChanges();

            }
        }

        public void Delete(Brand entity)
        {
            using (RentaCarContex contex=new RentaCarContex())
            {
                var deleteEntity = contex.Entry(entity);
                deleteEntity.State = EntityState.Deleted;
                contex.SaveChanges();
            }
        }

        public Brand Get(Expression<Func<Brand, bool>> filter)
        {
            using (RentaCarContex context=new RentaCarContex())
            {
                return context.Set<Brand>().SingleOrDefault(filter);
            }
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            using (RentaCarContex context = new RentaCarContex())
            {
                return filter==null?context.Set<Brand>().ToList():context.Set<Brand>().Where(filter).ToList();
            }
        }

        public void Update(Brand entity)
        {
            using (RentaCarContex contex=new RentaCarContex())
            {
                var updateEntity = contex.Entry(entity);
                updateEntity.State = EntityState.Modified;
                contex.SaveChanges();
            }
        }
    }
}
