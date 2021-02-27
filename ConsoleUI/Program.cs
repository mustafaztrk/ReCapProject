using Business.Concrete;
using DateAccess.Concrete.EntityFramework;
using DateAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            CarDetailTest();

        }
        private static void AraçEkle(Car car)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(car);
           
        }

        private static void AracSil(Car car)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Update(car);

        }
        private static void CarDetailTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetail();
            foreach (var car in result.Data)
            {
                Console.WriteLine("{0}, {1}, {2}, {3}", car.CarId, car.BrandName, car.ColorName, car.DailyPrice);
                Console.WriteLine(result.Message);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.ColorName);
            }
        }

        //private static void CarTest()
        //{
        //    CarManager carManager = new CarManager(new EfCarDal());

        //    foreach (var car in carManager.GetAllByBrandId(1))
        //    {
        //        Console.WriteLine(car.Description);
        //    }

        //    Console.WriteLine("-------------------------------------");

        //    foreach (var car in carManager.GetAllByColorId(1))
        //    {
        //        Console.WriteLine(car.Description);
        //    }
        //}
    }
}
