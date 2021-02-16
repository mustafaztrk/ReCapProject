﻿using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DateAccess.Concrete.EntityFramework
{
   public  class RentaCarContex:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseSqlServer(@"Server = (localdb)\MSSQLLocalDB ; Database = ReCapProject; Trusted_Connection = true");
        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }
    }
}