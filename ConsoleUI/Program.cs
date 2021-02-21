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

            Car sil = new Car() { Id = 1, ColorId = 2, DailyPrice = 9800, Description = "Premium araç" ,BranId=1};
            AracSil(sil);

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

            foreach (var car in carManager.GetCarDetail())
            {
                Console.WriteLine("{0}, {1}, {2}, {3}", car.CarId, car.BrandName, car.ColorName, car.DailyPrice);
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

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAllByBrandId(1))
            {
                Console.WriteLine(car.Description);
            }

            Console.WriteLine("-------------------------------------");

            foreach (var car in carManager.GetAllByColorId(1))
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}
