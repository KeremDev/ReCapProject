using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

internal class Program
{
    private static void Main(string[] args)
    {
        CarManager carmanager = new CarManager(new EfCarDal());

        carmanager.Delete(new Car {Id=1003,BrandId=4,ColorId=4,DailyPrice=3000,ModelYear="2002",Description="L202"});
        
        foreach (var car in carmanager.GetAll())
        {
            Console.WriteLine(car.Description);
        }
    }
}