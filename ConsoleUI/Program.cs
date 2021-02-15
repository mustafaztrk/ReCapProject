using Business.Concrete;
using DateAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Car carA = new Car { Id = 6, BranId = 6, ColorId = 3, DailyPrice = 130, Description = "Reno Clio 2015" };
            Car carB = new Car { Id = 7, BranId = 6, ColorId = 2, DailyPrice = 11, Description = "Reno Clio 2013" };

            CarManeger carManeger = new CarManeger(new InMemoryCarDal());
            foreach (var item in carManeger.GetAll())
            {
                Console.WriteLine(item.Description);
            }

        }
    }
}
