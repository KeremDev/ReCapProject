using Business.Concrete;
using Core.Entities.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Microsoft.Identity.Client;

internal class Program
{
    private static void Main(string[] args)
    {
        //CarAddListTest();
        //ColorListTest();
        //BrandListTest();
        //ColorAddListTest();
        //BrandGetByIdTest();
        //CarDtoListTest();
        //CarGetAllMessageTest();
        //UserAddTest();

        RentalManager rentalManager = new RentalManager(new EfRentalDal());
        var rentaladd = rentalManager.Add(new Rental { CarId = 5, CustomerId = 4, RentDate = DateTime.Now});
        Console.WriteLine(rentaladd.Message);
    }

    private static void UserAddTest()
    {
        UserManager userManager = new UserManager(new EfUserDal());
        var result = userManager.Add(new User { FirstName = "Mehmet", LastName = "Uca", Email = "gfasddddd@gmail.com"});
        Console.WriteLine(result.Message);
    }

    private static void CarGetAllMessageTest()
    {
        CarManager carManager = new CarManager(new EfCarDal());
        var result = carManager.GetAll();

        if (result.Success == true)
        {
            foreach (var car in result.Data)
            {
                Console.WriteLine(car.Description);
            }
        }
        else
        {
            Console.WriteLine(result.Message);
        }
    }

    private static void CarDtoListTest()
    {
        CarManager carManager = new CarManager(new EfCarDal());
        foreach (var car in carManager.GetCarDetails().Data)
        {
            Console.WriteLine(car.Id + "/" + car.BrandName + "/" + car.ColorName + "/" + car.DailyPrice);
        }
    }

    private static void BrandGetByIdTest()
    {
        BrandManager brandManager = new BrandManager(new EfBrandDal());
        var result = brandManager.GetById(2);
        Console.WriteLine(result.Data.BrandName);
    }

    private static void ColorAddListTest()
    {
        ColorManager colorManager = new ColorManager(new EfColorDal());
        colorManager.Add(new Color { ColorName = "Pink" });
        foreach (var color in colorManager.GetAll().Data)
        {
            Console.WriteLine(color.ColorName);
        }
    }

    private static void BrandListTest()
    {
        BrandManager brandManager = new BrandManager(new EfBrandDal());
        var result= brandManager.GetAll();
        foreach (var brand in result.Data)
        {
            Console.WriteLine(brand.BrandName);
        }
    }

    private static void ColorListTest()
    {
        ColorManager colorManager = new ColorManager(new EfColorDal());

        foreach (var color in colorManager.GetAll().Data)
        {
            Console.WriteLine(color.ColorName);
        }
    }

    private static void CarAddListTest()
    {
        CarManager carmanager = new CarManager(new EfCarDal());

        carmanager.Add(new Car { BrandId = 2, ColorId = 2, DailyPrice = 4800, ModelYear = "2025", Description = "Micra" });

        foreach (var car in carmanager.GetAll().Data)
        {
            Console.WriteLine(car.Description);
        }
    }
}