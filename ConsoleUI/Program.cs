using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

internal class Program
{
    private static void Main(string[] args)
    {
        //CarAddListTest();
        //ColorListTest();
        //BrandListTest();
        //ColorAddListTest();
        //BrandGetByIdTest();
        CarManager carManager = new CarManager(new EfCarDal());
        foreach (var car in carManager.GetCarDetails())
        {
            Console.WriteLine(car.Id + "/" + car.BrandName + "/" + car.ColorName + "/" + car.DailyPrice);
        }


    }

    private static void BrandGetByIdTest()
    {
        BrandManager brandManager = new BrandManager(new EfBrandDal());
        var result = brandManager.GetById(2);
        Console.WriteLine(result.BrandName);
    }

    private static void ColorAddListTest()
    {
        ColorManager colorManager = new ColorManager(new EfColorDal());
        colorManager.Add(new Color { ColorName = "Pink" });
        foreach (var color in colorManager.GetAll())
        {
            Console.WriteLine(color.ColorName);
        }
    }

    private static void BrandListTest()
    {
        BrandManager brandManager = new BrandManager(new EfBrandDal());
        foreach (var brand in brandManager.GetAll())
        {
            Console.WriteLine(brand.BrandName);
        }
    }

    private static void ColorListTest()
    {
        ColorManager colorManager = new ColorManager(new EfColorDal());

        foreach (var color in colorManager.GetAll())
        {
            Console.WriteLine(color.ColorName);
        }
    }

    private static void CarAddListTest()
    {
        CarManager carmanager = new CarManager(new EfCarDal());

        carmanager.Add(new Car { BrandId = 4, ColorId = 4, DailyPrice = 3000, ModelYear = "2002", Description = "L202" });

        foreach (var car in carmanager.GetAll())
        {
            Console.WriteLine(car.Description);
        }
    }
}